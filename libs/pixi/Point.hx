package pixi;
@:native('PIXI.Point')
extern class Point {
  public function new(x:Float,y:Float):Void;
  public function clone():Point;

  public var x:Float;
  public var y:Float;
}