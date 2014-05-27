package milkshake.core;
import haxe.exception.Exception;
import hsl.haxe.direct.DirectSignaler.DirectSignaler;
import hsl.haxe.Signaler.Signaler;

class Node
{
	public var id(default, default):String;
	public var parent(default, null):Node;
	public var nodes(default, null):Array<Node>;
	
	public var onNodeAdded(default, null):Signaler<Node>;
	public var onNodeRemoved(default, null):Signaler<Node>;
	
	public function new(?id:String = null)
	{
		this.id = id == null ? Type.typeof(this).getName() : id;
		this.nodes = [];
		
		this.onNodeAdded = new DirectSignaler(this);
	}
	
	public function setParent(parent:Node):Void
	{
		this.parent = parent;
	}
	
	public function addNode(node:Node):Void
	{
		node.setParent(this);
		
		nodes.push(node);
	}
	
	public function removeNode(node:Node):Void
	{
		if (node == null) return;
		nodes.remove(node);
	}
	
	public function getNodeById<T>(id:String):T
	{
		var t:T;
		var n = nodes.filter(function(node:Node):Bool
		{
			return node.id == id;
		})[0];
		
		if (n == null)
		{
			trace("Child node not found with id '" + id + "' in node '" + this.id + "'!");
			return null;
		}
		
		if (Std.is(n, t))
		{
			t = cast n;
			return t;
		}
		
		trace("Found node with id '" + id + "'but could not cast to type '" + t + "'!");
		return null;
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