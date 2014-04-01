package milkshake.core;

import milkshake.core.Node;
import pixi.DisplayObjectContainer;

class GameObject extends Entity
{
	public var displayObject:DisplayObjectContainer;
	
	public function new(id:String="undefined-gameobject") 
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
}