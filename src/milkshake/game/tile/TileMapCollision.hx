package milkshake.game.tile;

import milkshake.core.DisplayObject;
import milkshake.core.Graphics;
import milkshake.game.tile.TileMapData;
import milkshake.utils.Color;
import pixi.Rectangle;

class TileMapCollision extends DisplayObject
{
	var tileMapData:TileMapData;

	var rectanglesGrid:Array<Array<Rectangle>>;
	var rectangles:Array<Rectangle>;

	var graphics:Graphics;

	public function new(tileMapData:TileMapData, tileSize:Int)
	{
		super();

		this.tileMapData = tileMapData;

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
					rectangles.push(rectangle);
				}
				else
				{
					rectanglesGrid[y].push(null);
				}
			}
		}

		addNode(graphics = new Graphics());

		cleanUp();
	}

	function cleanUp():Void
	{
		var delta = Date.now().getTime();

		for (x in 0 ... tileMapData.width - 1)
		{
			for (y in 0 ... tileMapData.height)
			{			
				var retctangle = rectanglesGrid[y][x];
				var index = tileMapData.data[y][x];

				if(retctangle != null)
				{
					var rightRetctangle = rectanglesGrid[y][x + 1];
					var rightIndex = tileMapData.data[y][x + 1];

					if(rightRetctangle != null && index == rightIndex)
					{
						rectangles.remove(rightRetctangle);

						retctangle.width += rightRetctangle.width;
						rectanglesGrid[y][x + 1] = retctangle;
					}					
				}
			}
		}

		for(rectangle in rectangles)
		{
			var xTiles = Math.floor(rectangle.width / 24);
			var sameTile = true;
			var offset = 1;

			while(sameTile)
			{
				for (xTile in 0 ... xTiles)
				{
					var curRetctangle = rectanglesGrid[Math.floor(rectangle.y / 24) + offset][Math.floor(rectangle.x / 24) + xTile];

					var index = tileMapData.data[Math.floor(rectangle.y / 24) + offset][Math.floor(rectangle.x / 24) + xTile];
					var rightIndex = tileMapData.data[Math.floor(rectangle.y / 24)][Math.floor(rectangle.x / 24) + xTile];

					if(curRetctangle == null || curRetctangle.width > rectangle.width || index != rightIndex) sameTile = false;
				}

				if(sameTile)
				{
					rectangle.height += 24;

					for (xTile in 0 ... xTiles)
					{
						var curRetctangle = rectanglesGrid[Math.floor(rectangle.y / 24) + offset][Math.floor(rectangle.x / 24) + xTile];
						rectangles.remove(curRetctangle);
					}

					offset++;
				}
			}
		}

		Console.error(Date.now().getTime() - delta);
		
	}

	override public function update(deltaTime:Float):Void
	{
		graphics.clear();
		graphics.begin(Color.RED, 0.1, 1, Color.RED);

		for(rectangle in rectangles)
		{	
			graphics.drawRectangle(rectangle);
		}

		super.update(deltaTime);
	}
}