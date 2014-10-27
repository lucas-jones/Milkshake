package milkshake.game.scene.camera;

import milkshake.core.Entity;
import milkshake.core.Node;

class CameraManager extends Node /*Scene Component*/
{
	public var cameras(default, null):Map<String, Camera>;
	public var currentCamera(default, null):Camera;

	public function new(?camera:Camera)
	{
		super("cameraManager");

		cameras = new Map();

		addCamera(camera != null ? camera : new Camera("defaultCamera"));
	}

	public function addCamera(camera:Camera):Void
	{
		if(currentCamera == null) currentCamera = camera;

		cameras.set(camera.id, camera);
	}

	public function removeCamera(camera:Camera):Void
	{
		cameras.remove(camera.id);
	}

	public function setCamera(cameraId:String):Void
	{
		currentCamera = cameras.get(cameraId);
	}
}