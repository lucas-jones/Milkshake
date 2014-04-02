package milkshake.core;

import milkshake.core.Node;
import pixi.DisplayObject;
import pixi.DisplayObjectContainer;

class GameObject extends Entity
{
	public var displayObject:DisplayObjectContainer;
	
	public var scaleX(get, set):Float;
	public var scaleY(get, set):Float;
	public var pivotX(get, set):Float;
	public var pivotY(get, set):Float;
	public var visible(get, set):Bool;
	public var rotation(get, set):Float;
	
	public function new(id:String = "undefined-gameobject") 
	{
		super(id);
		
		displayObject = new DisplayObjectContainer();
	}
	
	override public function addNode(node:Node):Void 
	{
		if (Std.is(node, GameObject))
		{
			var gameObject:GameObject = cast node;
			
			displayObject.addChild(gameObject.displayObject);
		}
		
		super.addNode(node);
	}
	
	override public function removeNode(node:Node):Void 
	{
		if (Std.is(node, GameObject))
		{
			var gameObject:GameObject = cast node;
			
			displayObject.removeChild(gameObject.displayObject);
		}
		
		super.removeNode(node);
	}
	
	override public function set_x(value:Float):Float 
	{
		displayObject.position.x = value;
		
		return super.set_x(value);
	}
	
	override public function set_y(value:Float):Float 
	{
		displayObject.position.y = value;
		
		return super.set_y(value);
	}
	
	public function get_scaleX():Float { return displayObject.scale.x; }
	public function set_scaleX(value:Float):Float { return displayObject.scale.x = value; }
	
	public function get_scaleY():Float { return displayObject.scale.y; }
	public function set_scaleY(value:Float):Float { return displayObject.scale.y = value; }
	
	public function get_rotation():Float { return displayObject.rotation; }
	public function set_rotation(value:Float):Float { return displayObject.rotation = value; }
	
	public function get_pivotX():Float { return displayObject.pivot.x; }
	public function set_pivotX(value:Float):Float { return displayObject.pivot.x = value; }
	
	public function get_pivotY():Float { return displayObject.pivot.y; }
	public function set_pivotY(value:Float):Float { return displayObject.pivot.y = value; }
	
	public function get_visible():Bool { return displayObject.visible; }
	public function set_visible(value:Bool):Bool { return displayObject.visible = value; }
}