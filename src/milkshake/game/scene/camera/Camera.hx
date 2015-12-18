package milkshake.game.scene.camera;

import milkshake.utils.MathHelper;
import milkshake.core.DisplayObject;
import milkshake.math.Vector2;
import milkshake.Milkshake;
import milkshake.utils.Globals;
import pixi.core.math.Matrix;
import pixi.core.math.Point;
import pixi.core.math.shapes.Rectangle;
import pixi.core.sprites.Sprite;
import pixi.core.textures.RenderTexture;

class Camera extends DisplayObject
{
	public var active(default, default):Bool;
	public var fixedRotation:Bool = true;

	public var targetPosition:Vector2;
	public var targetRotation:Float;
	public var targetZoom:Float;

	public var boundingBox:Rectangle;

	public var renderWidth(default, null):Int;
	public var renderHeight(default, null):Int;

	var renderTexture:RenderTexture;
	var renderSprite:Sprite;

	var matrix:Matrix;

	var topLeft:Point;
	var bottomRight:Point;

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
		renderTexture = new RenderTexture(cast Milkshake.getInstance().renderer, this.renderWidth, this.renderHeight);
		renderSprite = new Sprite(renderTexture);

		renderSprite.width = width;
		renderSprite.height = height;

		targetPosition = new Vector2(width, height).multi(Vector2.HALF);
		targetRotation = 0;
		targetZoom = 1;

		matrix = new Matrix();

		displayObject.addChild(renderSprite);

		topLeft = new Point(0, 0);
		bottomRight = new Point(this.renderWidth, this.renderHeight);
	}

	override public function update(delta:Float):Void
	{
		// Play that funky matrix music!
		matrix.identity();
		matrix.translate(-targetPosition.x, -targetPosition.y);
		if(!fixedRotation) matrix.rotate(-targetRotation + MathHelper.toRadians(180));
		matrix.scale(targetZoom, targetZoom);
		matrix.translate(width / 2, height / 2);

		updateBoundingBox();

		scene.render(this);

		untyped renderTexture.render(scene.displayObject, matrix, true);

		super.update(delta);
	}

	public function updateBoundingBox():Void
	{
		var debugPadding = 0;

		// [ToDo] Creating points every frame
		var topLeft = matrix.applyInverse(topLeft);
		var bottomRight = matrix.applyInverse(bottomRight);

		boundingBox.x = topLeft.x;
		boundingBox.y = topLeft.y;

		boundingBox.width = bottomRight.x - topLeft.x;
		boundingBox.height = bottomRight.y - topLeft.y;
	}
}