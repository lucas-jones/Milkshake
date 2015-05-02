package milkshake.math;

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

	public var x:Float;
	public var y:Float;

	public function new(x:Float = 0, y:Float = 0)
	{
		this.x = x;
		this.y = y;
	}

	@:op(A * B)
	public function multi(value:Vector2):Vector2
	{
		return new Vector2(x * value.x, y * value.y);
	}

	@:op(A * B)
	public function multiSingle(value:Float):Vector2
	{
		return new Vector2(x * value, y * value);
	}

	@:op(A + B)
	public function add(value:Vector2):Vector2
	{
		return new Vector2(x + value.x, y + value.y);
	}
}