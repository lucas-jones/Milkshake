package milkshake.components.phsyics;

import milkshake.components.phsyics.IPhysicsBody;
import milkshake.core.Entity;
import milkshake.core.Node;
import nape.phys.Body;

class PhysicsEntity extends Entity implements IPhysicsBody
{
	public var body(default, null):Body;

	override public function addNode(node:Node):Void
	{
		if(Std.is(node, IPhysicsBody))
		{
			var bodyObject:IPhysicsBody = cast node;

			bodyObject.body.space = body.space;
		}

		super.addNode(node);
	}
}