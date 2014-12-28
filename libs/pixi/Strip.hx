package pixi;

import js.html.Float32Array;
import js.html.Uint16Array;

import pixi.DisplayObjectContainer;
import pixi.Point;
import pixi.Texture;

@:native('PIXI.Strip')
extern class Strip extends DisplayObjectContainer
{
	public function new(texture:Texture);

	public var uvs:Float32Array;
	public var vertices:Float32Array;
	public var colors:Float32Array;
	public var indices:Uint16Array;
}