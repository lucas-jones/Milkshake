package milkshake.game.camera;
import haxe.exception.Exception;
import haxe.io.Error;
import js.html.Node;
import milkshake.core.Entity;
import milkshake.core.GameObject;
import milkshake.game.scene.component.SceneComponent;
import milkshake.game.scene.Scene;
import nape.geom.Vec2;

/**
 * ...
 * @author Milkshake-Inc
 */
class Camera extends SceneComponent
{	
	var min_zoom(default, never):Float = 0;
	
	public var offset:Vec2;
	public var width:Int;
	public var height:Int;
	public var rotation:Float;
	public var zoom(default, set):Float;
	
	public var target:Entity;

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
		if (value <= min_zoom) throw new Exception("Camera zoom must be greater than 0");
		return zoom = value;
	}
	
	override public function update(deltaTime:Float):Void 
	{
		if (target != null)
		{
			x = target.x;
			y = target.y;
		}
		
		scene.scaleX = scene.scaleY = zoom;
		scene.x = (width / 2) - (x * zoom);
		scene.y = (height/ 2) - (y * zoom);
		scene.width = width * (zoom + 1);
		scene.height = height * (zoom + 1);
		scene.rotation = rotation;
		
		super.update(deltaTime);
	}
}