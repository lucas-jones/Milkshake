package pixi;
@:native('PIXI.Graphics')
extern class Graphics extends DisplayObjectContainer {
  public function new():Void;
  public function drawRect(x:Float, y:Float, width:Float, height:Float):Void;
  public function lineStyle(width:Float, color:Int):Void;
  public function beginFill(color:Int, ?alpha:Float = 1):Void;
  public function moveTo(x:Float, y:Float):Void;
  public function lineTo(x:Float, y:Float):Void;
  public function clear():Void;
  public function endFill():Void;
}