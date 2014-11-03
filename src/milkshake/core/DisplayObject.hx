package milkshake.core;

import milkshake.core.Node;

import milkshake.game.scene.Scene;
import milkshake.math.Vector2;
import pixi.DisplayObjectContainer;

class DisplayObject extends Entity
{
	public var scene(get, set):Scene;
	var _scene:Scene;
	
	public var scale(default, null):Vector2;
	public var pivot(default, null):Vector2;
	public var rotation(default, null):Float;
	
	public var visible(default, null):Bool;
	public var alpha:Float;

	public var displayObject(default, null):DisplayObjectContainer;

	public function new(?id:String)
	{
		super(id);

		scale = Vector2.ONE;
		pivot = Vector2.ONE;
		rotation = 0;

		visible = true;
		alpha = 1;

		displayObject = new DisplayObjectContainer();
	}
	
	override public function addNode(node:Node, ?defaultValues:Dynamic):Void 
	{
		if (Std.is(node, DisplayObject))
		{
			var displayObjectNode:DisplayObject = cast node;
			
			displayObject.addChild(displayObjectNode.displayObject);
			displayObjectNode.scene = scene;
			displayObjectNode.create();
		}
		
		super.addNode(node, defaultValues);
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

	override public function update(delta:Float):Void
	{
		displayObject.position.x = position.x;
		displayObject.position.y = position.y;

		displayObject.scale.x = scale.x;
		displayObject.scale.y = scale.y;

		displayObject.alpha = alpha;
		
		displayObject.pivot.x = pivot.x;
		displayObject.pivot.y = pivot.y;

		displayObject.rotation = rotation;
		
		displayObject.visible = visible;
		displayObject.alpha = alpha;
	
		super.update(delta);
	}

	public function get_scene():Scene
	{
		return _scene;
	}

	public function set_scene(scene:Scene):Scene
	{		
		for(node in nodes)
		{
			if (Std.is(node, DisplayObject))
			{
				var displayObjectNode:DisplayObject = cast node;
				displayObjectNode.scene = scene;
			}
		}

		return _scene = scene;
	}

	public function create():Void
	{
		
	}

	public function destroy():Void
	{
		
	}
}