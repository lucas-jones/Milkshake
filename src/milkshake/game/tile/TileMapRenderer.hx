package milkshake.game.tile;

import milkshake.core.DisplayObject;
import milkshake.game.scene.camera.Camera;
import milkshake.game.tile.TileMapData;

class TileMapRenderer extends DisplayObject
{
	var tileMapData:TileMapData;

	public function new():Void
	{
		super();
	}

	public function setup(tileMapData:TileMapData):Void
	{
		this.tileMapData = tileMapData;
	}
}