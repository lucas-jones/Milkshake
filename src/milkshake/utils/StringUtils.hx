package milkshake.utils;

class StringUtils
{
	public static function template(template:String, values:Array<Dynamic>):String
	{
		for(index in 0 ... values.length)
		{
			template = StringTools.replace(template, '{$index}', values[index]);
		}
		
		return template;
	}
}