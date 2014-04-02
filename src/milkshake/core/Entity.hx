package milkshake.core;

class Entity extends Node
{
	@:isVar public var x(get, set):Float;
	@:isVar public var y(get, set):Float;
	
	public function new(id:String="undefined-entity") 
	{
		super(id);
	}
	
	public function update(deltaTime:Float):Void { }
	
	public function get_x():Float { return x; }	
	public function set_x(value:Float):Float { return x = value; }
	
	public function get_y():Float { return y; }	
	public function set_y(value:Float):Float { return y = value; }
}