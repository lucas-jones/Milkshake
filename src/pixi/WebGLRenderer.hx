package pixi;
@:native('PIXI.WebGLRenderer')
extern class WebGLRenderer implements IRenderer {
  public function new(width:Float,height:Float,view:js.html.CanvasElement,transparent:Bool):Void;
  public function render(stage:Stage):Void;
  public function resize(width:Float,height:Float):Void;

  public var width:Float;
  public var height:Float;
  public var view:js.html.CanvasElement;
  public var transparent:Bool;
}
