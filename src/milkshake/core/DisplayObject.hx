package milkshake.core;

import milkshake.core.Node;

import milkshake.game.scene.Scene;
import pixi.DisplayObjectContainer;

class DisplayObject extends Entity
{
	public var scene(default, default):Scene;
	
	public var visible(get, set):Bool;	

	public var displayObject(default, null):DisplayObjectContainer;

	public function new(?id:String)
	{
		super(id);

		displayObject = new DisplayObjectContainer();
	}
	
	override public function addNode(node:Node):Void 
	{
		if (Std.is(node, DisplayObject))
		{
			var displayObjectNode:DisplayObject = cast node;
			
			displayObject.addChild(displayObjectNode.displayObject);
			displayObjectNode.scene = scene;
			displayObjectNode.create();
		}
		
		super.removeNode(node);
	}
	
	override public function removeNode(node:Node):Void 
	{
		if (Std.is(node, DisplayObject))
		{
			var displayObjectNode:DisplayObject = cast node;
			
			displayObject.removeChild(displayObjectNode.displayObject);
			displayObjectNode.scene = null;
			displayObjectNode.destroy();
		}
		
		super.removeNode(node);
	}


	public function create():Void
	{
		
	}

	public function destroy():Void
	{
		
	}
	
	public function get_visible():Bool { return displayObject.visible; }
	public function set_visible(value:Bool):Bool { return displayObject.visible = value; }
}