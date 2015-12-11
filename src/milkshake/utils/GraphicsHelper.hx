package milkshake.utils;

import milkshake.core.Graphics;

class GraphicsHelper
{
	public static function generateRectangle(width:Int, height:Int, color:Int, ?centered:Bool):Graphics
	{
		var graphics = new Graphics();
		graphics.graphics.beginFill(color);
		graphics.graphics.drawRect(centered ? -(width / 2) : 0, centered ? -(height / 2) : 0, width, height);

		return 	graphics;
	}
}