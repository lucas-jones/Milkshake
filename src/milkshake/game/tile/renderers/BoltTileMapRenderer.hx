package milkshake.game.tile.renderers;

import mconsole.Console;
import milkshake.core.Sprite;
import milkshake.game.scene.camera.Camera;
import milkshake.game.tile.TileMapAlgorithms;
import milkshake.game.tile.TileMapRenderer;
import milkshake.game.tile.TileMapData;
import pixi.BaseTexture;
import pixi.Rectangle;
import pixi.SpriteBatch;
import pixi.Texture;

class BoltTile extends Rectangle
{
	public var index:Int;

	public function new(index:Int, x:Int, y:Int, width:Int, height:Int)
	{
		this.index = index;

		super(x, y, width, height);
	}
}

class BoltTileMapRenderer extends TileMapRenderer
{
	var spriteBatch:SpriteBatch;
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

		//displayObject.addChild(spriteBatch = new SpriteBatch());
	}

	override public function setup(tileMapData:TileMapData):Void
	{
		var boltTileGrid:Array<Array<BoltTile>> = [];

		for (x in 0 ... tileMapData.width)
		{
			for (y in 0 ... tileMapData.height)
			{
				if(boltTileGrid[y] == null) boltTileGrid[y] = [];

				if(tileMapData.data[y][x] != null)
				{
					var index = tileMapData.data[y][x];

					if(index > 0) boltTileGrid[y][x] = new BoltTile(index, x * tileSize, y * tileSize, tileSize, tileSize);
				}
			}
		}

		var boltTiles:Array<BoltTile> = cast TileMapAlgorithms.simplify(cast boltTileGrid, tileMapData.width, tileMapData.height, tileSize, function(aX, aY, bX, bY):Bool
		{
			return tileMapData.data[aY][aX] == tileMapData.data[bY][bX];
		});

		for(tile in boltTiles)
		{
			var pixiSprite = new pixi.TilingSprite(tiles[tile.index], tile.width, tile.height);

			pixiSprite.position.x = tile.x;
			pixiSprite.position.y = tile.y;
			pixiSprite.width = tile.width;
			pixiSprite.height = tile.height;

			displayObject.addChild(pixiSprite);


			// var graphic = new pixi.Graphics();
			// graphic.beginFill(0xFF0000, 0.5);
			// graphic.lineStyle(1, 0x000000);
			// graphic.drawRect(0, 0, tile.width, tile.height);

			// graphic.position.x = tile.x;
			// graphic.position.y = tile.y;

			// displayObject.addChild(graphic);
		}
	}

	override public function render(camera:Camera):Void
	{
		super.render(camera);

		for(child in displayObject.children)
		{
			child.visible = child.position.y > camera.boundingBox.y - child.height && child.position.y < camera.boundingBox.y + camera.boundingBox.height;
		}
	}
}