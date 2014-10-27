package milkshake.core;

import milkshake.core.Node;
import milkshake.game.scene.Scene;
import milkshake.math.Vector2;

class Entity extends Node
{
	public var position(default, null):Vector2;
	
	public function new(?id:String)
	{
		super(id);

		position = Vector2.ZERO;
	}

	public var x(get, set):Float;
	public var y(get, set):Float;

	public function get_x():Float { return position.x; }	
	public function set_x(value:Float):Float { return position.x = value; }
	
	public function get_y():Float { return position.y; }	
	public function set_y(value:Float):Float { return position.y = value; }
}