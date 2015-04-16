package milkshake.utils;

import milkshake.math.Vector2;

class Globals
{
	public static var SCREEN_WIDTH:Int = 1024;
	public static var SCREEN_HEIGHT:Int = 768;

	public static var SCREEN_SIZE(get, never):Vector2;
	public static function get_SCREEN_SIZE():Vector2
	{
		return new Vector2(SCREEN_WIDTH, SCREEN_HEIGHT);
	}

	public static var SCREEN_CENTER(get, never):Vector2;

	public static function get_SCREEN_CENTER():Vector2
	{
		return new Vector2(SCREEN_WIDTH / 2, SCREEN_HEIGHT / 2);
	}
}