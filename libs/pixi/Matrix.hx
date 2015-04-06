package pixi;

import pixi.Point;

@:native('PIXI.Matrix')
extern class Matrix
{
	public function new():Void;

	public function identity():Void;
	public function translate(x:Float, y:Float):Void;
	public function scale(x:Float, y:Float):Void;
	public function rotate(angle:Float):Void;

	public function apply(point:Point):Point;
	public function applyInverse(point:Point):Point;
}