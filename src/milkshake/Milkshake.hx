package milkshake;

import milkshake.game.scene.SceneManager;
import pixi.Stage;

class Settings
{
	public static function fromMilk(milkFile:String):Settings
	{
		// return cast Json.parse(milkFile)
		return null;
	}

	public var width(default, null):Int;
	public var height(default, null):Int;

	public var color(default, null):Int;

	public function new(width:Int = 1280, height:Int = 720, color:Int = 0xFF0000)
	{
		this.width = width;
		this.height = height;

		this.color = color;
	}
}

class Milkshake
{
	private static var instance:Milkshake;

	public static function getInstance():Milkshake
	{
		if(instance != null) return instance;

		// Throw. Must call create
		return null;
	}

	public static function boot(settings:Settings):Milkshake
	{
		return instance = new Milkshake(settings);
	}

	public var settings(default, null):Settings; // HAve getters for properties inside json
	public var stage(default, null):Stage;
	
	public var scenes(default, null):SceneManager;

	//public var audio(default, null):AudioEngine;
	//public var input(default, null):InputEngine;
	//public var effects(default, null):EffectsEngine;

	public function new(settings:Settings)
	{
		this.settings = settings;

		stage = new Stage(settings.color);
		scenes = new SceneManager();
		
		stage.addChild(scenes.displayObject);
	}

	public function update(delta:Float):Void
	{
		scenes.update(delta);
	}
}