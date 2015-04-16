package milkshake;

import js.Browser;
import milkshake.game.scene.SceneManager;
import milkshake.utils.RAFHelper;
import pixi.IRenderer;
import pixi.Pixi;
import pixi.Stage;

class Settings
{
	public static function fromMilk(milkFile:String):Settings
	{
		// return cast Json.parse(milkFile)
		return new Settings();
	}

	public var width(default, null):Int;
	public var height(default, null):Int;

	public var color(default, null):Int;

	public function new(width:Int = 200, height:Int = 720, color:Int = 0xFFF000)
	{
		this.width = width;
		this.height = height;

		this.color = color;
	}
}

@:expose
class Milkshake
{
	private static var instance:Milkshake;

	public var onCreated:Void->Void;

	public static function getInstance():Milkshake
	{
		if(instance != null) return instance;

		// Throw. Must call create
		return null;
	}

	public static function boot(?settings:Settings):Milkshake
	{
		return instance = new Milkshake(settings != null ? settings : new Settings());
	}

	public var settings(default, null):Settings; // HAve getters for properties inside json
	public var renderer(default, null):IRenderer;
	public var raf(default, null):RAFHelper;

	public var stage(default, null):Stage;
	
	public var scenes(default, null):SceneManager;

	// Temp
	public var mousePosition(default, null):pixi.Point;

	//public var audio(default, null):AudioEngine;
	//public var input(default, null):InputEngine;
	//public var effects(default, null):EffectsEngine;

	public function new(settings:Settings)
	{
		this.settings = settings;

		renderer = Pixi.autoDetectRenderer(settings.width, settings.height, Browser.document.getElementById('canvas'));
		Browser.document.body.appendChild(renderer.view);

		raf = new RAFHelper(update);
		raf.start();

		stage = new Stage(settings.color, true);
		scenes = new SceneManager();
		
		stage.addChild(scenes.displayObject);
	}

	public function update(delta:Float):Void
	{
		mousePosition = stage.getMousePosition();
		scenes.update(delta);

		renderer.render(stage);
	}
}