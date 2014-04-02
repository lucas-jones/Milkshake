package milkshake.core;
import pixi.Texture;

class Sprite extends GameObject
{	
	public function new(url:String, id:String="undefined-sprite")
	{
		super(id);
		
		displayObject.addChild(new pixi.Sprite(Texture.fromImage(url)));
	}
}