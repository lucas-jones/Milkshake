package milkshake.game.scene.camera;

import milkshake.core.DisplayObject;
import milkshake.core.Entity;
import milkshake.core.Graphics;
import milkshake.core.Text;
import milkshake.math.Vector2;
import milkshake.Milkshake;
import milkshake.utils.Globals;
import milkshake.utils.GraphicsHelper;
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

		if(renderWidth == -1) renderWidth = Globals.SCREEN_WIDTH;
		if(renderHeight == -1) renderHeight = Globals.SCREEN_HEIGHT;

		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;

		this.active = active;

		boundingBox = new Rectangle(0, 0, 1, 1);

		// Render Width / Height
		renderTexture = new pixi.RenderTexture(renderWidth, renderHeight);
		renderSprite = new pixi.Sprite(renderTexture);

		renderSprite.width = width;
		renderSprite.height = height;

		targetPosition = Vector2.ZERO;
		targetZoom = 1;

		matrix = new pixi.Matrix();

		displayObject.addChild(renderSprite);
	}

	override public function update(delta:Float):Void
	{
		updateBoundingBox();

		// We call render on displayTree to allow objects to cull
		scene.render(this);

		// Play that funky matrix music!
		matrix.identity();
		matrix.translate(-targetPosition.x, -targetPosition.y);		
		matrix.scale(targetZoom, targetZoom);	
		matrix.translate(width / 2, height / 2);

		untyped renderTexture.render(scene.displayObject, matrix, true);

		//matrix.identity();
		//untyped renderTexture.render(this.displayObject, matrix, false);

		super.update(delta);
	}

	function updateBoundingBox():Void
	{
		var debugPadding = 80;

		boundingBox.x = targetPosition.x - (width / 2) + debugPadding;
		boundingBox.y = targetPosition.y - (height / 2) + debugPadding;
		boundingBox.width = width - (debugPadding * 2);
		boundingBox.height = height - (debugPadding * 2);
	}
}