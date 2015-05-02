package milkshake.game.collision;

import differ.shapes.Shape;

interface ICollidable
{
	var shape:Shape;
}

class CollisionEntry
{
	public var enabled:Bool;

	public var collidableA(default, null):ICollidable;
	public var collidableB(default, null):ICollidable;

	public function new(collidableA:ICollidable, collidableB:ICollidable, enabled:Bool = true)
	{
		this.collidableA = collidableA;
		this.collidableB = collidableB;

		this.enabled = enabled;
	}

	public function checkCollision():Void
	{
		//
	}

	public function render(debug:Debug):Void
	{
		collisionService.render(debug, spriteA, spriteB);
	}
}

class CollisionHandler
{
	public var collisionEntrties(default, null):Array<CollisionEntry>;

	public function addCollision()

	public function addCollisionEntry(collisionEntry:CollisionEntry):Void
	{

	}
}