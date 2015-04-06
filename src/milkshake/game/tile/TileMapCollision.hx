package milkshake.game.tile;

import milkshake.core.DisplayObject;
import milkshake.core.Graphics;
import milkshake.game.tile.TileMapData;
import milkshake.utils.Color;
import pixi.Rectangle;

class TileMapCollision extends DisplayObject
{
	var rectangles:Array<Rectangle>;
	var graphics:Graphics;

	public function new(tileMapData:TileMapData, tileSize:Int)
	{
		super();

		rectangles = [];

		for (x in 0 ... tileMapData.width)
		{
			for (y in 0 ... tileMapData.height)
			{
				var index = tileMapData.data[y][x];

				if(index > 0)
				{
					rectangles.push(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
				}
			}
		}

		addNode(graphics = new Graphics());
	}

	override public function update(deltaTime:Float):Void
	{
		graphics.clear();
		graphics.begin(Color.RED, 0.1, 1, Color.RED);

		graphics.graphics.drawRect(0, 0, 10, 10);

		for(rectangle in rectangles)
		{	
			graphics.drawRectangle(rectangle);
		}

		super.update(deltaTime);
	}
}