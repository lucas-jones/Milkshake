package milkshake.game.scene;

import milkshake.core.DisplayObject;
import milkshake.game.scene.camera.Camera;
import milkshake.game.scene.camera.CameraManager;

// Having a NetGameObject
// Which can be serialized easy. Imagine entering a multiplayer mid-game.
// Server -> Client EntireState, Then updates from then on?
//
// You would declate how a GameObject is serialized
//
//  Entity
//  [
//		new NetVar("position", UpdateRate.HIGH),
//		// or
//		new NetVar("x", UpdateRate.HIGH),
//		new NetVar("y", UpdateRate.HIGH),
//  ]
//
// 	GameObject:
//	[
//		new NetVar("width", UpdateRate.HIGH),
//		new NetVar("height", UpdateRate.HIGH),
//		new NetVar("scale", UpdateRate.LOW), // SmoothTween
//	]
//
// 	Will store last sent state, and look through all NetVar for changes
//  
//
//
// Network with different protocols
//
// new JsonPacketHandler()
// new BinaryPacketHandler()
// new BsonPacketHandler()
//
// AddHandler auto cast obv
//
//
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