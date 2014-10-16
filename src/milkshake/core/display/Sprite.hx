package milkshake.core;

import pixi.BaseTexture;
import pixi.Texture;

class Sprite extends GameObject
{	
	var url:String;
	var sprite(default, null):pixi.Sprite;
	public var alpha(get, set):Float;
	
	public function new(url:String, id:String="undefined-sprite")
	{
		this.url = url;
		
		super(id);
	}
	
	public override function setup():Void
	{
		super.setup();
		
		displayObject.addChild(sprite = new pixi.Sprite(Texture.fromImage(url)));

		sprite.anchor.x = 0.5;
		sprite.anchor.y = 0.5;		
	}
	
	public function get_width():Float { return sprite.width; }
	public function set_width(value:Float):Float { return sprite.width = value; }
	
	public function get_height():Float { return sprite.height; }
	public function set_height(value:Float):Float { return sprite.height = value; }
	
	public function get_alpha():Float { return sprite.alpha; }
	public function set_alpha(value:Float):Float { return sprite.alpha = value; }
}