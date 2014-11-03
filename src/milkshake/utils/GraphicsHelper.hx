package milkshake.utils;

import milkshake.core.Graphics;

class GraphicsHelper 
{
	public static function generateRectangle(width:Int, height:Int, color:Int):Graphics
	{
		var graphics = new Graphics();
		graphics.graphics.beginFill(color);
		graphics.graphics.drawRect(0, 0, width, height);

		return 	graphics;
	}
}