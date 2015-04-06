package milkshake.utils;

import js.Browser;
import js.html.RequestAnimationFrameCallback;

class RAFHelper 
{
	public var multiplier:Float;

	var updateCallback:Float->Void;
	var lastTimeStamp:Float;

	public function new(updateCallback:Float->Void):Void
	{
		this.updateCallback = updateCallback;
		this.multiplier = 1;
	}

	public function start()
	{
		Browser.window.requestAnimationFrame(update);
	}

	function update(deltaTime:Float):Bool
	{
		var modifiedDeltaTime:Float = (deltaTime - lastTimeStamp) * multiplier;

		updateCallback(modifiedDeltaTime);

		start();

		lastTimeStamp = deltaTime;

		return true;
	}
}