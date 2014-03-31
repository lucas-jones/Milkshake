package pixi;
@:native('PIXI.DisplayObjectContainer')
extern class DisplayObjectContainer extends DisplayObject {
  public function new():Void;
  public function addChild(child:DisplayObject):Void;
  public function addChildAt(child:DisplayObject, index:Int):Void;
  public function getChildAt(index:Int):DisplayObject;
  public function removeChild(child:DisplayObject):Void;
  public function swapChildren(child1:DisplayObject, child2:DisplayObject):Void;

  public var children:DisplayObject;
}