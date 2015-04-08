package milkshake.game.tile.renderers;

import mconsole.Console;
import milkshake.core.Sprite;
import milkshake.game.scene.camera.Camera;
import milkshake.game.tile.TileMapRenderer;
import milkshake.game.tile.TileMapData;
import pixi.BaseTexture;
import pixi.Rectangle;
import pixi.SpriteBatch;
import pixi.Texture;

class BasicTileMapRenderer extends TileMapRenderer
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

		displayObject.addChild(spriteBatch = new SpriteBatch());
	}

	override public function setup(tileMapData:TileMapData):Void
	{
		for (x in 0 ... tileMapData.width)
		{
			for (y in 0 ... tileMapData.height)
			{
				var index = tileMapData.data[y][x];

				if(index > 0)
				{
					var pixiSprite = new pixi.Sprite(tiles[index]);

					pixiSprite.position.x = x * tileSize;
					pixiSprite.position.y = y * tileSize;

					spriteBatch.addChild(pixiSprite);
				}
			}
		}
	}

	override public function render(camera:Camera):Void
	{
		super.render(camera);

		for(child in spriteBatch.children)
		{
			child.visible = child.position.y > camera.boundingBox.y - 24 && child.position.y < camera.boundingBox.y + camera.boundingBox.height;
		}
	}
}