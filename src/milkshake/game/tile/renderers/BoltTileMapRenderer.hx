package milkshake.game.tile.renderers;

import js.Browser;
import js.html.CanvasPattern;
import js.html.CanvasRenderingContext2D;
import js.html.Document;
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

class BoltSpriteBatch extends SpriteBatch
{
	var tileSize:Int = 24;
	var texture:BaseTexture;
	var patternsGenerated:Bool = false;

	var patterns:Array<CanvasPattern>;

	public function new(tileSize:Int, texture:BaseTexture)
	{
		super(texture);

		this.texture = texture;
		this.tileSize = tileSize;
	}

	override public function _renderCanvas(renderSession:Dynamic)
	{
		var context:CanvasRenderingContext2D = renderSession.context;

		if(!patternsGenerated)
		{
			patterns = [];

			var horizontalTile = Math.floor(texture.width / tileSize);
			var verticalTile = Math.floor(texture.height / tileSize);		

			for (y in 0 ... verticalTile)
			{
				for (x in 0 ... horizontalTile)
				{
					var canvas = Browser.document.createCanvasElement();
					canvas.width = 24;
					canvas.height = 24;
					var tempContext = canvas.getContext2d();

					tempContext.drawImage(texture.source, x * 24, y * 24, 24, 24, 0, 0, 24, 24);
					//tempContext.fillRect(0, 0, 24, 24);

					patterns.push(context.createPattern(cast canvas, "repeat"));
				}
			}

			patternsGenerated = true;
		}

		untyped this.displayObjectUpdateTransform();

		var transform = untyped this.worldTransform;

		context.setTransform(transform.a, transform.b, transform.c, transform.d, transform.tx | 0, transform.ty | 0);

		var lastIndex:Int = -1;

		for(child in children)
		{
			if(!child.visible) continue;

			var texture = untyped child.texture;
        	var frame = texture.frame;

        	untyped child.displayObjectUpdateTransform();
           
            // var childTransform = untyped child.worldTransform;

            //context.fillStyle="#00FF00";
            if(untyped child.index != lastIndex)
            {
            	context.fillStyle = patterns[untyped child.index];
            	lastIndex = untyped child.index;
            }

            
            context.fillRect(child.position.x, child.position.y, child.width, child.height);
			// context.drawImage(texture.baseTexture.source,
   //                               frame.x,
   //                               frame.y,
   //                               24,
   //                               24,
   //                               child.position.x,
   //                               child.position.y,
   //                               child.width,
   //                               child.height);
		
		}

		//super._renderCanvas(renderSession);
	}
}

class BoltTile extends Rectangle
{
	public var index:Int;

	public function new(index:Int, x:Int, y:Int, width:Int, height:Int)
	{
		this.index = index;

		super(x, y, width, height);
	}
}

class BoltSprite extends pixi.Sprite
{
	public var index:Int;

	public function new(index:Int, texture:Texture)
	{
		super(texture);

		this.index = index;
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

		displayObject.addChild(spriteBatch = new BoltSpriteBatch(24, tileSheet));
	}

	override public function setup(tileMapData:TileMapData):Void
	{
		var boltTileGrid:Array<Array<BoltTile>> = [];
		var boltTiles:Array<BoltTile> = [];

		for (x in 0 ... tileMapData.width)
		{
			for (y in 0 ... tileMapData.height)
			{
				if(boltTileGrid[y] == null) boltTileGrid[y] = [];

				if(tileMapData.data[y][x] != null)
				{
					var index = tileMapData.data[y][x];

					if(index > 0)
					{
						var tile = new BoltTile(index, x * tileSize, y * tileSize, tileSize, tileSize);
						
						boltTiles.push(tile);
						boltTileGrid[y][x] = tile;
					}
				}
			}
		}

		boltTiles = cast TileMapAlgorithms.simplify(cast boltTileGrid, tileMapData.width, tileMapData.height, tileSize, function(aX, aY, bX, bY):Bool
		{
			return tileMapData.data[aY][aX] == tileMapData.data[bY][bX];
		});

		for(tile in boltTiles)
		{
			var pixiSprite = new BoltSprite(tile.index, tiles[tile.index]);

			pixiSprite.position.x = tile.x;
			pixiSprite.position.y = tile.y;
			pixiSprite.width = tile.width;
			pixiSprite.height = tile.height;

			spriteBatch.addChild(pixiSprite);
			
			// var graphic = new pixi.Graphics();
			// graphic.beginFill(0x000000, 0);
			// graphic.lineStyle(2, 0xFF0000);
			// graphic.drawRect(0, 0, tile.width, tile.height);

			// graphic.position.x = tile.x;
			// graphic.position.y = tile.y;

			// displayObject.addChild(graphic);
		}

		spriteBatch.children.sort(function(a, b):Int
		{
			if(untyped a.index > untyped b.index) return 1;
			if(untyped a.index < untyped b.index) return -1;

			return 0;
		});
	}

	override public function render(camera:Camera):Void
	{
		super.render(camera);

		for(child in spriteBatch.children)
		{
			child.visible = child.position.y > camera.boundingBox.y - child.height && child.position.y < camera.boundingBox.y + camera.boundingBox.height
							&& child.position.x > camera.boundingBox.x - child.width && child.position.x < camera.boundingBox.x + camera.boundingBox.width;
		}
	}
}