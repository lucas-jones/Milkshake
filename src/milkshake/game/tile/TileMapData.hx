package milkshake.game.tile;

using StringTools;

class TileMapData
{
	public static function fromCSV(csv:String):TileMapData
	{
		var data:Array<Array<Int>> = [];

		var rows:Array<String> = csv.split('\n');

		for(row in 0...rows.length)
		{
			var columns:Array<String> = rows[row].split(",");

			data.push(new Array<Int>());

			for(column in 0...columns.length)
			{
				data[row].push(Std.parseInt(columns[column]));
			}
		}

		return new TileMapData(data);
	}

	public var data(default, null):Array<Array<Int>>;

	public var width(default, null):Int;
	public var height(default, null):Int;

	public function new(data:Array<Array<Int>>)
	{
		this.data = data;

		updateBounds();
	}

	function updateBounds():Void
	{
		height = data.length;
		width = data.length > 0 ? data[0].length : 0;
	}

	public function findTileByIndex(index:Int):Array<TilePoint>
	{
		return findTilesByIndex([ index ]);
	}

	public function findTilesByIndex(indexes:Array<Int>):Array<TilePoint>
	{
		var result:Array<TilePoint> = [];

		for (y in 0...height)
		{
			for (x in 0...width)
			{
				if(indexes.indexOf(data[y][x]) != -1) result.push(new TilePoint(x, y, data[y][x]));
			}
		}

		return result;
	}

	public function print():Void
	{
		for (y in 0...height)
		{
			var line:String = "";

			for (x in 0...width)
			{
				var index:Int = data[y][x];

				if(index == 0)
				{
					line += '  ';
				}
				else if(index < 9)
				{
					line += '0${index}';
				}
				else
				{
					line += '${index}';
				}

				line += " ";
			}

			trace(line);
		}
	}
}