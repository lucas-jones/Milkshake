package milkshake.utils;

import milkshake.core.Entity;
import motion.actuators.IGenericActuator;

class TweenUtils
{
	public static inline function tween(target:Entity, duration:Float, properties:Dynamic):IGenericActuator
	{
		return motion.Actuate.tween(target, duration, properties);
	}
}