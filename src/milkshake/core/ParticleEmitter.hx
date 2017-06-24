package milkshake.core;

import pixi.core.textures.Texture;
import cloudkid.Emitter;

class ParticleEmitter extends DisplayObject
{
	public var emitter(default, null):Emitter;

	public var emitting:Bool = true;

	var elapsed:Date;

	public function new(textures:Array<Texture>, id:String="undefined-particle-emitter", ?config:Dynamic)
	{
		super(id);

		emitter = new Emitter(displayObject, textures, config);
		emitter.emit = true;

		elapsed = Date.now();
	}

	override public function update(delta:Float)
	{
		var now = Date.now();

		if(emitting)
		{
			emitter.update((now.getTime() - elapsed.getTime()) * 0.001);
			elapsed = now;
		}
		super.update(delta);
	}
}
