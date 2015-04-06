package milkshake.core;

import milkshake.core.DisplayObject;
import pixi.DisplayObjectContainer;

class Text extends DisplayObject
{
	var text:pixi.Text;

	public function new(message:String)
	{
		super();

		displayObject.addChild(text = new pixi.Text(message));
	}
	
	public function setText(message:String)
	{
		text.setText(message);
	}	
}