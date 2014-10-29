package milkshake.game.scene.camera;

import milkshake.game.scene.camera.Camera;
import milkshake.utils.Globals;

class CameraPresets 
{
	public static var DEFAULT(get, null):Array<Camera>;
	public static var SPLIT_VERTICAL(get, null):Array<Camera>;
	public static var SPLIT_FOUR(get, null):Array<Camera>;

	public static function get_DEFAULT():Array<Camera>
	{
		return [ new Camera(0, 0, Globals.SCREEN_WIDTH, Globals.SCREEN_HEIGHT) ];
	}

	public static function get_SPLIT_VERTICAL():Array<Camera>
	{
		return
		[
			new Camera(0, 0, Std.int(Globals.SCREEN_WIDTH / 2), Globals.SCREEN_HEIGHT),
			new Camera(Std.int(Globals.SCREEN_WIDTH / 2), 0, Std.int(Globals.SCREEN_WIDTH / 2), Globals.SCREEN_HEIGHT)
		];
	}

	public static function get_SPLIT_FOUR():Array<Camera>
	{
		var screenWidth:Int = Std.int(Globals.SCREEN_WIDTH / 2);
		var screenHeight:Int = Std.int(Globals.SCREEN_HEIGHT / 2);

		return
		[
			new Camera(0, 0, screenWidth, screenHeight),
			new Camera(screenWidth, 0, screenWidth, screenHeight),
			new Camera(0, screenHeight, screenWidth, screenHeight),
			new Camera(screenWidth, screenHeight, screenWidth, screenHeight)
		];
	}
}