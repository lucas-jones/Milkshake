package milkshake.game;

import milkshake.game.scene.Scene;
import milkshake.game.scene.SceneManager;
import milkshake.game.ui.view.AbstractViewController;
import milkshake.game.ui.view.ViewManager;
import milkshake.Milkshake;
import nape.space.Space;
import pixi.Stage;

class MilkshakeGame extends Milkshake
{
	public var sceneManager(default, null):SceneManager;
	
	public var viewManager(default, null):ViewManager;
	
	public static var instance(default, null):MilkshakeGame;
	
	public var isInitialised(default, null):Bool = false;
	
	public function new()
	{
		super();
		instance = this;
		
		sceneManager = new SceneManager();
		viewManager = new ViewManager();
	}
	
	override public function setStage(stage:Stage):Void 
	{
		super.setStage(stage);
		stage.addChild(sceneManager.displayObject);
	}
	
	override public function update(delta:Float):Void 
	{
		super.update(delta);
		
		sceneManager.update(delta);
		viewManager.update(delta);
	}
	
	public function onInitialised():Void
	{
		isInitialised = true;
		
		sceneManager.initialised();
	}
}