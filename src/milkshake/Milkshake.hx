package milkshake;

import pixi.Stage;

class Milkshake implements IGame
{
	public var core(default, null):IGameCore;
	public var stage:Stage;
	
	public function new()
	{

	}
	
	public function boot(width:Float, height:Float):Void
	{
		#if js
			core = new milkshake.pixi.PixiGame();
		#else 
			core = new milkshake.mono.MonoGame();
		#end
		
		core.create(this, width, height, 0xc0392b);
	}
	
	public function setStage(stage:Stage):Void
	{
		this.stage = stage;
	}
	
	public function update(delta:Float):Void
	{
	}

}