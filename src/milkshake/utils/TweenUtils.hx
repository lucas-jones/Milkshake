package milkshake.utils;

import milkshake.core.Entity;
import motion.Actuate;
import motion.actuators.IGenericActuator;

class TweenUtils
{
	public static inline function tween(target:Dynamic, duration:Float, properties:Dynamic):IGenericActuator
	{
		return Actuate.tween(target, duration, properties);
	}

	public static inline function tweenFrom(target:Dynamic, duration:Float, properties:Dynamic):IGenericActuator
	{
		var currentVariables = {};

		for(property in Reflect.fields(properties)) {
			Reflect.setField(currentVariables, property, Reflect.getProperty(target, property));
		}

		for(property in Reflect.fields(properties)) {
			Reflect.setProperty(target, property, Reflect.field(properties, property));
		}

		return Actuate.tween(target, duration, currentVariables);
	}
}