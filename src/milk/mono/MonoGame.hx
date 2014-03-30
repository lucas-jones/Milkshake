#if cs
package milk.mono;

import milk.IGame;
import milk.mono.MonoGame.GameTime;
import milk.mono.MonoGame.MonoCanvas;
import pixi.Stage;

class MonoGame extends MonoCanvas implements IGameCore
{	
	var game:IGame;
	var stage:Stage;
	
	public function new()
	{
		super();
	}	
	
	public function create(game:IGame, width:Int, height:Int, color:Int):Void
	{
		this.game = game;
		Boot(width, height);
		
		stage = new Stage(color);
		
		Run();
		
		
	}
	
	@:protected
	override public function Draw(gameTime:GameTime):Void 
	{
		Render(stage);
		super.Draw(gameTime);
	}
	
	@:protected
	override public function Update(gameTime:GameTime):Void 
	{
		super.Update(gameTime);
		game.update(1);
	}

	@:protected
	override public function Initialize():Void 
	{
		super.Initialize();
		game.setStage(stage);
	}
}

@:native('PIXI.MonoCanvas')
extern class MonoCanvas
{
  public function new():Void;
  public function Boot(width:Int, height:Int):Void;
  public function Run():Void;
  public function Draw(gameTime:GameTime):Void;
  public function Update(gameTime:GameTime):Void;
  public function Render(stage:Stage):Void;
  public function Initialize():Void;
  
}

@:native('Microsoft.Xna.Framework.GameTime')
extern class GameTime
{
	
}

#end