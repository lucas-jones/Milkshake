package milkshake.game.collision;

import differ.shapes.Shape;
import milkshake.core.DisplayObject;
import milkshake.game.collision.ICollidable;

class CollisionDisplayObject extends DisplayObject implements ICollidable
{
	public var shape(default, null):Shape;

	public function new(shape:Shape)
	{
		super();
		
		this.shape = shape;
	}

	override public function update(delta:Float):Void
	{
		shape.x = x;
		shape.y = y;

		super.update(delta);
	}
}