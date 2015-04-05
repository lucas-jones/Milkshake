package milkshake.components.phsyics;

import milkshake.core.DisplayObject;
import milkshake.core.Entity;
import nape.shape.Circle;
import nape.shape.Polygon;
import nape.space.Space;
import nape.util.Debug;
import pixi.Graphics;

class PhysicsDebug extends DisplayObject
{
	public var space(default, null):Space;

	var napeDebugDraw:NapeDebugDraw;
	
	public function new(space:Space) 
	{
		super();

		this.space = space;
		napeDebugDraw = new NapeDebugDraw();
		displayObject.addChild(napeDebugDraw.graphics);
	}
	
	override public function update(deltaTime:Float):Void
	{
		super.update(deltaTime);

		napeDebugDraw.draw(space);
	}
}


class NapeDebugDraw extends Debug
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
					graphics.beginFill(0x99FF33, 0.5);					
					//graphics.lineStyle(3, 0x558F1D);
					
					var polygon:Polygon = cast shape;
					
					for (index in 0 ... polygon.worldVerts.length)
					{
						var position = polygon.worldVerts.at(index);
						
						if (index == 0) graphics.moveTo(position.x, position.y);
						else graphics.lineTo(position.x, position.y);						
					}
				}

				if (Std.is(shape, Circle))
				{
					var circle:Circle = cast shape;
					graphics.beginFill(0x00FF00, 0.5);
					graphics.lineStyle(1, 0x00FF00);
					
					graphics.drawCircle(circle.worldCOM.x, circle.worldCOM.y, circle.radius);
					
					graphics.moveTo(circle.worldCOM.x, circle.worldCOM.y);
					graphics.lineTo(body.position.x + circle.radius * Math.cos(body.rotation), body.position.y +circle.radius * Math.sin(body.rotation));
				}
			}
		}
	}	
}
