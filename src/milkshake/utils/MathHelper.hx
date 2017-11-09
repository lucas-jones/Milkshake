package milkshake.utils;

class MathHelper
{
	public static function clamp(value:Float, min:Float, max:Float):Float
	{

		var min = Math.min(min, max);
		var max = Math.max(min, max);

		return value < min ? min : value > max ? max : value;
	}

	public static function hermite(valueA:Float, tangentA:Float, valueB:Float, tangentB, amount:Float):Float
	{
		var amountCubed = amount * amount * amount;
		var amountSquared = amount * amount;

		if(amount == 0) return valueA;
		if(amount == 1) return valueB;

		return (2 * valueA - 2 * valueB + tangentB + tangentA) * amountCubed +
			   (3 * valueB - 3 * valueA - 2 * tangentA - tangentB) * amountSquared +
			   tangentA * amount + valueA;
	}

	public static function map(fromMin:Float, fromMax:Float, toMin:Float, toMax:Float, value:Float):Float
	{
		return toMin + (value - fromMin) * (toMax - toMin) / (fromMax - fromMin);
	}

	public static function smoothStep(valueA:Float, valueB:Float, amount:Float):Float
	{
		return hermite(valueA, 0, valueB, 0, clamp(amount, 0, 1));
	}

	public static function distance(valueA:Float, valueB:Float):Float
	{
		return Math.abs(valueA - valueB);
	}

	public static function lerp(start:Float, end:Float, percent:Float):Float
	{
		return (start + percent * (end - start));
	}

	public static function toDegrees(radians:Float):Float
	{
		return radians * 180 / Math.PI;
	}

	public static function toRadians(angle:Float):Float
	{
		return angle * Math.PI / 180;
	}
}