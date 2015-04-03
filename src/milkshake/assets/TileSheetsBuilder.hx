package milkshake.assets;

#if macro
import haxe.macro.Context;
import haxe.macro.Expr;
import sys.FileSystem;
import sys.io.File;

using StringTools;

class TileSheetsBuilder 
{
	public static function build(directory:String):Array<Field>
	{
		var tileSheets:Array<TileSheetsFile> = [];

		var fileNames = FileSystem.readDirectory(directory);

		for (fileName in fileNames)
		{
			if (!FileSystem.isDirectory(directory + fileName) && fileName.indexOf(".png") != -1)
			{
				// push filenames in list. 
				tileSheets.push(new TileSheetsFile(fileName, directory));
			}
		}
		
		var fields:Array<Field> = Context.getBuildFields();

		for (tileSheet in tileSheets)
		{
			fields.push(
			{
				name: tileSheet.name,
				doc: "None",
				access: [ Access.APublic, Access.AStatic ],
				kind: FVar(macro:String, macro $v{tileSheet.value}),
				pos: Context.currentPos()
			});
		}
		
		return fields;
	}
}

class TileSheetsFile
{
	public var name:String;
	public var value:String;
	
	public function new(fileName:String, directory:String)
	{
		this.name = fileName.split(".")[0].toUpperCase();
		this.value = directory.replace("bin", "") + fileName;
	}
}
#end

