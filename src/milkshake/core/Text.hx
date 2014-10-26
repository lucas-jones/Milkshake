package milkshake.core;
import pixi.DisplayObject;
import pixi.DisplayObjectContainer;

class Text extends Sprite
{
	public function new(text:String, id:String="undefined-text") 
	{
		super("", id);
		displayObject.addChild(sprite = new pixi.Text(text));
	}
	
	public function setText(text:String)
	{
		var textObject:Text = cast sprite;
		textObject.setText(text);
	}
	
}