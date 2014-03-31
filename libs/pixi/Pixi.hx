package pixi;

@:publicFields
@:native('PIXI')
extern class Pixi {
  static function autoDetectRenderer(width:Int, height:Int, view:js.html.Element):IRenderer;
  static var batch:Array<Dynamic>;
}
