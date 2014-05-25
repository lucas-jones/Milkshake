package milkshake.core;

import milkshake.core.Node;
import milkshake.game.scene.Scene;
import nape.geom.Vec2;

class Entity extends Node
{
	public var scene(default, null):Scene;
	
	private var position:Vec2;
	
	@:isVar public var x(get, set):Float;
	@:isVar public var y(get, set):Float;
	
	public function new(id:String="undefined-entity") 
	{
		super(id);
		position = new Vec2();
	}
	
	public function setScene(scene:Scene):Void
	{
		this.scene = scene;
		
		for (node in nodes)
		{
			setNodeIfEntity(node);
		}
	}
	
	override public function addNode(node:Node):Void 
	{
		setNodeIfEntity(node);
		super.addNode(node);
	}
	
	function setNodeIfEntity(node:Node) 
	{
		if (Std.is(node, Entity) && scene != null)
		{
			var entity:Entity = cast node;
			entity.setScene(scene);
			scene.onNodeAdded.dispatch(node);
		}
	}
	
	public function update(deltaTime:Float):Void 
	{
		for (node in nodes)
		{
			if (Std.is(node, Entity) && scene != null)
			{
				var entity:Entity = cast node;
				entity.update(deltaTime);
			}
		}
	}
	
	public function get_x():Float { return position.x; }	
	public function set_x(value:Float):Float { return position.x = value; }
	
	public function get_y():Float { return position.y; }	
	public function set_y(value:Float):Float { return position.y = value; }
}