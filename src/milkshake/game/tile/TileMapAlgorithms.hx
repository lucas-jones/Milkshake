package milkshake.game.tile;

import pixi.Rectangle;

class TileMapAlgorithms 
{
	public static function simplify(tileMapRectangles:Array<Array<Rectangle>>, tileMapWidth:Int, tileMapHeight:Int, tileSize:Int, compare:Int->Int->Int->Int->Bool):Array<Rectangle>
	{
		var optimisedRectangles:Array<Rectangle> = [ ];

		for (x in 0 ... tileMapWidth)
		{
			for (y in 0 ... tileMapHeight)
			{
				var rectangle:Rectangle = tileMapRectangles[y][x];
				
				if(rectangle != null) optimisedRectangles.push(tileMapRectangles[y][x]);				
			}
		}

		// Travel through multi-dimentional array left-right
		for (x in 0 ... tileMapWidth - 1)
		{
			for (y in 0 ... tileMapHeight)
			{
				// If a rectangle exists to the right of the current rectangle
				// and passes the compare function, we merge them
				var rectangle = tileMapRectangles[y][x];
				var nextRectangle = tileMapRectangles[y][x + 1];

				if(rectangle != null && nextRectangle != null)
				{
					if(compare(x, y, x + 1, y))
					{
						// Remove old rectangle
						optimisedRectangles.remove(nextRectangle);						

						// Increase current tiles with
						// Set nextRectangle instanse to this
						rectangle.width += nextRectangle.width;
						tileMapRectangles[y][x + 1] = rectangle;
					}
				}
			}
		}
		
		// Loop through all rectangles
		for(rectangle in optimisedRectangles)
		{
			// Work out how many tiles width the current rectangle is
			var horizontalTiles = Math.floor(rectangle.width / tileSize);
			var matchingTile = true;
			var yOffset = 1;

			while(matchingTile)
			{
				var y = Math.floor(rectangle.y / tileSize);
				var x = Math.floor(rectangle.x / tileSize);

				for (xOffset in 0 ... horizontalTiles)
				{
					var curRetctangle = tileMapRectangles[y + yOffset][x];

					if(curRetctangle == null || curRetctangle.width > rectangle.width || !compare(x + xOffset, y  + yOffset, x + xOffset, y)) matchingTile = false;
				}

				// If all tiles under this rectangle match the upper we
				// can merge the rectangles!
				if(matchingTile)
				{
					rectangle.height += tileSize;

					for (xOffset in 0 ... horizontalTiles)
					{
						optimisedRectangles.remove(tileMapRectangles[y + yOffset][x + xOffset]);
					}

					yOffset++;
				}
			}
		}

		return optimisedRectangles;
	}
}