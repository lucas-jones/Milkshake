package milkshake.core.utils;

/**
 * ...
 * @author Milkshake-Inc
 */
class Vector2
{
	public var x:Float;
	public var y:Float;
	
	public function new(x, y)
	{
		this.x = x;
		this.y = y;
	}
	
	public function negative()
	{
		return new Vector2( -x, -y);
	}
	
	public function perp()
	{
		return new Vector2(y, -x);
	}
	
	public function norm()
	{
		return Math.sqrt(x * x + y * y);
	}
	
	public function normal()
	{
		return div(this, norm());
	}
	
	public function angle()
	{
		return Math.atan2(y, x);
	}
	
	static public function distanceSquared(a:Vector2, b:Vector2):Float
	{
		var dx = b.x - a.x;
		var dy = b.y - a.y;
		return dx * dx + dy * dy;
	}
	
	static public function distance(a:Vector2, b:Vector2):Float
	{
		return Math.sqrt(distanceSquared(a, b));
	}
	
	static public function add(a:Vector2, b:Vector2)
	{
		return new Vector2(a.x + b.x, a.y + b.y);
	}
	
	static public function sub(a:Vector2, b:Vector2)
	{
		return new Vector2(a.x - b.x, a.y - b.y);
	}
	
	static public function mul(a:Vector2, f:Float)
	{
		return new Vector2(a.x * f, a.y * f);
	}
	
	static public function div(a:Vector2, f:Float)
	{
		return new Vector2(a.x / f, a.y / f);
	}
	
	static public function dot(a:Vector2, b:Vector2)
	{
		return a.x * b.x + a.y * b.y;
	}
	
	static public function cross(a:Vector2, b:Vector2)
	{
		return a.x * b.y - a.y * b.x;
	}
	
	static public function lerp(n:Vector2, m:Vector2, p:Float)
	{
		return add(mul(n, (1 - p)), mul(m, p));
	}
	
	static public function midpoint(n:Vector2, m:Vector2)
	{
		return new Vector2((n.x + m.x) / 2, (n.y + m.y) / 2);
	}
	
	static public function zero():Vector2
	{
		return new Vector2(0, 0);
	}
}