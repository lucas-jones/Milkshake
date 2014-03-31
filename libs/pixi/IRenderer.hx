package pixi;

interface IRenderer {
	#if js
  public var view: js.html.CanvasElement;
  #end
  public function render(stage:pixi.Stage):Void;
}