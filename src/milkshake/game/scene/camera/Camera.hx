package milkshake.game.scene.camera;

import milkshake.core.DisplayObject;
import milkshake.core.Entity;
import milkshake.core.Graphics;
import milkshake.core.Text;
import milkshake.math.Vector2;
import milkshake.Milkshake;
import milkshake.utils.Globals;
import milkshake.utils.GraphicsHelper;
import pixi.Point;
import pixi.Rectangle;

class Camera extends DisplayObject
{
	public var active(default, default):Bool;

	public var targetPosition:Vector2;
	public var targetZoom:Float;

	public var boundingBox:Rectangle;

	public var renderWidth(default, null):Int;
	public var renderHeight(default, null):Int;

	var renderTexture:pixi.RenderTexture;
	var renderSprite:pixi.Sprite;

	var matrix:pixi.Matrix;

	public function new(id:String, x:Int, y:Int, width:Int, height:Int, renderWidth:Int = -1, renderHeight:Int = -1, active:Bool = true)
	{
		super(id);

		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
		this.renderWidth = (renderWidth != -1) ? renderWidth : Globals.SCREEN_WIDTH;
		this.renderHeight = (renderHeight != -1) ? renderHeight : Globals.SCREEN_HEIGHT;

		this.active = active;

		boundingBox = new Rectangle(0, 0, 1, 1);

		// Render Width / Height
		renderTexture = new pixi.RenderTexture(this.renderWidth, this.renderHeight);
		renderSprite = new pixi.Sprite(renderTexture);

		renderSprite.width = width;
		renderSprite.height = height;

		targetPosition = new Vector2(width, height).multi(Vector2.HALF);
		targetZoom = 1;

		matrix = new pixi.Matrix();

		displayObject.addChild(renderSprite);
	}

	override public function update(delta:Float):Void
	{
		// Play that funky matrix music!
		matrix.identity();
		matrix.translate(-targetPosition.x, -targetPosition.y);		
		matrix.scale(targetZoom, targetZoom);	
		matrix.translate(width / 2, height / 2);

		updateBoundingBox();
		scene.render(this);

		untyped renderTexture.render(scene.displayObject, matrix, true);

		super.update(delta);
	}

	public function updateBoundingBox():Void
	{
		var topLeft = matrix.applyInverse(new Point(0, 0));
		var bottomRight = matrix.applyInverse(new Point(renderWidth, renderHeight));

		boundingBox.x = topLeft.x;
		boundingBox.y = topLeft.y;

		boundingBox.width = bottomRight.x - topLeft.x;
		boundingBox.height = bottomRight.y - topLeft.y;
	}
}