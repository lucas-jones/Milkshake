package milkshake;

import milkshake.input.IKeyboardInput;

interface IGameCore
{
	public var input(default, null):IKeyboardInput;
	
	function create(game:IGame, width:Float, height:Float, color:Int):Void;	
}