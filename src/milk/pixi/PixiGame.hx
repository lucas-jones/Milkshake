#if js
package milk.pixi;

import js.Browser;
import js.html.Element;
import milk.IGame;
import milk.IGameCore;
import pixi.IRenderer;
import pixi.Pixi;
import pixi.Stage;

class PixiGame implements IGameCore
{	
	var game:IGame;
	
	var canvas:Element;
	var stage:Stage;
	var renderer:IRenderer;
		
	public function new()
	{
		canvas = js.Browser.document.getElementById("gameCanvas");
	}
	
	public function create(game:IGame, width:Int, height:Int, color:Int):Void
	{
		this.game = game;
		untyped this.canvas.width = width;
		untyped this.canvas.height = height;
		
		stage = new Stage(color);
		game.setStage(stage);
		
		renderer = Pixi.autoDetectRenderer(width, height, canvas);
		
		Browser.window.requestAnimationFrame(render);	
	}
	
	public function render(deltaTime:Float):Bool
	{
		Browser.window.requestAnimationFrame(render);
		
		game.update(deltaTime);
		renderer.render(stage);
		
		return true;
	}
}
#end