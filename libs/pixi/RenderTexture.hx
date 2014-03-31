package pixi;
@:native('PIXI.RenderTexture')
extern class RenderTexture extends Texture {
  public function new(width:Int, height:Int):Void;
  public function render(displayObject:DisplayObject, clear:Bool):Void;
}