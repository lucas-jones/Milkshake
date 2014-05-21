package pixi;
@:native('PIXI.BaseTexture')
extern class BaseTexture {
  public function new(source:String);

  public static function fromImage(imageUrl:String, ?scaleMode:Int):BaseTexture;

  public var width(default, null):Float;
  public var height(default, null):Float;
  #if js
  public var source:js.html.Image;
  #end
}