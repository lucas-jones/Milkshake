#if js
package milkshake.pixi;

import js.Browser;
import js.html.Element;
import milkshake.IGame;
import milkshake.input.IKeyboardInput;
import milkshake.input.PixiInput;
import pixi.IRenderer;
import pixi.Pixi;
import pixi.Stage;

class PixiGame implements IGameCore
{	
	public var input(default, null):IKeyboardInput;
	
	var game:IGame;
	
	var canvas:Element;
	var stage:Stage;
	var renderer:IRenderer;
		
	public function new()
	{
		canvas = js.Browser.document.getElementById("gameCanvas");
		input = new PixiInput();
	}
	
	public function create(game:IGame, width:Float, height:Float, color:Int):Void
	{
		this.game = game;
		untyped this.canvas.width = width;
		untyped this.canvas.height = height;
		
		stage = new Stage(color);
		game.setStage(stage);
		
		renderer = Pixi.autoDetectRenderer(width, height, canvas);
		
		untyped
		{
			Browser.window.gl = renderer.renderSession.gl;
			
			gl.texParameteri(gl.TEXTURE_2D, gl.TEXTURE_WRAP_S, gl.REPEAT);
			gl.texParameteri(gl.TEXTURE_2D, gl.TEXTURE_WRAP_T, gl.REPEAT);
		}
		
		Browser.window.requestAnimationFrame(render);	
	}
	
	public function render(deltaTime:Float):Bool
	{
		Browser.window.requestAnimationFrame(render);
		
		game.update(deltaTime);
		input.update();
		
		renderer.render(stage);
		
		return true;
	}
}
#end