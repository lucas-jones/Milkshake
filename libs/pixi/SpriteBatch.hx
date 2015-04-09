package pixi;

import pixi.DisplayObjectContainer;

@:native("PIXI.SpriteBatch")
extern class SpriteBatch extends DisplayObjectContainer
{
	function new(?texture:Dynamic);	

	function _renderCanvas(renderSession:Dynamic):Void;
}
