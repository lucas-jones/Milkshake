package milkshake.game.scene;

import milkshake.core.GameObject;
import milkshake.game.scene.component.SceneComponentManager;
import milkshake.IGame;

class Scene extends GameObject
{
	public var game(default, null):IGameCore;
	public var componentManager(default, null):SceneComponentManager;
	
	public function new(game:IGameCore, id:String="undefined-scene") 
	{
		super(id);
		
		this.game = game;
		
		setScene(this);
		
		addNode(componentManager = new SceneComponentManager());
	}
}