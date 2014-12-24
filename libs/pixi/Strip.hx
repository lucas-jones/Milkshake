package pixi;

import pixi.DisplayObjectContainer;
import pixi.Point;
import pixi.Texture;

@:native('PIXI.Strip')
extern class Strip extends DisplayObjectContainer
{
	public function new(texture:Texture, width:Float, height:Float);
}