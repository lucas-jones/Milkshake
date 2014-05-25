package milkshake.game.camera;
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
	public var offset:Vec2;
	public var width:Int;
	public var height:Int;
	public var rotation:Float;
	public var zoom:Float;
	
	public var target:Entity;

	public function new(id:String = "Camera") 
	{
		super(id);
		
		zoom = 1;
		rotation = 0;
		
		width = Globals.SCREEN_WIDTH;
		height = Globals.SCREEN_HEIGHT;
	}
	
	override public function update(deltaTime:Float):Void 
	{
		if (target != null)
		{
			x = target.x;
			y = target.y;
		}
		
		scene.scaleX = scene.scaleY = zoom;
		scene.x = x - (width / 2) * zoom;
		scene.y = y - (height / 2) * zoom;
		scene.width = width * zoom;
		scene.height = height * zoom;
		scene.rotation = rotation;
		
		super.update(deltaTime);
	}
}