package milkshake.game.scene;

import js.JQuery;
import js.JQuery.JqEvent;
import milkshake.core.GameObject;
import milkshake.game.camera.CameraManager;
import milkshake.game.scene.component.SceneComponentManager;
import milkshake.IGame;
import nape.geom.Vec2;
import pixi.Graphics;

class Scene extends GameObject
{
	public var core(default, null):IGameCore;
	public var componentManager(default, null):SceneComponentManager;
	public var cameraManager(default, null):CameraManager;
	
	public var width(get, set):Float;
	public var height(get, set):Float;
	
	public var offset(get, set):Vec2;
	
	var maskOffset:Vec2;
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
		maskOffset = new Vec2();
		maskWidth = Globals.SCREEN_WIDTH;
		maskHeight = Globals.SCREEN_HEIGHT;
		setMask();
	}
	
	function setMask():Void
	{
		var mask = new Graphics();
		mask.beginFill(0);
		mask.drawRect(offset.x, offset.y, maskWidth, maskHeight);
		displayObject.mask = mask;
	}
	
	public function get_offset():Vec2 { return maskOffset; }
	public function set_offset(value:Vec2):Vec2
	{ 
		return maskOffset = value;
	}
	
	public function get_width():Float { return maskWidth; }
	public function set_width(value:Float):Float 
	{ 
		return maskWidth = value;
	}
	
	public function get_height():Float { return maskHeight; }
	public function set_height(value:Float):Float
	{ 
		return maskHeight = value;
	}
	
	override public function update(deltaTime:Float):Void 
	{
		setMask();
		super.update(deltaTime);
	}
	
/*	override public function set_x(value:Float):Float 
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
	}*/
}