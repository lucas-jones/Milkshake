package pixi;
@:native('PIXI.TilingSprite')
extern class TilingSprite extends DisplayObjectContainer {
  public function new(texture:Texture, width:Float, height:Float):Void;

  public var tilePosition:pixi.Point;
  public var tileScale:pixi.Point;
}