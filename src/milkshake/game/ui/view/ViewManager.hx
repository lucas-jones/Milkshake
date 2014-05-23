package milkshake.game.ui.view;

/**
 * ...
 * @author Milkshake-Inc
 */
class ViewManager
{
	public var views(default, null):Map<String, AbstractViewController>;

	public function new() 
	{
		views = new Map<String, AbstractViewController>();
	}
	
	public function addView(id:String, view:AbstractViewController):Void
	{
		views.set(id, view);
	}
	
	public function getViewById(id:String): AbstractViewController
	{
		return views.get(id);
	}
}