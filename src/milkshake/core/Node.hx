package milkshake.core;
import haxe.exception.Exception;
import hsl.haxe.direct.DirectSignaler.DirectSignaler;
import hsl.haxe.Signaler.Signaler;

class Node
{
	public var id(default, default):String;
	public var parent(default, set):Node;
	public var nodes(default, null):Array<Node>;
	
	public var onNodeAdded(default, null):Signaler<Node>;
	public var onNodeRemoved(default, null):Signaler<Node>;
	public var onAddedToNode(default, null):Signaler<Node>;
	public var onRemovedFromNode(default, null):Signaler<Node>;
	
	public function new(?id:String = null)
	{
		this.id = id == null ? Type.typeof(this).getName() : id;
		this.nodes = [];
		
		this.onNodeAdded = new DirectSignaler(this);
		this.onNodeRemoved = new DirectSignaler(this);
		this.onAddedToNode = new DirectSignaler(this);
		this.onRemovedFromNode = new DirectSignaler(this);
	}
	
	public function set_parent(value:Node):Node
	{
		this.parent = value;
		if (value != null) onAddedToNode.dispatch(value);
		return value;
	}
	
	public function addNode(node:Node):Void
	{
		node.parent = this;
		nodes.push(node);
		
		if (parent != null)
		{
			parent.onNodeAdded.dispatch(node);
		}
		onNodeAdded.dispatch(node);
	}
	
	public function removeNode(node:Node):Void
	{
		if (node == null) return;
		node.parent = null;
		nodes.remove(node);
		
		onNodeRemoved.dispatch(node);
		node.onRemovedFromNode.dispatch(this);
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
}