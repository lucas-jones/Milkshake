
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class EReg : global::haxe.lang.HxObject 
{
	public    EReg(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    EReg(string r, string opt)
	{
		unchecked 
		{
			#line 31 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			global::EReg.__hx_ctor__EReg(this, r, opt);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__EReg(global::EReg __temp_me5, string r, string opt)
	{
		unchecked 
		{
			#line 32 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			int opts = ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.CultureInvariant) ))) );
			{
				#line 33 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
				int _g1 = 0;
				#line 33 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
				int _g = opt.Length;
				#line 33 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
				while (( _g1 < _g ))
				{
					#line 33 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					int i = _g1++;
					{
						#line 34 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
						int _g2 = ((int) (opt[i]) );
						#line 34 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
						switch (_g2)
						{
							case 105:
							{
								#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
								opts |= ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.IgnoreCase) ))) );
								#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
								break;
							}
							
							
							case 103:
							{
								#line 38 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
								__temp_me5.isGlobal = true;
								#line 38 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
								break;
							}
							
							
							case 109:
							{
								#line 40 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
								opts |= ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.Multiline) ))) );
								#line 40 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
								break;
							}
							
							
							case 99:
							{
								#line 42 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
								opts |= ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.Compiled) ))) );
								#line 42 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
								break;
							}
							
							
						}
						
					}
					
				}
				
			}
			
			#line 47 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			__temp_me5.regex = new global::System.Text.RegularExpressions.Regex(global::haxe.lang.Runtime.toString(r), ((global::System.Text.RegularExpressions.RegexOptions) (((object) (opts) )) ));
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			return new global::EReg(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			return new global::EReg(global::haxe.lang.Runtime.toString(arr[0]), global::haxe.lang.Runtime.toString(arr[1]));
		}
		#line default
	}
	
	
	public  global::System.Text.RegularExpressions.Regex regex;
	
	public  global::System.Text.RegularExpressions.Match m;
	
	public  bool isGlobal;
	
	public  string cur;
	
	public virtual   bool match(string s)
	{
		unchecked 
		{
			#line 51 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			this.m = this.regex.Match(global::haxe.lang.Runtime.toString(s));
			this.cur = s;
			return this.m.Success;
		}
		#line default
	}
	
	
	public virtual   string matched(int n)
	{
		unchecked 
		{
			#line 57 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			if (( ( this.m == default(global::System.Text.RegularExpressions.Match) ) || ( ((uint) (n) ) > this.m.Groups.Count ) )) 
			{
				throw global::haxe.lang.HaxeException.wrap("EReg::matched");
			}
			
			if ( ! (this.m.Groups[n].Success) ) 
			{
				#line 59 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
				return default(string);
			}
			
			return this.m.Groups[n].Value;
		}
		#line default
	}
	
	
	public virtual   object matchedPos()
	{
		unchecked 
		{
			#line 71 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			return new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{}), new global::Array<object>(new object[]{}), new global::Array<int>(new int[]{5393365, 5594516}), new global::Array<double>(new double[]{((double) (this.m.Length) ), ((double) (this.m.Index) )}));
		}
		#line default
	}
	
	
	public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
	{
		unchecked 
		{
			#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			switch (hash)
			{
				case 4949376:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					this.cur = global::haxe.lang.Runtime.toString(@value);
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return @value;
				}
				
				
				case 1821933:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					this.isGlobal = ((bool) (@value) );
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return @value;
				}
				
				
				case 109:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					this.m = ((global::System.Text.RegularExpressions.Match) (@value) );
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return @value;
				}
				
				
				case 1723805383:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					this.regex = ((global::System.Text.RegularExpressions.Regex) (@value) );
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return @value;
				}
				
				
				default:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return base.__hx_setField(field, hash, @value, handleProperties);
				}
				
			}
			
		}
		#line default
	}
	
	
	public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
	{
		unchecked 
		{
			#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			switch (hash)
			{
				case 1271070480:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("matchedPos"), ((int) (1271070480) ))) );
				}
				
				
				case 159136996:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("matched"), ((int) (159136996) ))) );
				}
				
				
				case 52644165:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("match"), ((int) (52644165) ))) );
				}
				
				
				case 4949376:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return this.cur;
				}
				
				
				case 1821933:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return this.isGlobal;
				}
				
				
				case 109:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return this.m;
				}
				
				
				case 1723805383:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return this.regex;
				}
				
				
				default:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
				}
				
			}
			
		}
		#line default
	}
	
	
	public override   object __hx_invokeField(string field, int hash, global::Array dynargs)
	{
		unchecked 
		{
			#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			switch (hash)
			{
				case 1271070480:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return this.matchedPos();
				}
				
				
				case 159136996:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return this.matched(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
				}
				
				
				case 52644165:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return this.match(global::haxe.lang.Runtime.toString(dynargs[0]));
				}
				
				
				default:
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
					return base.__hx_invokeField(field, hash, dynargs);
				}
				
			}
			
		}
		#line default
	}
	
	
	public override   void __hx_getFields(global::Array<object> baseArr)
	{
		unchecked 
		{
			#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			baseArr.push("cur");
			#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			baseArr.push("isGlobal");
			#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			baseArr.push("m");
			#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			baseArr.push("regex");
			#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
			{
				#line 24 "C:\\HaxeToolkit\\haxe/std/cs/_std/EReg.hx"
				base.__hx_getFields(baseArr);
			}
			
		}
		#line default
	}
	
	
}


