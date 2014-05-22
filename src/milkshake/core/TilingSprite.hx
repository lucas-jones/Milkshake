package milkshake.core;

import pixi.Texture;

class TilingSprite extends GameObject
{
	public var url(default, null):String;
	public var width(default, null):Int;
	public var height(default, null):Int;
	
	public function new(url:String, width:Int, height:Int, id:String="undefined-sprite")
	{
		this.url = url;
		this.width = width;
		this.height = height;
		
		super(id);
	}
	
	override public function setup():Void 
	{
		displayObject = new pixi.TilingSprite(Texture.fromImage(url), width, height);
	}
}