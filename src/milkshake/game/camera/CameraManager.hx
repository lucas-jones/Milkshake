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
	public var DEFAULT_CAMERA_NAME(default, never):String = "Default";
	
	public var cameras:Map<String, Camera>;
	
	public var currentCamera(get, null):Camera;
	
	public var currentCameraKey(default, null):String;
	
	public function new() 
	{
		cameras = new Map<String, Camera>();
		
		addCamera(DEFAULT_CAMERA_NAME, new Camera());
        setCamera(DEFAULT_CAMERA_NAME);
		
		super("camera_manager");
	}
	
	public function addCamera(name:String, camera:Camera)
	{
		cameras.set(name, camera);
	}
	
	public function get_currentCamera():Camera
	{
		return cameras.get(currentCameraKey);
	}

	public function setCamera(name:String)
	{
		if (!cameras.exists(name)) throw new Exception("Camera not found!");

		currentCameraKey = name;
	}

}