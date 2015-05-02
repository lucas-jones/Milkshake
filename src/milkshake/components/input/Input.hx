package milkshake.components.input;

import js.html.KeyboardEvent;
import js.Browser;

class Input 
{
	static inline var KEY_UP_EVENT = "keyup";
	static inline var KEY_DOWN_EVENT = "keydown";
	
	var keyMap:Map<Int, Bool>;

	public function new()
	{
		keyMap = new Map();
	
		var window = Browser.window;

		window.addEventListener(KEY_UP_EVENT, handleKeyboardEvent.bind(_, false));
		window.addEventListener(KEY_DOWN_EVENT, handleKeyboardEvent.bind(_, true));
	}

	function handleKeyboardEvent(e:KeyboardEvent, isKeyDown:Bool):Void
	{
		keyMap[e.keyCode] = isKeyDown;
	}

	public function isDown(key:Int):Bool
	{
		return keyMap[key];
	}

	public function isEitherDown(keys:Array<Int>):Bool
	{
		for(key in keys)
		{
			if(keyMap[key]) return true;
		}
		
		return false;
	}

	public function isAllDown(keys:Array<Int>):Bool
	{
		for(key in keys)
		{
			if(!keyMap[key]) return false;
		}
		
		return true;
	}
}
