package ;

import haxe.Http;
import milk.IGame;
import milk.IGameCore;
//import pixi.DisplayObjectContainer;
import pixi.Sprite;
import pixi.Stage;
import pixi.Texture;

@:expose
class Milk
{
	function new()
	{
		#if js
		trace("[Milk] Javascript");
		new MilkGame().boot(289, 510);
		#end
	}
	
	public static function main()
	{
		#if cs
		trace("[Milk] C#");
		new MilkGame().boot(289, 510);
		#end
	}
}
/*
class ScrollingBackgroundSprite extends DisplayObjectContainer
{
	var spriteContainer:DisplayObjectContainer;
	var spriteA:Sprite;
	var spriteB:Sprite;
	var speed:Int;
	
	public function new(url:String, speed:Int)
	{
		super();
		
		this.speed = speed;
		
		spriteA = new Sprite(Texture.fromImage(url));
		spriteB = new Sprite(Texture.fromImage(url));
		
		spriteB.position.x = 288;
		
		spriteContainer = new DisplayObjectContainer();
		spriteContainer.addChild(spriteA);
		spriteContainer.addChild(spriteB);
		
		addChild(spriteContainer);
	}
	
	public function update():Void
	{
		spriteContainer.position.x -= speed;
		
		if (spriteContainer.position.x < -spriteA.width) spriteContainer.position.x = 0;
	}
}
*/
class MilkGame implements IGame
{
	var gameCore:IGameCore;
	var stage:Stage;
	
	var background:Sprite;
	
	public function new()
	{

	}
	
	public function boot(width:Int, height:Int):Void
	{
		#if js
			gameCore = new milk.pixi.PixiGame();
		#else 
			gameCore = new milk.mono.MonoGame();
		#end
		
		gameCore.create(this, width, height, 0xFFF000);
	}
	
	public function setStage(stage:Stage):Void
	{
		this.stage = stage;
		this.background = new Sprite(Texture.fromImage("assets/Day_Background.png"));
		
		stage.addChild(this.background);
		
		var http = new Http("http://www.timeapi.org/utc/now");
		http.request();
		trace(http.responseData);
	}
	
	public function update(delta:Float):Void
	{
	}
}

