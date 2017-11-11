package milkshake.components.input;

import js.html.KeyboardEvent;
import js.Browser;

class Input
{
	static inline var KEY_UP = "keyup";
	static inline var KEY_DOWN = "keydown";

	var keyMap:Map<Int, String>;

	public function new()
	{
		keyMap = new Map();

		var window = Browser.window;

		window.addEventListener(KEY_UP, handleKeyboardUp);
		window.addEventListener(KEY_DOWN, handleKeyboardDown);
	}

	function handleKeyboardDown(e:KeyboardEvent):Void
	{
		keyMap[e.keyCode] = keyMap.exists(e.keyCode) ? null : KEY_DOWN;
	}

	function handleKeyboardUp(e:KeyboardEvent):Void
	{
		keyMap[e.keyCode] = KEY_UP;
	}

	public function isDown(key:Int):Bool
	{
		return keyMap.exists(key);
	}

	public function isDownOnce(key:Int):Bool
	{
		return keyMap[key] == KEY_DOWN;
	}

	public function isUpOnce(key:Int):Bool
	{
		return keyMap[key] == KEY_UP;
	}

	public function isEitherDown(keys:Array<Int>):Bool
	{
		for(key in keys)
		{
			if(keyMap.exists(key)) return true;
		}

		return false;
	}

	public function isAllDown(keys:Array<Int>):Bool
	{
		for(key in keys)
		{
			if(!keyMap.exists(key)) return false;
		}

		return true;
	}

	public function update(deltaTime:Float):Void
	{
		for (key in keyMap.keys()) {
			if(isDownOnce(key)) this.keyMap[key] = null;
			if(isUpOnce(key)) keyMap.remove(key);
		}
	}
}
