package milkshake.core;

import milkshake.core.DisplayObject;
import milkshake.math.Vector2;
import milkshake.utils.Color;
import pixi.core.math.shapes.Rectangle;

class Graphics extends DisplayObject
{
	public var graphics(default, null):pixi.core.graphics.Graphics;

	public var anchor(default, default):Vector2;

	public function new()
	{
		super();

		this.anchor = Vector2.ZERO;

		displayObject.addChild(graphics = new pixi.core.graphics.Graphics());
	}

	public function clear():Void
	{
		graphics.clear();
	}

	public function begin(color:Int, alpha:Float = 1, lineWidth:Float = 0, lineColor:Int = Color.WHITE)
	{
		graphics.beginFill(color, alpha);
		graphics.lineStyle(lineWidth, lineColor);
	}

	public function drawRectangle(rectangle:Rectangle, ?fill:Int):Void
	{
		graphics.drawRect(rectangle.x, rectangle.y, rectangle.width, rectangle.height);
	}

	override public function update(delta:Float):Void
	{
		super.update(delta);
		
		displayObject.pivot.x = graphics.width - ((1 - anchor.x) * graphics.width);
		displayObject.pivot.y = graphics.height - ((1 - anchor.y) * graphics.height);
	}
}