package milkshake.game.scene;

import milkshake.core.DisplayObject;
import milkshake.game.scene.Scene;

class SceneManager extends DisplayObject
{
	public var scenes(default, null):Map<String, Scene>;
	public var currentScene(default, null):Scene;
	
	public function new() 
	{
		super("sceneManager");

		scenes = new Map<String, Scene>();
	}
	
	public function addScene(scene:Scene):Void
	{
		scenes.set(scene.id, scene);

		// Default Scene
		if (currentScene == null) changeScene(scene.id);
	}
	
	public function removeScene(sceneId:String):Void
	{
		if(currentScene.id == sceneId)
		{
			removeNode(currentScene.cameras);
			currentScene = null;
		}
		scenes.remove(sceneId);
	}
	
	public function changeScene(sceneId:String):Void
	{
		if(currentScene != null) removeNode(currentScene.cameras);

		currentScene = scenes.get(sceneId);

		scene = currentScene;

		if(currentScene.loader.loaded)
		{
			currentScene.create();
			addNode(currentScene.cameras);
		}
		else
		{
			currentScene.loader.onLoadComplete.bindVoid(function()
			{
				currentScene.create();
				addNode(currentScene.cameras);
			}).destroyOnUse();

			currentScene.loader.load();
		}		
	}

	override public function update(delta:Float):Void
	{
		if(currentScene.loader.loaded) 
		{
			currentScene.update(delta);
		}

		super.update(delta);
	}
}
