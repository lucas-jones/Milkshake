package milkshake.core;
import milkshake.game.MilkshakeGame;
import nape.phys.Body;
import nape.phys.BodyType;
import nape.shape.Shape;
import nape.space.Space;

/**
 * ...
 * @author Milkshake-Inc
 */
class BodySprite extends Sprite
{
	public var body(default, null): Body;

	public function new(url:String, id:String="undefined-body-sprite") 
	{
		super(url, id);
		
		body = new Body(BodyType.DYNAMIC);
		var shape = new Shape();
		body.shapes.add(shape);
	}
	
	override public function set_x(value:Float):Float 
	{
		body.position.x = value;
		
		return super.set_x(value);
	}
	
	override public function set_y(value:Float):Float 
	{
		body.position.y = value;
		return super.set_y(value);
	}
	
	override public function update(deltaTime:Float):Void 
	{
		super(deltaTime);
		x = body.position.x;
		y = body.position.y;
		rotation = body.rotation;
	}
	
}