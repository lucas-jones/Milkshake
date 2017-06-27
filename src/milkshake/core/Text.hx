package milkshake.core;

import milkshake.core.DisplayObject;

class Text extends DisplayObject
{
	var text:pixi.core.text.Text;

	public function new(message:String = "", color:String = "black")
	{
		super();

		displayObject.addChild(text = new pixi.core.text.Text(message));
		setColor(color);
	}

	public function setText(message:String)
	{
		text.text = message;
	}

	public function setColor(color:String)
	{
		text.style.fill = color;
	}
}
