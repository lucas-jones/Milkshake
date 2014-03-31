package pixi;
@:native('PIXI.EventTarget')
extern class EventTarget<T> {
  public function addEventListener(type:String, listener:Event<T>->Void):Void;
  public function dispatchEvent(event:Event<T>):Void;
  public function removeEventListener(type:String, listener:Event<T>->Void):Void;
}