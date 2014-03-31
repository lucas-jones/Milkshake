package pixi;
@:native('PIXI.Sprite')
extern class Sprite extends DisplayObjectContainer {
  public function new(texture:Texture):Void;
  public function setTexture(texture:Texture):Void;
  public static function fromFrame(frameId:String):Sprite;
  public static function fromImage(image:Dynamic):Sprite; // image object or url

  public var anchor:Point;
  public var blendMode:Point;
  public var width:Float;
  public var height:Float;
  public var texture:Texture;
}