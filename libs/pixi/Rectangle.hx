package pixi;
@:native('PIXI.Rectangle')
extern class Rectangle {
  public function new(x:Float, y:Float, width: Float, height:Float):Void;
  public function clone():Rectangle;

  public var x:Float;
  public var y:Float;
  public var width:Float;
  public var height:Float;
}