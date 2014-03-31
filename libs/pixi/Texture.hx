package pixi;
@:native('PIXI.Texture')
extern class Texture extends EventTarget<Texture> {
  public function new(baseTexture:BaseTexture,frame:Rectangle);

  public static function addTextureToCache(texture:Texture, id:String):Void;
  #if js
  public static function fromCanvas(canvas:js.html.CanvasElement):Texture;
  #end
  public static function fromFrame(frameId:String):Texture;
  public static function fromImage(path:String):Texture;
  public static function removeTextureFromCache(id:String):Void;
  public static function setFrame(frame:Rectangle):Void;
}