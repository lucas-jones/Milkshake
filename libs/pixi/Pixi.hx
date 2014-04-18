package pixi;

@:publicFields
@:native('PIXI')
extern class Pixi {
  static function autoDetectRenderer(width:Float, height:Float, view:js.html.Element):IRenderer;
  static var batch:Array<Dynamic>;
}
