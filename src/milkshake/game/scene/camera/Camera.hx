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

	var renderTexture:pixi.RenderTexture;
	var renderSprite:pixi.Sprite;

	public function new(x:Int, y:Int, width:Int, height:Int, active:Bool = true)
	{
		super();

		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;

		// Render Width / Height
		renderTexture = new pixi.RenderTexture(Globals.SCREEN_WIDTH, Globals.SCREEN_HEIGHT);
		renderSprite = new pixi.Sprite(renderTexture);

		renderSprite.width = width;
		renderSprite.height = height;

		displayObject.addChild(renderSprite);
	}

	override public function update(delta:Float):Void
	{
		super.update(delta);

		render();
	}

	public function render():Void
	{
		// Clean dosn't work as expected!?
		renderTexture.render(scene.displayObject, false);
	}
}