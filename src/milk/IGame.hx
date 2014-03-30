package milk;

import pixi.IRenderer;
import pixi.Stage;

interface IGame 
{
	function setStage(stage:Stage):Void;
	function update(delta:Float):Void;
}