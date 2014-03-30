package pixi;
@:native('PIXI.Stage')
extern class Stage extends DisplayObjectContainer {

  @:overload(function(color:Int):Void{})
  public function new(color:Int, interactive:Bool):Void;
  public function getMousePosition():Point;
  public function setBackgroundColor(color:Int):Void;
  public function updateTransform():Void;

}