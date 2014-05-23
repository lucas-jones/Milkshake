package milkshake.game.ui.view;
import js.JQuery;
import milkshake.game.ui.view.AngularViewAttibutes.AngularViewAttributes;

/**
 * ...
 * @author Milkshake-Inc
 */
@:expose
@:build(milkshake.game.ui.view.AngularControllerTransformer.build())
@:autoBuild(milkshake.game.ui.view.AngularControllerTransformer.build())
class AngularViewController<T:AngularViewScope> extends AbstractViewController
{
	
	public var scope(default, null):T;
	public var view(default, null):JQuery;

	public function new(scope:T, view:JQuery, attributes:AngularViewAttributes) 
	{
		super(attributes.id);
		
		this.scope = scope;
		this.view = view;
		
		scope.open = function(?data:Dynamic):Void { open(data); };
		scope.close = function():Void { close(); };
		scope.apply = function():Void
		{
			var phase:String = untyped __js__("scope.$root.$$phase");
			
			if (!(phase == "$apply" || phase == "$digest")) 
			{
				untyped __js__("scope.$apply()");
			}
		};
		scope.isOpen = isOpen;
		scope.game = game;
		scope.controller = this;
		untyped __js__("scope.haxeController = this");
	}
	
	override public function open(?data:Dynamic):Void
	{
		scope.data = data;
		
		super.open(data);
	}
	
	override function set_isOpen(value:Bool):Bool
	{
		var isOpen = super.set_isOpen(value);
		scope.isOpen = isOpen;
		scope.apply();
		return isOpen;
	}
	
}