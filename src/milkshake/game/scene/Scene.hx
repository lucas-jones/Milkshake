package milkshake.game.scene;

import milkshake.core.DisplayObject;
import milkshake.game.scene.camera.Camera;
import milkshake.game.scene.camera.CameraManager;


// The cameras are a diplayObject of the stage. the scene are not.
// stage.AddChild(SceneManager) SceneManager shouldn't add scenes to displayTree, should add cameras.
// RenderTexture http://www.goodboydigital.com/pixijs/docs/classes/RenderTexture.html
class Scene extends DisplayObject
{
	public var cameras(default, null):CameraManager;

	public function new(?id:String, ?defaultCameras:Array<Camera>)
	{
		super(id);

		scene = this;

		cameras = new CameraManager(defaultCameras);
	}

	override public function update(delta:Float):Void
	{
		//position.x = -cameras.currentCamera.position.x;
		//position.y = -cameras.currentCamera.position.y;

		super.update(delta);
	}
}