package milkshake.game.scene.camera;

import milkshake.core.DisplayObject;
import milkshake.core.Entity;
import milkshake.math.Vector2;
import milkshake.Milkshake;
import milkshake.utils.Globals;

class Camera extends DisplayObject
{
	public var active(default, default):Bool;

	public var targetPosition:Vector2;

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

		// Render Width / Height
		renderTexture = new pixi.RenderTexture(renderWidth, renderHeight);
		renderSprite = new pixi.Sprite(renderTexture);

		renderSprite.width = width;
		renderSprite.height = height;

		targetPosition = Vector2.ZERO;
		matrix = new pixi.Matrix();

		displayObject.addChild(renderSprite);
	}

	override public function update(delta:Float):Void
	{
		matrix.identity();
		matrix.translate(-targetPosition.x, -targetPosition.y);
		
		scene.render(this);

		untyped renderTexture.render(scene.displayObject, matrix, true);

		super.update(delta);
	}
}