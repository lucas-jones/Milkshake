package milkshake.game.nape;

import milkshake.core.GameObject;
import nape.shape.Polygon;
import nape.space.Space;
import nape.util.Debug;
import pixi.Graphics;

class NapeDebug extends GameObject
{
	var pixiDebug:PixiDebug;
	
	public function new() 
	{
		super();
		pixiDebug = new PixiDebug();
	}
	
	public function fixup()
	{
		displayObject.addChild(pixiDebug.graphics);
	}
	
	public function draw(space:Space):Void
	{
		pixiDebug.draw(space);
	}
}


class PixiDebug extends Debug
{
	public var graphics(default, default):Graphics;
	
	public function new() 
	{
		graphics = new Graphics();
	}
	
	public function draw(space:Space)
	{
		graphics.clear();
		
		for (body in space.bodies)
		{
			for (shape in body.shapes)
			{
				if (Std.is(shape, Polygon))
				{
					var polygon:Polygon = cast shape;
					
					
					graphics.lineStyle(1, 0xFF0000);
					graphics.beginFill(0xFF0000, 0.5);
					
					for (a in 0 ... polygon.worldVerts.length)
					{
						var x = polygon.worldVerts.at(a).x;
						var y = polygon.worldVerts.at(a).y;
						
						if (a == 0) graphics.moveTo(x, y);
						
						graphics.lineTo(x, y);
					}
					
					graphics.endFill();
				}
			}
		}
	}
	
}