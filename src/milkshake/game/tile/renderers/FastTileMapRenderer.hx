package milkshake.game.tile.renderers;

import milkshake.game.scene.camera.Camera;
import milkshake.game.tile.TileMapRenderer;
import milkshake.game.tile.TileMapData;
import milkshake.game.tile.TileSet;
import pixi.BaseTexture;
import pixi.Sprite;
import pixi.SpriteBatch;
import pixi.Texture;

class FastTileMapRenderer extends TileMapRenderer
{
	var spriteBatch:SpriteBatch;

	var tileSet:TileSet;
	var screenWidth:Int;
	var screenHeight:Int;

	var sprites:Array<Array<Sprite>>;

	var cacheXTile:Int;
	var cacheYTile:Int;

	public function new(tileSheet:BaseTexture, tileSize:Int, screenWidth:Int, screenHeight:Int):Void
	{
		super();

		this.tileSet = new TileSet(tileSheet, tileSize);
		this.screenWidth = screenWidth;
		this.screenHeight = screenHeight;

		displayObject.addChild(spriteBatch = new SpriteBatch());
	}

	override public function setup(tileMapData:TileMapData):Void
	{
		super.setup(tileMapData);

		sprites = [];

		var horazontalTileCount:Int = Math.ceil(screenWidth / tileSet.tileSize) + 1;
		var verticalTileCount:Int = Math.ceil(screenHeight / tileSet.tileSize) + 1;

		for (x in 0 ... horazontalTileCount)
		{
			sprites.push(new Array<Sprite>());

			for (y in 0 ... verticalTileCount)
			{
				var sprite = new Sprite(tileSet.tiles[5]);

				sprite.position.x = x * tileSet.tileSize;
				sprite.position.y = y * tileSet.tileSize;

				this.spriteBatch.addChild(sprite);

				sprites[x].push(sprite);
			}
		}
	}

	override public function render(camera:Camera):Void
	{
		super.render(camera);

		var currentXTile = Math.floor(camera.boundingBox.x / tileSet.tileSize);
		var currentYTile = Math.floor(camera.boundingBox.y / tileSet.tileSize);

		x =  camera.boundingBox.x; // + -(camera.boundingBox.x % tileSet.tileSize);
		y =  camera.boundingBox.y; // + -(camera.targetPosition.y % tileSet.tileSize);

		//if(currentXTile != cacheXTile || currentYTile != cacheYTile)
		//{
			cacheXTile = currentXTile;
			cacheYTile = currentYTile;

			var horazontalTileCount:Int = Math.ceil(screenWidth / tileSet.tileSize) + 1;
			var verticalTileCount:Int = Math.ceil(screenHeight / tileSet.tileSize) + 1;

			for (x in 0 ... horazontalTileCount)
			{
				for (y in 0 ... verticalTileCount)
				{
					var tileIndex:Int = tileMapData.data[currentYTile + y][currentXTile + x];
					var sprite:Sprite = sprites[x][y];

					if(tileIndex != null)
					{
						untyped sprite.texture = tileSet.tiles[tileIndex];
						sprite.visible = tileIndex > 0;
					}
					else
					{
						sprite.visible = false;
					}
				}
			}
		//}

	}
}