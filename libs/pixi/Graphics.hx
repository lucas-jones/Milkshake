package pixi;
@:native('PIXI.Graphics')
extern class Graphics extends DisplayObjectContainer {
  public function new():Void;
  public function drawRect(x:Float, y:Float, width:Float, height:Float):Void;
  public function lineStyle(width:Float, color:Int):Void;
  public function beginFill(color:Int):Void;
  public function endFill():Void;
}