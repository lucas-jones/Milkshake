package milkshake.game.tile;

import differ.shapes.Polygon;
import differ.shapes.Shape;
import milkshake.core.DisplayObject;
import milkshake.core.Graphics;
import milkshake.game.tile.TileMapAlgorithms;
import milkshake.game.tile.TileMapData;
import milkshake.utils.Color;
import pixi.Rectangle;

class TileMapCollision extends DisplayObject
{
	public var rectangles(default, null):Array<Polygon>;

	var tileMapData:TileMapData;
	var rectanglesGrid:Array<Array<Rectangle>>;

	var debug:Bool;
	var graphics:Graphics;

	public function new(tileMapData:TileMapData, tileSize:Int, debug:Bool = true)
	{
		super();

		this.tileMapData = tileMapData;
		this.debug = debug;

		rectangles = [];
		rectanglesGrid = [];

		for (x in 0 ... tileMapData.width)
		{
			for (y in 0 ... tileMapData.height)
			{
				var index = tileMapData.data[y][x];

				if(rectanglesGrid[y] == null)
				{
					rectanglesGrid[y] = [];
				}

				if(index > 0)
				{
					var rectangle = new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize);

					rectanglesGrid[y].push(rectangle);
				}
				else
				{
					rectanglesGrid[y].push(null);
				}
			}
		}
		
		rectangles = cast TileMapAlgorithms.simplify(rectanglesGrid, tileMapData.width, tileMapData.height, 64, function(aX, aY, bX, bY):Bool
		{
			return tileMapData.data[aY][aX] > 0 && tileMapData.data[bY][bX] > 0;
		}).map(function(rectangle)
		{
			return Polygon.rectangle(rectangle.x, rectangle.y, rectangle.width, rectangle.height, false);
		});

		addNode(graphics = new Graphics());
	}

	override public function update(deltaTime:Float):Void
	{
		super.update(deltaTime);
	}
}