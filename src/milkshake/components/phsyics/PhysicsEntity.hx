package milkshake.components.phsyics;

import milkshake.components.phsyics.IPhysicsBody;
import milkshake.core.Entity;
import milkshake.core.Node;
import nape.phys.Body;

class PhysicsEntity extends Entity implements IPhysicsBody
{
	public var body(default, null):Body;

	public function new(body:Body, ?id:String)
	{
		super(id);
		this.body = body;
		body.mass = 1;
		body.inertia = 1;
	}

	override public function addNode(node:Node, ?defaultValues:Dynamic):Void
	{
		if(Std.is(node, IPhysicsBody))
		{
			var bodyObject:IPhysicsBody = cast node;

			bodyObject.body.space = body.space;
		}

		super.addNode(node, defaultValues);
	}
}