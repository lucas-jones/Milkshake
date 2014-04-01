package milkshake.core;

using Lambda;

class Node
{
	public var id(default, default):String;
	public var nodes(default, null):Array<Node>;
	
	public function new(id:String = "undefined-node")
	{
		this.id = id;
		this.nodes = [];
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
}