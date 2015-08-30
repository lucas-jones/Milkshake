package milkshake.core;

import milkshake.core.DisplayObject;

class Text extends DisplayObject
{
	var text:pixi.core.text.Text;

	public function new(message:String = "")
	{
		super();

		displayObject.addChild(text = new pixi.core.text.Text(message));
	}

	public function setText(message:String)
	{
		text.text = message;
	}	
}