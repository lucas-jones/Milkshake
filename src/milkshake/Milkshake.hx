package milkshake;

import pixi.Stage;

class Milkshake
{
	private var instance:Milkshake;

	public function getInstance():Milkshake
	{
		return instance != null ? instance : instance = new Milkshake();
	}

	public var stage(default, null):Stage;
	
	public var scenes(default, null):SceneEngine;
	//public var audio(default, null):AudioEngine;
	//public var input(default, null):InputEngine;
	//public var effects(default, null):EffectsEngine;

	public static function new():Void
	{
		
	}

	public function new()
	{
		sceneManager = new SceneManager();
	}
	
	// @Width & @Height from .mlk
	public function create(color:Int):Void
	{
		stage = new Stage(color);
	}

	public function update(delta:Float):Void
	{

	}
}