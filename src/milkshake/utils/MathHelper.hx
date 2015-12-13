package milkshake.utils;

import milkshake.core.Graphics;

class MathHelper 
{
	public static function clamp(value:Float, min:Float, max:Float):Float
	{
		var min = Math.min(min, max);
		var max = Math.max(min, max);
		
		return value < min ? min : value > max ? max : value;
	}

	public static function toRadians(angle:Float):Float
	{
		return angle * Math.PI / 180;
	}
}