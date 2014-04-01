package milkshake.core;

class Entity extends Node
{
	public var x(default, default):Float;
	public var y(default, default):Float;
	
	public function new(id:String="undefined-entity") 
	{
		super(id);
	}
	
	public function update(deltaTime:Float):Void
	{
		
	}
}