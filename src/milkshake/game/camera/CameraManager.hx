package milkshake.game.camera;
import haxe.exception.Exception;
import milkshake.game.scene.component.SceneComponent;
import milkshake.game.scene.Scene;

/**
 * ...
 * @author Milkshake-Inc
 */
class CameraManager extends SceneComponent
{
	public var DEFAULT_CAMERA_NAME(default, never):String = "default_camera";
	
	public var cameras:Map<String, Camera>;
	
	public var currentCamera(get, null):Camera;
	
	public var currentCameraKey(default, null):String;
	
	public function new(scene:Scene) 
	{
		super("camera_manager");
		
		cameras = new Map<String, Camera>();
		
		addCamera(DEFAULT_CAMERA_NAME, new Camera());
	}
	
	public function addCamera(name:String, camera:Camera)
	{
		cameras.set(name, camera);
		if (currentCamera == null) changeCamera(name);
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