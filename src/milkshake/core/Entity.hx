package milkshake.core;

import milkshake.core.Node;
import milkshake.game.scene.Scene;
import milkshake.math.Vector2;

class Entity extends Node
{
	@:isVar public var position(get, set):Vector2;
	@:isVar public var rotation(get, set):Float;

	function get_position():Vector2
	{
		return position;
	}

	function set_position(value:Vector2):Vector2
	{
		return position = value;
	}

	function get_rotation():Float
	{
		return rotation;
	}

	function set_rotation(value:Float):Float
	{
		return rotation = value;
	}

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