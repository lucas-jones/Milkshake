package milkshake.game.ui.view;

#if macro
import haxe.macro.Context;
import haxe.macro.Expr;
import haxe.macro.Type;

class AngularControllerTransformer
{
	static inline function VOID():ComplexType
	{
		return TPath({name: "Void", pack: [], params: []});
	}
	
	public static function build():Array<Field>
	{
		var clazz:Ref<ClassType> = Context.getLocalClass();
		var fields:Array<Field> = Context.getBuildFields();
		var pos:Position = Context.currentPos();
		
		var initFunction:Field = {
			name: "__init__",
			access: [AStatic, APublic],
			pos: pos,
			kind: FFun({
				args: [],
				params: [],
				ret: VOID(),
				expr: makeUntypedAssign(
					getStaticField(clazz.get(), "$inject"),
					Context.makeExpr(["$scope", "$element", "$attrs"], pos)
				)
			})
		}
		
		fields.push(initFunction);
		
		return fields;
	}
	
	private static function getStaticField(clazz:ClassType, fieldName:String):Expr
	{
		// Get the full path of the class method  e.g: with fieldName = "whatever" gets ["route", "to", "path", "AnyViewController", "whatever"]
		var fullPath:Array<String> = clazz.pack.concat([clazz.name, fieldName]);
		
		// Generate the expression required e.g.: route.to.path.AnyViewController.whatever
		// or in AST EField(EField(EField(EField(CIdent("route"), "to"), "path"), "AnyViewController"), "whatever")
		var e:Expr = makeId(fullPath[0]);
		for (i in 1...fullPath.length) {
			e = makeField(e, fullPath[i]);
		}
		return e;
	}
	
	private static function makeExpression(exprDef:ExprDef):Expr
	{
		return { expr: exprDef, pos: Context.currentPos() };
	}
	
	private static function makeId(s:String):Expr
	{
		return makeExpression(EConst(CIdent(s)));
	}
	
	private static function makeUntypedAssign(a:Expr, b:Expr):Expr
	{
		var binOpExpr:Expr = makeExpression(EBinop(OpAssign, a, b));
		return makeExpression(EUntyped(binOpExpr));
	}
	
	private static function makeField(e:Expr, field:String):Expr
	{
		return makeExpression(EField(e, field));
	}
}
#end
