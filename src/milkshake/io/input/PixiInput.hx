package milkshake.io.input;

import js.Browser;
import js.html.Event;
import js.html.KeyboardEvent;
import js.Lib;

using Lambda;

class PixiInput implements IKeyboardInput
{
	public var keyHandlersPress:Map < Int, Void -> Void > ;
	public var keyHandlersDown:Map < Int, Void -> Void > ;
	public var keyHandlersUp:Map < Int, Void -> Void > ;
	
	public var keyDownMap:Array<Int>;
	
	public function new() 
	{
		keyHandlersPress = new Map < Int, Void -> Void > ();
		keyHandlersDown = new Map < Int, Void -> Void > ();
		keyHandlersUp = new Map<Int, Void -> Void>();
		
		keyDownMap = [];
		
		Browser.document.onkeydown = onKeyPress;
		Browser.document.onkeyup = onKeyUp;
	}
	
	private function onKeyPress(e:KeyboardEvent)
	{
		if (keyDownMap.indexOf(e.keyCode) == -1)
		{
			keyDownMap.push(e.keyCode);
			if (keyHandlersPress.exists(e.keyCode))
			{
				keyHandlersPress.get(e.keyCode)();
			}
		}
	}
	
	private function onKeyUp(e:KeyboardEvent)
	{
		
		keyDownMap.remove(e.keyCode);
		
		if (keyHandlersUp.exists(e.keyCode)) keyHandlersUp.get(e.keyCode)();
	}
	
	// Press
	public function addKeyPressHandler(keyCode:Int, callback:Void -> Void)
	{
		keyHandlersPress.set(keyCode, callback);
	}
	
	public function removeKeyPressHandler(keyCode:Int)
	{
		keyHandlersPress.remove(keyCode);
	}
	
	// Down
	public function addKeyDownHandler(keyCode:Int, callback:Void -> Void)
	{
		keyHandlersDown.set(keyCode, callback);
	}
	
	public function removeKeyDownHandler(keyCode:Int)
	{
		keyHandlersDown.remove(keyCode);
	}
	
	// Up
	public function addKeyUpHandler(keyCode:Int, callback:Void -> Void)
	{
		keyHandlersUp.set(keyCode, callback);
	}
	
	public function removeKeyUpHandler(keyCode:Int)
	{
		keyHandlersUp.remove(keyCode);
	}
	
	public function update()
	{
		for (key in keyDownMap)
		{
			if (keyHandlersDown.exists(key))
			{
				keyHandlersDown.get(key)();
			}
		}
	}
}