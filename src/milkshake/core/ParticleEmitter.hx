package milkshake.core;

import pixi.core.textures.Texture;
import cloudkid.Emitter;

class ParticleEmitter extends DisplayObject
{
	public var emitter(default, null):Emitter;

	public var emitting:Bool = true;

	public function new(?textures:Array<Texture>, id:String="undefined-particle-emitter", ?config:Dynamic)
	{
		super(id);

		emitter = new Emitter(displayObject, textures, config);
	}

	override public function update(delta:Float)
	{
		if(emitting)
		{
			emitter.update(delta);
		}
		super.update(delta);
	}
}
