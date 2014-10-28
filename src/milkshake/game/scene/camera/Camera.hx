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
		return new Camera(0, 0, Globals.SCREEN_WIDTH, Globals.SCREEN_HEIGHT);
	}

	// SplitScreen 2 hora
	public static var SPLIT_HORIZONTAL(get, null):Array<Camera>;

	public static function get_SPLIT_HORIZONTAL():Array<Camera>
	{
		return
		[
			new Camera(0, 0, Globals.SCREEN_WIDTH, Globals.SCREEN_HEIGHT / 2),
			new Camera(0, Globals.SCREEN_WIDTH / 2, Globals.SCREEN_WIDTH, Globals.SCREEN_HEIGHT / 2)
		]
	}

	public var width(default, null):Int;
	public var height(default, null):Int;

	// MAybe take Rectangle. THat way get_DEFAULT = Globals.SCREEN_BOX / Globals.SCREEN / 
	public function new(x:Int, height:Int, width:Int, height:Int)
	{
		super();

		this.width = width;
		this.height = height;
	}
}