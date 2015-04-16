package milkshake.game.tile;

import pixi.BaseTexture;
import pixi.Rectangle;
import pixi.Texture;

class TileSet
{
	public var baseTexture(default, null):BaseTexture;
	public var tileSize(default, null):Int;

	public var tiles(default, null):Array<Texture>;

	public function new(baseTexture:BaseTexture, tileSize:Int)
	{
		this.baseTexture = baseTexture;
		this.tileSize = tileSize;

		var horizontalTile = Math.floor(baseTexture.width / tileSize);
		var verticalTile = Math.floor(baseTexture.height / tileSize);

		tiles = [];

		for (y in 0 ... verticalTile)
		{
			for (x in 0 ... horizontalTile)
			{
				tiles.push(new Texture(baseTexture, new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize)));
			}
		}
	}
}