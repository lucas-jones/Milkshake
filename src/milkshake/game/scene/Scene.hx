package milkshake.game.scene;

import milkshake.core.DisplayObject;
import milkshake.game.scene.camera.CameraManager;

class Scene extends DisplayObject
{
	public var cameras(default, null):CameraManager;

	public function new(?id:String)
	{
		super(id);

		scene = this;

		cameras = new CameraManager();		
	}

	override public function update(delta:Float):Void
	{
		position.x = -cameras.currentCamera.position.x;
		position.y = -cameras.currentCamera.position.y;

		super.update(delta);
	}
}