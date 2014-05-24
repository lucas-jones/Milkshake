package milkshake.game.scene;
import milkshake.core.GameObject;
class SceneManager extends GameObject
{
	public var scenes(default, null):Map<String, Scene>;
	public var currentScene(get, null):Scene;
	public var currentSceneKey(default, null):String;
	
	public function new() 
	{
		super("sceneManager");
		scenes = new Map<String, Scene>();
		currentSceneKey = null;
	}
	
	public function addScene(key:String, scene:Scene):Void
	{
		scenes.set(key, scene);
		
		if (currentSceneKey == null) changeScene(key);
	}
	
	public function removeScene(key:String):Void
	{
		scenes.remove(key);
	}
	
	public function initialised():Void
	{
		for (key in scenes.keys())
		{
			scenes.get(key).onLoaded();
		}
	}
	
	public function changeScene(key:String):Void
	{
		removeNode(currentScene);
		currentSceneKey = key;
		addNode(currentScene);
	}
	
	public function get_currentScene():Scene
	{
		return scenes.get(currentSceneKey);
	}
	
	override public function update(deltaTime:Float):Void 
	{
		if(currentScene != null) currentScene.update(deltaTime);
		super.update(deltaTime);
	}
}