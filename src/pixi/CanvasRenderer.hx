package pixi;
@:native('PIXI.CanvasRenderer')
extern class CanvasRenderer implements IRenderer {
  public function new(width:Float,height:Float,view:js.html.CanvasElement,transparent:Bool):Void;
  public function render(stage:Stage):Void;

  public var width:Float;
  public var height:Float;
  public var view:js.html.CanvasElement;
  public var context:js.html.CanvasRenderingContext;
}