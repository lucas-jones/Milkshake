package milkshake.core;

import milkshake.core.DisplayObject;
import milkshake.game.scene.camera.Camera;
import milkshake.math.Vector2;
import pixi.BaseTexture;
import pixi.Texture;

class Sprite extends DisplayObject
{
	public static function fromUrl(url:String):Sprite
	{
		return new Sprite(Texture.fromImage(url));
	}

	public static function fromFrame(frame:String):Sprite
	{
		return new Sprite(Texture.fromFrame(frame));
	}

	var sprite(default, null):pixi.Sprite;

	public var anchor(default, default):Vector2;
	
	public function new(texture:Texture, id:String="undefined-sprite")
	{
		super(id);

		this.anchor = Vector2.ZERO;

		displayObject.addChild(sprite = new pixi.Sprite(texture));
	}

	override public function update(delta:Float):Void
	{
		sprite.anchor.x = anchor.x;
		sprite.anchor.y = anchor.y;

		// sprite.width = width;
		// sprite.height = height;

		super.update(delta);
	}

	override public function render(camera:Camera):Void
	{
		/* Calling width / height on sprite slow!
		visible = (camera.boundingBox.x < this.x + 24) && (camera.boundingBox.x + camera.boundingBox.width > this.x) &&
			 	  (camera.boundingBox.y < this.y + 24) && (camera.boundingBox.y + camera.boundingBox.height > this.y);
		*/
	}
}