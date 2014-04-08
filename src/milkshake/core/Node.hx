package milkshake.core;
import hsl.haxe.direct.DirectSignaler.DirectSignaler;
import hsl.haxe.Signaler.Signaler;

class Node
{
	public var id(default, default):String;
	public var parent(default, null):Node;
	public var nodes(default, null):Array<Node>;
	
	public var onNodeAdded(default, null):Signaler<Node>;
	public var onNodeRemoved(default, null):Signaler<Node>;
	
	public function new(id:String = "undefined-node")
	{
		this.id = id;
		this.nodes = [];
		
		this.onNodeAdded = new DirectSignaler(this);
	}
	
	public function setParent(parent:Node):Void
	{
		this.parent = parent;
	}
	
	public function addNode(node:Node):Void
	{
		nodes.push(node);
	}
	
	public function removeNode(node:Node):Void
	{
		nodes.remove(node);
	}
	
	public function getNodeById(id:String):Node
	{
		return nodes.filter(function(node:Node):Bool
		{
			return node.id == id;
		})[0];
	}
	
	public function dispatchOnNodeAdded(node:Node):Void
	{
		if (parent != null)
		{
			parent.dispatchOnNodeAdded(node);
		}
		
		onNodeAdded.dispatch(node);
	}
}