/**
 * Copyright (c) 2009-2011, The HSL Contributors.
 *
 * This file is part of HSL. HSL, pronounced "hustle", stands for haXe Signaling Library.
 *
 * HSL is free software. Redistribution and use in source and binary forms, with or without modification, are permitted
 * provided that the following conditions are met:
 *
 *   * Redistributions of source code must retain the above copyright notice, this list of conditions and the following
 *     disclaimer.
 *   * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following
 *     disclaimer in the documentation and/or other materials provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY THE HSL CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED
 * TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE HSL
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
 * NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR
 * OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * End of conditions.
 * 
 * The license of this software might change in the future, most likely to match the license of the haXe core libraries. In
 * such event, you may use this version of this software under either the terms above or under the terms of the new license of
 * this software.
 */
package hsl.haxe;
import haxe.exception.Exception;
import haxe.Timer;
import hsl.haxe.DirectSignaler;

/**
 * A signaler that delays signals, merging signals that are dispatched right after another. If the signaler merges multiple
 * signals, to the outside world, it will be as if only the last signal was dispatched.
 * 
 * This type of signaler is useful if, for instance, you have a slider and you perform some heavy logic whenever the user
 * changes the value of that slider. If the user changes that value a couple of times in one second, you'd want the logic to be
 * performed only once. The merging signaler helps achieve this, by merging the signals dispatched whenever the value changes
 * into one signal.
 */
class MergingSignaler<Datatype> extends DirectSignaler<Datatype> {
	private var delay:Int;
	private var stagedData:Datatype;
	private var stagedOrigin:Subject;
	/**
	 * Whether a timer that will call the complete method is currently running (true) or not (false).
	 */
	private var timerRunning:Bool;
	/**
	 * Creates a new merging signaler.
	 * 
	 * The passed subject will be used as the subject of this signaler. Only the subject is allowed to call the dispatch method.
	 * Signals dispatched by this signaler will have the subject as current target, and in some cases as origin.
	 * 
	 * The passed delay defines how long the signaler waits after the first signal was dispatched before dispatching the merged
	 * signal. Zero (0) is a valid value, passing null or nothing is equivalent to passing zero.
	 * 
	 * If the reject null data flag is set, the signaler will throw an exception if the subject attempts to dispatch a signal
	 * with null as data, or the the signaler is about to bubble a signal that contains null as data.
	 */
	public function new(subject:Subject, ?delay:Int, ?rejectNullData:Bool):Void {
		super(subject, rejectNullData);
		this.delay =
			if (null == delay) {
				0;
			} else {
				delay;
			}
		// Set timerRunning to false, unless the target is AVM2, as in that case the default value is false anyway.
		#if !flash9
		timerRunning = false;
		#end
	}
	private function complete():Void {
		// Grab the origin.
		stagedOrigin = getOrigin(stagedOrigin);
		// Call all the listeners and bubble the signal, if propagation was not stopped.
		if (PropagationStatus.UNDISTURBED == sentinel.callListener(stagedData, subject, stagedOrigin, PropagationStatus.UNDISTURBED)) {
			bubble(stagedData, stagedOrigin);
		}
		// Update the flag, as the timer is now no longer running.
		timerRunning = false;
	}
	#if (as3 || production)
	public override function dispatch(?data:Datatype, ?origin:Subject):Void {
	#else
	public override function dispatch(?data:Datatype, ?origin:Subject, ?positionInformation:haxe.PosInfos):Void {
	#end
		#if !production
		#if as3
		// As the automagic position information cannot be used in AS3, use the stacktrace to grab the position information. The
		// following code could be faster, as Stack.callStack() is more expensive than it could be.
		var positionInformation:haxe.PosInfos = null;
		for (stackItem in haxe #if haxe_211 .CallStack #else .Stack #end .callStack().slice(1)) {
			switch (stackItem) {
				case FilePos(innerStackItem, fileName, line):
				switch (innerStackItem) {
					case Method(className, methodName):
					positionInformation = {fileName: fileName, lineNumber: line, className: className, methodName: methodName, customParams: null};
					default:
				}
				break;
				default:
			}
		}
		if (null != positionInformation && "dispatchNative" != positionInformation.methodName && "bubble" != positionInformation.methodName) {
			verifyCaller(positionInformation);
		}
		#else
		// Verify the caller of this method, which should be the subject of this signaler. As you can see, there's nasty hack here
		// which makes bubbling and dispatching from the translating signalers possible.
		if ("dispatchNative" != positionInformation.methodName && "bubble" != positionInformation.methodName) {
			verifyCaller(positionInformation);
		}
		#end
		#end
		// Verify the data.
		if (rejectNullData && null == data) {
			throw new Exception("Some data that was passed is null, but this signaler has been set to reject null data.", null, 1);
		}
		// Stage the data and origin, overwriting any existing staged data and origin.
		stagedData = data;
		stagedOrigin = origin;
		// Make sure the complete method is called after the delay.
		if (false == timerRunning) {
			#if flash9
			untyped __global__["flash.utils.setTimeout"](complete, delay);
			#elseif flash
			untyped _global["setTimeout"](complete, delay);
			#elseif js
			untyped window.setTimeout(complete, delay);
			#else
			Timer.delay(complete, delay);
			#end
			timerRunning = true;
		}
	}
}