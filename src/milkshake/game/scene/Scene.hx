package milkshake.game.scene;

import js.JQuery;
import js.JQuery.JqEvent;
import milkshake.core.GameObject;
import milkshake.game.camera.CameraManager;
import milkshake.game.scene.component.SceneComponentManager;
import milkshake.IGame;
import pixi.Graphics;

class Scene extends GameObject
{
	public var core(default, null):IGameCore;
	public var componentManager(default, null):SceneComponentManager;
	public var cameraManager(default, null):CameraManager;
	
	public var width(get, set):Float;
	public var height(get, set):Float;
	
	var maskWidth:Float;
	var maskHeight:Float;
	
	public function new(core:IGameCore, id:String="undefined-scene") 
	{
		super(id);
		
		this.core = core;
		
		setScene(this);
		
		addNode(componentManager = new SceneComponentManager());

		componentManager.addNode(cameraManager = new CameraManager(this));
	}
	
	override public function setup():Void 
	{
		super.setup();
		maskWidth = Globals.SCREEN_WIDTH;
		maskHeight = Globals.SCREEN_HEIGHT;
		setMask();
	}
	
	function setMask():Void
	{
		var mask = new Graphics();
		mask.beginFill(0);
		mask.drawRect(x , y, maskWidth, maskHeight);
		displayObject.mask = mask;
	}
	
	public function get_width():Float { return maskWidth; }
	public function set_width(value:Float):Float 
	{ 
		maskWidth = value;
		setMask();
		return maskWidth;
	}
	
	public function get_height():Float { return maskHeight; }
	public function set_height(value:Float):Float
	{ 
		maskHeight = value;
		setMask();
		return maskHeight; 
	}
	
	override public function set_x(value:Float):Float 
	{
		super.set_x(value);
		setMask();
		return x;
	}
	
	override public function set_y(value:Float):Float 
	{
		super.set_y(value);
		setMask();
		return y;
	}
}