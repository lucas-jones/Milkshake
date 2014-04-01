package milkshake.core;

import pixi.Pixi;
import pixi.Texture;

class Sprite extends Entity
{
	public var sprite:pixi.Sprite;
	
	public function new(url:String, id:String="undefined-gameobject") 
	{
		super(id);
		
		sprite = new pixi.Sprite(Texture.fromImage(url));
	}
}