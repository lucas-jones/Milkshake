package milkshake.game.scene.component;

import hsl.haxe.Signaler.Signaler;
import milkshake.core.Entity;
import milkshake.core.Node;

class SceneComponentManager extends Entity
{
	public var onComponentAdded(default, null):Signaler<SceneComponent>;
	public var onComponentRemoved(default, null):Signaler<SceneComponent>;
	
	public function new() 
	{
		super("SceneComponentManager");
	}
	
	override public function addNode(node:Node):Void 
	{
		if (Std.is(node, SceneComponent))
		{
			var component:SceneComponent = cast node;
			trace("Adding nodscene");
			super.addNode(node);
		}
		else
		{
			throw "Only scene components";
		}		
	}
}