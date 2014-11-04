package milkshake.game.scene;

import milkshake.core.DisplayObject;
import milkshake.game.scene.camera.Camera;
import milkshake.game.scene.camera.CameraManager;
import milkshake.utils.Color;
import milkshake.utils.Globals;
import milkshake.utils.GraphicsHelper;

class Scene extends DisplayObject
{
	public var cameras(default, null):CameraManager;

	public function new(?id:String, ?defaultCameras:Array<Camera>, clearColor:Int = Color.RED)
	{
		super(id);

		scene = this;
		
		cameras = new CameraManager(defaultCameras);

		addNode(GraphicsHelper.generateRectangle(Globals.SCREEN_WIDTH, Globals.SCREEN_HEIGHT, clearColor));
	}
}
