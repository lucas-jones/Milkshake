package milkshake;

import pixi.Stage;

class Milkshake implements IGame
{
	var gameCore:IGameCore;
	public var stage:Stage;
	
	public function new()
	{
	
	}
	
	public function boot(width:Int, height:Int):Void
	{
		#if js
			gameCore = new milkshake.pixi.PixiGame();
		#else 
			gameCore = new milkshake.mono.MonoGame();
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