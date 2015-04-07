package milkshake.game.scene;

import milkshake.assets.loader.AssetLoader;
import milkshake.core.DisplayObject;
import milkshake.core.Graphics;
import milkshake.game.scene.camera.Camera;
import milkshake.game.scene.camera.CameraManager;
import milkshake.utils.Color;
import milkshake.utils.Globals;
import milkshake.utils.GraphicsHelper;

class Scene extends DisplayObject
{
	public var cameras(default, null):CameraManager;
	public var loader(default, null):AssetLoader;

	public function new(?id:String, content:Array<String>, ?defaultCameras:Array<Camera>, clearColor:Int = Color.RED)
	{
		super(id);

		scene = this;

		loader = new AssetLoader(content);
		cameras = new CameraManager(defaultCameras);
	}
}
