package milkshake.utils;

import js.Browser;

class RAFHelper
{
	public var multiplier:Float;

	var updateCallback:Float->Void;
	var lastTimeStamp:Float = -1;

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
		if(lastTimeStamp == -1) lastTimeStamp = deltaTime;

		var modifiedDeltaTime:Float = (deltaTime - lastTimeStamp) * multiplier;

		updateCallback(modifiedDeltaTime);

		start();

		lastTimeStamp = deltaTime;

		return true;
	}
}