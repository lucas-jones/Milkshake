package milkshake.assets.loader;

import hsl.haxe.DirectSignaler;
import hsl.haxe.Signaler.Signaler;
import pixi.loaders.Loader;
import pixi.loaders.ResourceLoader;

using Lambda;

class AssetLoader
{
	public var onLoadStarted(default, null):Signaler<Dynamic>;
	public var onLoadUpdate(default, null):Signaler<Dynamic>;
	public var onLoadComplete(default, null):Signaler<Dynamic>;

	public var loaded(default, null):Bool;

	var loader:Loader;

	public function new(urls:Array<String>, autoLoad:Bool = false)
	{
		loader = new Loader();
		for(url in urls) loader.add(url, url);

		loaded = urls.length == 0;

		onLoadStarted = new DirectSignaler(this);
		onLoadUpdate = new DirectSignaler(this);
		onLoadComplete = new DirectSignaler(this);

		if(autoLoad) load();
	}

	public function load():Void
	{
		onLoadStarted.dispatch(this);

		loader.once("complete", handleLoaded);

		loader.load();
	}

	function handleLoaded():Void
	{
		loaded = true;
		onLoadComplete.dispatch(this);
	}
}