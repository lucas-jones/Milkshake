package milkshake.game.ui.component;
import milkshake.core.GameObject;
import milkshake.core.Sprite;
import milkshake.core.Text;
import pixi.Graphics;
import pixi.InteractionData;
import pixi.Rectangle;

/**
 * ...
 * @author Milkshake-Inc
 */
class Button extends GameObject
{
	private var over:Bool = false;
	private var graphics:Graphics;
	
	private var width:Float;
	private var height:Float;
	private var color:Int;
	private var colorOver:Int;
	
	public function new(width:Float, height:Float, text:String, color:Int, ?colorOver:Int) 
	{
		super("button");
		this.colorOver = colorOver != null ? colorOver : color;
		this.color = color;
		this.height = height;
		this.width = width;
		
		graphics = new Graphics();
		graphics.hitArea = new Rectangle(0, 0, width, height);
		displayObject.addChild(graphics);
		
		var textSprite:Text = new Text(text, "text");
		textSprite.x = 50;
		textSprite.y = 7;
		addNode(textSprite);
		
		displayObject.setInteractive(true);
		
		displayObject.mouseover = function(data:InteractionData):Void { over = true; };
		displayObject.mouseout = function(data:InteractionData):Void { over = false; };
	}
	
	private function drawBackground():Void
	{
		var color:Int = over ? colorOver : color;
		
		graphics.clear();

		graphics.beginFill(color);
		graphics.drawRect(0, 0, width, height);
		graphics.endFill();
	}
	
	override public function update(deltaTime:Float):Void 
	{
		drawBackground();
		super.update(deltaTime);
	}
}