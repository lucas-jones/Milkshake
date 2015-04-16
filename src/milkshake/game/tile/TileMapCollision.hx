package milkshake.game.tile;

import hxcollision.shapes.Polygon;
import milkshake.core.DisplayObject;
import milkshake.core.Graphics;
import milkshake.game.tile.TileMapAlgorithms;
import milkshake.game.tile.TileMapData;
import milkshake.utils.Color;
import pixi.Rectangle;

class TileMapCollision extends DisplayObject
{
	var tileMapData:TileMapData;

	var rectanglesGrid:Array<Array<Rectangle>>;
	var rectangles:Array<Polygon>;

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
				}
				else
				{
					rectanglesGrid[y].push(null);
				}
			}
		}

		addNode(graphics = new Graphics());
		
		rectangles = TileMapAlgorithms.simplify(rectanglesGrid, tileMapData.width, tileMapData.height, 24, function(aX, aY, bX, bY):Bool
		{
			return tileMapData.data[aY][aX] > 0 && tileMapData.data[bY][bX] > 0;
		}).map(function(rectangle)
		{
			return Polygon.rectangle(rectangle.x, rectangle.y, rectangle.width, rectangle.height, false);
		});

		rectangle = Polygon.square(0, 0, 50, false);
	}

	var rectangle:Polygon;

	override public function update(deltaTime:Float):Void
	{
		// graphics.clear();
		// graphics.begin(Color.RED, 0.1, 1, Color.RED);

		// for(rectangle in rectangles)
		// {	
		// 	for(index in 0 ... rectangle.transformedVertices.length)
		// 	{
		// 		var pointA = rectangle.transformedVertices[index];
		// 		var pointB = index + 1 < rectangle.transformedVertices.length ? rectangle.transformedVertices[index + 1] : rectangle.transformedVertices[0];

		// 		graphics.graphics.moveTo(pointA.x, pointA.y);
		// 		graphics.graphics.lineTo(pointB.x, pointB.y);
		// 	}
		// }

		// //rectangle.x = milkshake.Milkshake.getInstance().mousePosition.x;
		// rectangle.y += 2;// = milkshake.Milkshake.getInstance().mousePosition.y + scene.cameras.activeCameras[0].targetPosition.y - (720 / 2);

		// //var current = Date.now().getTime();
		// var results = hxcollision.Collision.testShapes(rectangle, cast rectangles);

		// for(result in results)
		// {
		// 	rectangle.x += result.separation.x;
		// 	rectangle.y += result.separation.y;
		// }

		//Console.log((Date.now().getTime() - current) + "ms");

		// graphics.graphics.drawRect(rectangle.x, rectangle.y, 50, 50);

		super.update(deltaTime);
	}

}