package milkshake.game.camera;

import milkshake.core.Entity;
import milkshake.game.scene.component.SceneComponent;
import milkshake.utils.MathUtils;
import nape.geom.Vec2;

class Camera extends SceneComponent
{
	public static var MIN_ZOON(default, never):Float = 0.001;
	public static var MAX_ZOON(default, never):Float = 2000;
	
	// Need our own Vector2
	public var offset(default, null):Vec2;
	
	public var width(default, null):Int;
	public var height(default, null):Int;
	
	public var rotation(default, null):Float;
	public var zoom(default, set):Float;
	
	public function new(id:String = "Camera") 
	{
		super(id);
		
		zoom = 1;
		rotation = 0;
		
		width = Globals.SCREEN_WIDTH;
		height = Globals.SCREEN_HEIGHT;
	}
	
	public function set_zoom(value:Float):Float 
	{
		return zoom = MathUtils.clamp(value, MIN_ZOON, MAX_ZOON);
	}
	
	override public function update(deltaTime:Float):Void 
	{
		scene.scaleX = scene.scaleY = zoom;
		scene.x = (width / 2) - (x * zoom);
		scene.y = (height / 2) - (y * zoom);
		scene.width = width * (zoom + 1);
		scene.height = height * (zoom + 1);
		scene.rotation = rotation;
		
		super.update(deltaTime);
	}
}