package milkshake.core;

import milkshake.core.DisplayObject;
import milkshake.math.Vector2;

class Graphics extends DisplayObject
{
	public var graphics(default, null):pixi.Graphics;

	public var anchor(default, default):Vector2;

	public function new()
	{
		super();

		this.anchor = Vector2.ZERO;

		displayObject.addChild(graphics = new pixi.Graphics());
	}

	override public function update(delta:Float):Void
	{
		super.update(delta);
		
		displayObject.pivot.x = graphics.width - ((1 - anchor.x) * graphics.width);
		displayObject.pivot.y = graphics.height - ((1 - anchor.y) * graphics.height);
	}
}