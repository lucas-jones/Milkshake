package milkshake.game.scene;

import js.JQuery;
import js.JQuery.JqEvent;
import milkshake.core.GameObject;
import milkshake.game.scene.component.SceneComponentManager;
import milkshake.IGame;

class Scene extends GameObject
{
	public var core(default, null):IGameCore;
	public var componentManager(default, null):SceneComponentManager;
	
	public function new(core:IGameCore, id:String="undefined-scene") 
	{
		super(id);
		
		this.core = core;
		
		setScene(this);
		
		addNode(componentManager = new SceneComponentManager());
	}
	
	public function onLoaded():Void
	{
		trace("eeek loaded!");
	}
}