package milkshake.game.scene.camera;

import milkshake.core.DisplayObject;
import milkshake.core.Entity;
import milkshake.Milkshake;
import milkshake.utils.Globals;

class Camera extends DisplayObject
{
	public var active(default, default):Bool;

	public var width(default, null):Int;
	public var height(default, null):Int;

	public var renderWidth(default, null):Int;
	public var renderHeight(default, null):Int;

	var renderTexture:pixi.RenderTexture;
	var renderSprite:pixi.Sprite;

	public function new(x:Int, y:Int, width:Int, height:Int, renderWidth:Int = -1, renderHeight:Int = -1, active:Bool = true)
	{
		super();

		if(renderWidth == -1) renderWidth = Globals.SCREEN_WIDTH;
		if(renderHeight == -1) renderHeight = Globals.SCREEN_HEIGHT;

		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;

		// Render Width / Height
		renderTexture = new pixi.RenderTexture(renderWidth, renderHeight);
		renderSprite = new pixi.Sprite(renderTexture);

		renderSprite.width = width;
		renderSprite.height = height;

		displayObject.addChild(renderSprite);
	}

	override public function update(delta:Float):Void
	{
		render();
		super.update(delta);	
	}

	public function render():Void
	{
		untyped renderTexture.render(scene.displayObject, false);
	}
}