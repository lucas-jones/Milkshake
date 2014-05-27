package milkshake.utils;

class MathUtils
{
	public static function clamp(value:Float, min:Float, max:Float):Float 
	{
		return value > max ? max : value < min ? min : value;
	}

	public static function roundToNearest(value:Float, multiple:Float):Float
	{
		return multiple * Math.round(value / multiple);
	}
	
	public static function distanceSqr(ax:Float, ay:Float, bx:Float, by:Float):Float
	{
		var dx = bx - ax;
		var dy = by - ay;
		
		return dx * dx + dy * dy;
	}
}