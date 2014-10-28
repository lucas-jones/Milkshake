package milkshake.game.scene.camera;

import milkshake.core.Entity;
import milkshake.core.Node;


// Array<CameraSettings>  CameraSettings.DEAULT, CameraSettings.
// Array<Camera>  Camera.DEAULT, CameraSettings.
// [ new Camera() ]

class CameraManager extends Node /*Scene Component*/
{
	public var cameras(default, null):Array<Camera>;
	
	//public var activeCameras(get, null):Array<Camera>;

	public function new(?cameras:Array<Camera>)
	{
		super("cameraManager");

		cameras = (cameras != null) ? cameras : [ Camera.DEFAULT ];
	}

	public function addCamera(camera:Camera):Void
	{
		cameras.push(camera);
	}

	public function removeCamera(camera:Camera):Void
	{
		cameras.remove(camera);
	}

	public function switchCameras(cameraA:String, cameraB):Void
	{
		//cameraA.active = false;
		//cameraB.active = true;
	}
 
	// public function tweenCameras() // TWeen together?
}