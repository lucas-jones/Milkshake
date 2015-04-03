package milkshake.game.tile;

class TilePoint
{
	public var x(default, null):Int;
	public var y(default, null):Int;

	public var index(default, null):Int;

	public function new(x:Int, y:Int, index:Int)
	{
		this.x = x;
		this.y = y;

		this.index = index;
	}
}