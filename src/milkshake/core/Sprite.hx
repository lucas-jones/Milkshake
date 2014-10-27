package milkshake.core;

import milkshake.core.DisplayObject;
import milkshake.math.Vector2;
import pixi.BaseTexture;
import pixi.Texture;

class Sprite extends DisplayObject
{
	var url:String;
	var sprite(default, null):pixi.Sprite;

	public var anchor(default, default):Vector2;
	
	public function new(url:String, id:String="undefined-sprite")
	{
		super(id);

		this.url = url;
		this.anchor = Vector2.ZERO;

		displayObject.addChild(sprite = new pixi.Sprite(Texture.fromImage(url)));
	}

	override public function update(delta:Float):Void
	{
		sprite.anchor.x = anchor.x;
		sprite.anchor.y = anchor.y;

		super.update(delta);
	}
}