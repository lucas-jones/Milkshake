package milkshake.game.scene;

import hsl.haxe.Signal;
import milkshake.assets.loader.AssetLoader;
import milkshake.core.DisplayObject;
import milkshake.game.scene.camera.Camera;
import milkshake.game.scene.camera.CameraManager;
import milkshake.utils.Color;
import milkshake.utils.Globals;
import milkshake.utils.GraphicsHelper;

class Scene extends DisplayObject
{
	public var cameras(default, null):CameraManager;
	public var loader(default, null):AssetLoader;

	var clearColor:Int;

	public function new(?id:String, content:Array<String>, ?defaultCameras:Array<Camera>, clearColor:Int = Color.RED)
	{
		super(id);

		this.clearColor = clearColor;

		scene = this;

		loader = new AssetLoader(content);
		cameras = new CameraManager(defaultCameras);
	}

	override public function create():Void
	{
		addNode(GraphicsHelper.generateRectangle(Globals.SCREEN_WIDTH, Globals.SCREEN_HEIGHT, clearColor));	
	}
}
