package Milkshake;

import milk.IGame;
import milk.IGameCore;
import pixi.Sprite;
import pixi.Stage;
import pixi.Texture;

class Milkshake implements IGame
{
	var gameCore:IGameCore;
	var stage:Stage;
	
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
	}
	
	public function update(delta:Float):Void
	{
	}
}