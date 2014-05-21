package milkshake.core;

import pixi.BaseTexture;
import pixi.Texture;

class Sprite extends GameObject
{	
	var sprite(default, null):pixi.Sprite;
	
	public var width(get, set):Float;
	public var height(get, set):Float;
	
	public function new(url:String, id:String="undefined-sprite")
	{
		super(id);
		
		if (url != "")
		{
			displayObject.addChild(sprite = new pixi.Sprite(Texture.fromImage(url)));
			//var texture:TextureMap = new TextureMap(BaseTexture.fromImage(url));
			
			//displayObject.addChild(sprite = new pixi.Sprite(texture));
			// Default?
			sprite.anchor.x = 0.5;
			sprite.anchor.y = 0.5;
		}
	}
	
	public function get_width():Float { return sprite.width; }
	public function set_width(value:Float):Float { return sprite.width = value; }
	
	public function get_height():Float { return sprite.height; }
	public function set_height(value:Float):Float { return sprite.height = value; }
}