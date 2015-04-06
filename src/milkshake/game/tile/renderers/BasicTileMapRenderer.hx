package milkshake.game.tile.renderers;

import mconsole.Console;
import milkshake.core.Sprite;
import milkshake.game.scene.camera.Camera;
import milkshake.game.tile.TileMapRenderer;
import milkshake.game.tile.TileMapData;
import pixi.BaseTexture;
import pixi.Rectangle;
import pixi.Texture;

class BasicTileMapRenderer extends TileMapRenderer
{
	var tileSheet:BaseTexture;
	var tileSize:Int;

	var tiles:Array<Texture>;

	public function new(tileSheet:BaseTexture, tileSize:Int):Void
	{
		super();

		this.tileSheet = tileSheet;
		this.tileSize = tileSize;

		var horizontalTile = Math.floor(tileSheet.width / tileSize);
		var verticalTile = Math.floor(tileSheet.height / tileSize);

		tiles = [];

		for (y in 0 ... verticalTile)
		{
			for (x in 0 ... horizontalTile)
			{
				tiles.push(new Texture(tileSheet, new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize)));
			}
		}
	}

	override public function setup(tileMapData:TileMapData):Void
	{
		for (x in 0 ... tileMapData.width)
		{
			for (y in 0 ... tileMapData.height)
			{
				var index = tileMapData.data[y][x];

				addNode(new Sprite(tiles[index]),
				{
					x: x * tileSize,
					y: y * tileSize
				});
			}
		}
	}

	override public function render(camera:Camera):Void
	{
		Console.log("TileMapRenderer Camera: " + camera.id);

		super.render(camera);		
	}
}