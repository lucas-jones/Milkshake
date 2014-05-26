package milkshake.core;

import pixi.Texture;

class TilingSprite extends GameObject
{
	var width:Int;
	var height:Int;
	var sprite(default, null):pixi.TilingSprite;
	
	public var url(default, null):String;
	public var alpha(get, set):Float;
	
	public function new(url:String, width:Int, height:Int, id:String="undefined-sprite")
	{
		this.url = url;
		this.width = width;
		this.height = height;
		super(id);
	}
	
	public function get_alpha():Float
	{
		return sprite.alpha;
	}
	
	public function set_alpha(value:Float):Float
	{
		return sprite.alpha = value;
	}
	
	override public function setup():Void 
	{
		displayObject = sprite = new pixi.TilingSprite(Texture.fromImage(url), width, height);
		sprite.anchor.x = 0.5;
		sprite.anchor.y = 0.5;
	}
}