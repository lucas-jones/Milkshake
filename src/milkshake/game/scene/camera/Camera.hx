package milkshake.game.scene.camera;

import milkshake.core.DisplayObject;
import milkshake.core.Entity;
import milkshake.Milkshake;
import milkshake.utils.Globals;

class Camera extends DisplayObject
{
	public static var DEFAULT(get, null):Camera;

	public static function get_DEFAULT():Camera
	{
		return new Camera(Globals.SCREEN_WIDTH, Globals.SCREEN_HEIGHT);
	}

	public var width(default, null):Int;
	public var height(default, null):Int;

	public function new(width:Int, height:Int)
	{
		super();

		this.width = width;
		this.height = height;
	}
}