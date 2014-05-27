package milkshake.game.ui.view;

import hsl.haxe.DirectSignaler;
import hsl.haxe.Signaler;
import js.Lib;
import milkshake.core.Node;

/**
 * ...
 * @author Milkshake-Inc
 */
class AbstractViewController extends Node
{
	public var isOpen(default, set):Bool = false;
	
	public var onOpened(default, null):Signaler<Void>;
	
	public var onClosed(default, null):Signaler<Void>;
	
	public var game(default, null):MilkshakeGame;
	
	public function new(id:String)
	{
		this.id = id;
		
		game = MilkshakeGame.instance;
		
		onOpened = new DirectSignaler<Void>(this);
		onClosed = new DirectSignaler<Void>(this);
		
		game.viewManager.addView(id, this);
		trace(id + " view created!");
		super(id);
	}
	
	public function open(?data:Dynamic):Void
	{
		isOpen = true;
	}
	
	public function close():Void
	{
		isOpen = false;
	}
	
	public function update(deltaTime:Float):Void 
	{
		
	}
	
	function set_isOpen(value:Bool):Bool
	{
		isOpen = value;
		isOpen ? onOpened.dispatch() : onClosed.dispatch();
		return isOpen;
	}
}