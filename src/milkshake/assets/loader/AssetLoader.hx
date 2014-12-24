package milkshake.assets.loader;

import hsl.haxe.DirectSignaler;
import hsl.haxe.Signaler.Signaler;

class AssetLoader
{
	public var onLoadStarted(default, null):Signaler<Void>;
	public var onLoadUpdate(default, null):Signaler<Void>;
	public var onLoadComplete(default, null):Signaler<Void>;

	public var loaded(default, null):Bool;

	var loader:pixi.AssetLoader;

	public function new(urls:Array<String>, autoLoad:Bool = false)
	{
		loader = new pixi.AssetLoader(urls);
		loaded = false;

		onLoadStarted = new DirectSignaler(this);
		onLoadUpdate = new DirectSignaler(this);
		onLoadComplete = new DirectSignaler(this);

		if(autoLoad) load();
	}

	public function load():Void
	{
		onLoadStarted.dispatch(this);

		loader.onComplete = handleLoaded;

		loader.load();
	}

	function handleLoaded():Void
	{
		loaded = true;
		onLoadComplete.dispatch(this);
	}
}