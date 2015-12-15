package milkshake.math;

import milkshake.math.Vector2;

class Vector2
{
	public static var ZERO(get, never):Vector2;
	public static var ONE(get, never):Vector2;
	public static var HALF(get, never):Vector2;
	public static var DOWN(get, never):Vector2;
	public static var UP(get, never):Vector2;
	public static var LEFT(get, never):Vector2;
	public static var RIGHT(get, never):Vector2;

	public static function get_ZERO():Vector2
	{
		return new Vector2(0, 0);
	}

	public static function get_HALF():Vector2
	{
		return new Vector2(0.5, 0.5);
	}

	public static function get_ONE():Vector2
	{
		return new Vector2(1, 1);
	}

	public static function get_UP():Vector2
	{
		return new Vector2(0, -1);
	}

	public static function get_DOWN():Vector2
	{
		return new Vector2(0, 1);
	}

	public static function get_LEFT():Vector2
	{
		return new Vector2(-1, 0);
	}

	public static function get_RIGHT():Vector2
	{
		return new Vector2(1, 0);
	}

	public static function EQUAL(value:Float):Vector2
	{
		return new Vector2(value, value);
	}

	public static function SUM(vectors:Array<Vector2>):Vector2
	{
		var o = Vector2.ZERO;
		for (v in vectors) o.add(v);
		return o;
	}

	public var x:Float;
	public var y:Float;

	public function new(x:Float = 0, y:Float = 0)
	{
		this.x = x;
		this.y = y;
	}

	@:op(A * B)
	public function add(value:Vector2):Vector2
	{
		x += value.x;
		y += value.y;

		return this;
	}

	public function sub(value:Vector2):Vector2
	{
		x -= value.x;
		y -= value.y;

		return this;
	}

	public function multi(value:Vector2):Vector2
	{
		x *= value.x;
		y *= value.y;

		return this;
	}

	public function dev(value:Vector2):Vector2
	{
		x /= value.x;
		y /= value.y;

		return this;
	}

	public function devf(value:Float):Vector2
	{
		x /= value;
		y /= value;

		return this;
	}

	@:op(A * B)
	public function multiSingle(value:Float):Vector2
	{
		return new Vector2(x * value, y * value);
	}

	public function toString():String
	{
		return 'x:${x} y:${y}';
	}

	@:op(A * B)
	@:commutative
	public static inline function multiplication(a:Vector2, s:Float)
	{
		return new Vector2(a.x * s, a.y * s);
	}

	@:op(A / B)
	public static inline function devision(a:Vector2, s:Float)
	{
		return new Vector2(a.x / s, a.y / s);
	}

	@:op(A + B)
	public static inline function addition(a:Vector2, b:Vector2):Vector2
	{
		return new Vector2(a.x + b.x, a.y + b.y);
	}

	@:op(A - B)
	public static inline function subtraction(a:Vector2, b:Vector2)
	{
		return new Vector2(a.x - b.x, a.y - b.y);
	}

	public function clone():Vector2
	{
		return new Vector2(x, y);
	}

	public static function distance(v1:Vector2, v2:Vector2):Float
	{
		return Math.sqrt(Math.pow(v1.x - v2.x, 2) + Math.pow(v1.y - v2.y, 2));
	}

	public static function angle(v1:Vector2, v2:Vector2):Float
	{
		return Math.atan2(v2.y - v1.y, v2.x - v1.x);
	}
}