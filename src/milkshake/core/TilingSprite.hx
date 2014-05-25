package milkshake.core;

import pixi.Texture;

class TilingSprite extends GameObject
{
	var width:Int;
	var height:Int;
	public var url(default, null):String;
	
	public function new(url:String, width:Int, height:Int, id:String="undefined-sprite")
	{
		super(id);
		this.url = url;
		this.width = width;
		this.height = height;
	}
	
	override public function setup():Void 
	{
		displayObject = new pixi.TilingSprite(Texture.fromImage(url), width, height);
	}
}