package milkshake.game.ui.view;

import milkshake.game.MilkshakeGame;

/**
 * ...
 * @author Milkshake-Inc
 */
interface AngularViewScope
{
	public var game:MilkshakeGame;
	public var controller:Dynamic;
    public var open:?Dynamic -> Void;
    public var close:Void -> Void;
	public var isOpen:Bool;
	public var apply:Void -> Void;
	public var data:Dynamic;
}