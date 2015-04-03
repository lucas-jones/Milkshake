package milkshake.game.tile;

import hxcollision.shapes.Polygon;
import hxcollision.shapes.Shape;
import milkshake.game.tile.TileMapData;

class TileMapCollision
{
	var tileShapes:Array<Shape>;

	public function new(tileMapData:TileMapData, tileSize:Int)
	{
		for (x in 0 ... tileMapData.width)
		{
			for (y in 0 ... tileMapData.height)
			{
				tileShapes.push(Polygon.rectangle(x * tileSize, y * tileSize, tileSize, tileSize);
			}
		}
	}

	public function update()
	{
		for(shapes in tileShapes)
		{
			
		}
	}
}