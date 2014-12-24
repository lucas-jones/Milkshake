package milkshake.components.spritesheet;

#if macro
import haxe.macro.Context;
import haxe.macro.Expr;
import sys.FileSystem;

class SpriteSheetsdBuilder 
{
	public static function build(directory:String):Array<Field>
	{
		var fileReferences:Array<FileRef> = [];
		var fileNames = FileSystem.readDirectory(directory);
		for (fileName in fileNames)
		{
			if (!FileSystem.isDirectory(directory + fileName))
			{
				// push filenames in list. 
				fileReferences.push(new FileRef(fileName));
			}
		}Float

		var fields:Array<Field> = Context.getBuildFields();
		for (fileRef in fileReferences)
		{
			var spriteSheet = new SpriteSheetAsset();
			// create new fields based on file references!
			fields.push({
					name: fileRef.name,
					doc: fileRef.documentation,
					access: [ Access.APublic, Access.AStatic ],
					kind: FieldType.FVar(macro:SpriteSheetAsset, macro $v{spriteSheet.value}),
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
		this.name = "_" + value.split("-").join("_").split(".").join("__");
		
		// generate documentation
		this.documentation = "Reference to file on disk \"" + value + "\". (auto generated)";
	}
}
#end

class SpriteSheetAsset
{


	public function new()
	{

	}
}
