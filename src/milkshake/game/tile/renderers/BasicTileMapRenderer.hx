package milkshake.game.tile.renderers;

import mconsole.Console;
import milkshake.core.Sprite;
import milkshake.game.scene.camera.Camera;
import milkshake.game.tile.TileMapRenderer;
import milkshake.game.tile.TileMapData;
import pixi.core.math.shapes.Rectangle;
import pixi.core.particles.ParticleContainer;
import pixi.core.sprites.Sprite;
import pixi.core.textures.BaseTexture;
import pixi.core.textures.Texture;

class BasicTileMapRenderer extends TileMapRenderer
{
	var spriteBatch:ParticleContainer;
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

		displayObject.addChild(spriteBatch = new ParticleContainer());
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
					var pixiSprite = new Sprite(tiles[index]);

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