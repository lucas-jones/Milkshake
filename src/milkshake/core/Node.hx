package milkshake.core;

import haxe.exception.Exception;
import hsl.haxe.direct.DirectSignaler.DirectSignaler;
import hsl.haxe.Signaler.Signaler;

class Node
{
	public var id:String;
	public var parent:Node;
	
	public var nodes(default, null):Array<Node>;
	
	public var onNodeAdded(default, null):Signaler<Node>;
	public var onNodeRemoved(default, null):Signaler<Node>;
	
	public function new(?id:String = null)
	{
		this.id = id == null ? Type.typeof(this).getName() : id;
		this.nodes = [];
		
		this.onNodeAdded = new DirectSignaler(this);
		this.onNodeRemoved = new DirectSignaler(this);
	}

	public function update(deltaTime:Float):Void
	{
		for(node in nodes) node.update(deltaTime);
	}

	public function addNode(node:Node):Void
	{
		node.parent = this;
		nodes.push(node);

		onNodeAdded.dispatch(node);
	}
	
	public function removeNode(node:Node):Void
	{
		node.parent = null;
		nodes.remove(node);
		
		onNodeRemoved.dispatch(node);
	}
}