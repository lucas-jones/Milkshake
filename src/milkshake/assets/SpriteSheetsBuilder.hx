package milkshake.assets;

#if macro
import haxe.macro.Context;
import haxe.macro.Expr;
import sys.FileSystem;
import sys.io.File;

using StringTools;

class SpriteSheetsBuilder
{
	public static function build(directory:String):Array<Field>
	{
		var spriteSheets:Array<SpriteSheetsFile> = [];

		var fileNames = FileSystem.readDirectory(directory);

		for (fileName in fileNames)
		{
			if (!FileSystem.isDirectory(directory + fileName) && fileName.indexOf(".json") != -1)
			{
				// push filenames in list.
				spriteSheets.push(new SpriteSheetsFile(fileName, directory));
			}
		}

		var fields:Array<Field> = Context.getBuildFields();

		for (spriteSheet in spriteSheets)
		{
			fields.push(
			{
				name: spriteSheet.name,
				doc: "None",
				access: [ Access.APublic, Access.AStatic ],
				kind: FVar(macro:String, macro $v{spriteSheet.value}),
				pos: Context.currentPos()
			});
		}

		return fields;
	}
}

class SpriteSheetsFile
{
	public var name:String;
	public var value:String;

	public function new(fileName:String, directory:String)
	{
		this.name = fileName.split(".")[0].toUpperCase();
		this.value = directory.replace("bin/", "") + fileName;
	}
}
#end

