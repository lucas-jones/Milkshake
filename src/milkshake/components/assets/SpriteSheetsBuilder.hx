package milkshake.components.assets;

#if macro
import haxe.macro.Context;
import haxe.macro.Expr;
import sys.FileSystem;

class SpriteSheetsBuilder 
{
	public static function build(directory:String):Array<Field>
	{
		var fileReferences:Array<FileRef> = [];
		var fileNames = FileSystem.readDirectory(directory);

		for (fileName in fileNames)
		{
			if (!FileSystem.isDirectory(directory + fileName) && fileName.indexOf(".json") != -1)
			{
				// push filenames in list. 
				fileReferences.push(new FileRef(fileName));
			}
		}
		
		var fields:Array<Field> = Context.getBuildFields();
		for (fileRef in fileReferences)
		{
			// create new fields based on file references!
			fields.push({
					name: fileRef.name.toUpperCase(),
					doc: fileRef.documentation,
					access: [Access.APublic, Access.AStatic, Access.AInline],
					kind: FieldType.FVar(macro:String, macro $v{fileRef.value}),
					pos: Context.currentPos()
				});
		}
		
		return fields;
	}
}

class FileRef
{
	public var name:String;
	public var value:String;
	public var documentation:String;
	
	public function new(value:String)
	{
		this.value = value;
		
		// replace forbidden characters to underscores, since variables cannot use these symbols.
		this.name = value.split("-").join("_").split(".")[0];
		
		// generate documentation
		this.documentation = "Reference to file on disk \"" + value + "\". (auto generated)";
	}
}
#end

