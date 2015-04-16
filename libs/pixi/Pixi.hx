package pixi;

@:publicFields
@:native('PIXI')
extern class Pixi
{
  public static function autoDetectRenderer(width:Float, height:Float, view:js.html.Element):IRenderer;
  public static var batch:Array<Dynamic>;

  public static var TextureCache:Dynamic;
}
