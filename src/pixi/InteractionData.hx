package pixi;
@:native('PIXI.InteractionData')
extern class InteractionData {
  public function new():Void;
  public function getLocalPosition(displayObject:DisplayObject):Point;

  public var global:Point;
  //public var originalEvent:js.html.Event;
  public var target:Sprite;
}

