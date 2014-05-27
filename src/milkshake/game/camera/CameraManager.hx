package milkshake.game.camera;

import haxe.exception.Exception;
import milkshake.game.scene.component.SceneComponent;
import milkshake.game.scene.Scene;

class CameraManager extends SceneComponent
{
	public var DEFAULT_CAMERA(default, never):String = "default_camera";
	
	public var cameras(default, null):Map<String, Camera>;
	
	public var currentCamera(get, null):Camera;
	public var currentCameraKey(default, null):String;
	
	public function new(scene:Scene) 
	{
		super();
		
		cameras = new Map<String, Camera>();
		
		addCamera(DEFAULT_CAMERA, new Camera());
	}
	
	public function addCamera(name:String, camera:Camera): Camera
	{
		cameras.set(name, camera);
		
		if (currentCamera == null) changeCamera(name);
		
		return camera;
	}
	
	public function get_currentCamera():Camera
	{
		return cameras.get(currentCameraKey);
	}

	public function changeCamera(name:String)
	{
		if (!cameras.exists(name)) throw new Exception("Camera not found!");
		
		removeNode(currentCamera);
		currentCameraKey = name;
		addNode(currentCamera);
	}

}