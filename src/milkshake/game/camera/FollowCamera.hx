package milkshake.game.camera;

import milkshake.core.Entity;

class FollowCamera extends Camera
{
	public var target(default, null):Entity;
	
	public function new(?target:Entity)
	{
		super();
		
		this.target = target;
	}
	
	override public function update(deltaTime:Float):Void 
	{
		if (target != null)
		{
			x = target.x;
			y = target.y;
		}
		
		super.update(deltaTime);
	}
}