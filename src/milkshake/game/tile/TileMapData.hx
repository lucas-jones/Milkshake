package milkshake.game.tile;

import milkshake.game.tile.TileMapData;

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

	public function replace(indexA:Int, indexB:Int):Void
	{
		for (y in 0...height)
		{
			for (x in 0...width)
			{
				var index = data[y][x];

				if(index == indexA) data[y][x] = indexB;
			}
		}
	}

	public function replaceBulk(indexes:Array<Int>, indexB:Int = 0):Void
	{
		for (y in 0...height)
		{
			for (x in 0...width)
			{
				var index = data[y][x];

				if(indexes.indexOf(index) != -1) data[y][x] = indexB;
			}
		}
	}

	public function clone():TileMapData
	{
		var newData:Array<Array<Int>> = [];

		for (y in 0...height)
		{
			newData.push(new Array<Int>());

			for (x in 0...width)
			{
				newData[y][x] = data[y][x];
			}
		}

		return new TileMapData(newData);
	}

	public function cut(indexes:Array<Int>):TileMapData
	{
		var cutTileMapData = clone();

		for (y in 0...height)
		{
			for (x in 0...width)
			{
				var index = cutTileMapData.data[y][x];

				if(indexes.indexOf(index) == -1) cutTileMapData.data[y][x] = null;
			}
		}

		replaceBulk(indexes);

		return cutTileMapData;
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