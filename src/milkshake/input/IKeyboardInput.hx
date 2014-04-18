package milkshake.input;

interface IKeyboardInput 
{
	public function addKeyPressHandler(keyCode:Int, callback:Void -> Void):Void;
	public function removeKeyPressHandler(keyCode:Int):Void;
	
	public function addKeyDownHandler(keyCode:Int, callback:Void -> Void):Void;
	public function removeKeyDownHandler(keyCode:Int):Void;
	
	public function addKeyUpHandler(keyCode:Int, callback:Void -> Void):Void;
	public function removeKeyUpHandler(keyCode:Int):Void;
	
	public function update():Void;
}