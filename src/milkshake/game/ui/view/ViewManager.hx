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
	
	public function getView<T : AbstractViewController>(id:String): T
	{
		var t:T;
		var view:AbstractViewController = views.get(id);
		return t = cast view;
	}
}