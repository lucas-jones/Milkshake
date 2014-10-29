package milkshake.game.scene.camera;

import milkshake.core.DisplayObject;
import milkshake.core.Entity;
import milkshake.core.Node;
import milkshake.core.Sprite;
import milkshake.game.scene.camera.Camera;

class CameraManager extends DisplayObject
{
	public var cameras(default, null):Array<Camera>;
	public var activeCameras(get, null):Array<Camera>;

	public function new(?cameras:Array<Camera>)
	{
		super("cameraManager");

		if(cameras == null) cameras = [ CameraPresets.DEFAULT ];

		this.cameras = [];

		for(camera in cameras) addCamera(camera);
	}

	public function addCamera(camera:Camera):Camera
	{
		cameras.push(camera);
		addNode(camera);

		return camera;
	}

	public function removeCamera(camera:Camera):Void
	{
		cameras.remove(camera);
	}

	public function switchCameras(cameraA:Camera, cameraB:Camera):Void
	{
		cameraA.active = false;
		cameraB.active = true;
	}
 
	public function get_activeCameras():Array<Camera>
	{
		return cameras.filter(function(camera:Camera):Bool
		{
			return camera.active;
		});
	}
}