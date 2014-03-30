package pixi;
@:native('PIXI.JsonLoader')
extern class JsonLoader extends EventTarget<JsonLoader> {

  public function new(url:String, crossorigin:Bool = true):Void;
  public function load():Void;

  public var json:Dynamic;

}