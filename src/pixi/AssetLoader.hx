package pixi;
@:native('PIXI.AssetLoader')
extern class AssetLoader extends EventTarget<AssetLoader> {
  public function new(assetURLs:Array<String>):Void;
  public function load():Void;
  public var onComplete:Void->Void;
  public var onProgress:Void->Void;
}