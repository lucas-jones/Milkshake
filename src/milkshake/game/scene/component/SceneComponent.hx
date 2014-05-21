package milkshake.game.scene.component;

import milkshake.core.Node;
import milkshake.core.Entity;
import milkshake.game.scene.Scene;

class SceneComponent extends Entity
{
	public function new(id:String="undefined-entity") 
	{
		super(id);
	}
	
	override public function setScene(scene:Scene):Void 
	{
		super.setScene(scene);
		
		scene.onNodeAdded.bind(nodeAdded);
	}
	
	function nodeAdded(node:Node):Void
	{
		
	}
	
	public function setup(scene:Scene)
	{
		this.scene = scene;
	}	
}