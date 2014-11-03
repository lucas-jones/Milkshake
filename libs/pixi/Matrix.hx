package pixi;
@:native('PIXI.Matrix')
extern class Matrix {
  public function new():Void;
  public function identity():Void;
  public function translate(x:Float, y:Float):Void;
}