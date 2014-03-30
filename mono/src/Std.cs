
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Std 
{
	public    Std()
	{
		unchecked 
		{
			#line 26 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static   bool @is(object v, object t)
	{
		unchecked 
		{
			#line 29 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			if (global::haxe.lang.Runtime.eq(v, default(object))) 
			{
				return global::haxe.lang.Runtime.eq(t, typeof(object));
			}
			
			if (global::haxe.lang.Runtime.eq(t, default(object))) 
			{
				return false;
			}
			
			global::System.Type clt = ((global::System.Type) (t) );
			if (global::haxe.lang.Runtime.typeEq(clt, default(global::System.Type))) 
			{
				return false;
			}
			
			string name = global::haxe.lang.Runtime.toString(clt);
			#line 38 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			switch (name)
			{
				case "System.Double":
				{
					#line 40 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
					return v is double || v is int;
				}
				
				
				case "System.Int32":
				{
					#line 42 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
					return haxe.lang.Runtime.isInt(v);
				}
				
				
				case "System.Boolean":
				{
					#line 44 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
					return v is bool;
				}
				
				
				case "System.Object":
				{
					#line 46 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
					return true;
				}
				
				
			}
			
			#line 50 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			global::System.Type clv = v.GetType();
			#line 52 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			return clt.IsAssignableFrom(clv);
		}
		#line default
	}
	
	
	public static   string @string(object s)
	{
		unchecked 
		{
			#line 56 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			if (global::haxe.lang.Runtime.eq(s, default(object))) 
			{
				return "null";
			}
			
			if (( s is bool )) 
			{
				return ( (((bool) (s) )) ? ("true") : ("false") );
			}
			
			#line 61 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			return s.ToString();
		}
		#line default
	}
	
	
	public static   global::haxe.lang.Null<int> parseInt(string x)
	{
		unchecked 
		{
			#line 69 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			if (string.Equals(x, default(string))) 
			{
				#line 69 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
				return default(global::haxe.lang.Null<int>);
			}
			
			#line 71 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			int ret = 0;
			int @base = 10;
			int i = -1;
			int len = x.Length;
			#line 76 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			if (( x.StartsWith("0") && ( len > 2 ) )) 
			{
				#line 78 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
				int c = ((int) (global::haxe.lang.Runtime.toInt(x[1])) );
				if (( ( c == 120 ) || ( c == 88 ) )) 
				{
					#line 81 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
					i = 1;
					@base = 16;
				}
				
			}
			
			#line 86 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			bool foundAny = false;
			bool isNeg = false;
			while ((  ++ i < len ))
			{
				#line 90 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
				int c1 = ((int) (global::haxe.lang.Runtime.toInt(x[i])) );
				if ( ! (foundAny) ) 
				{
					switch (c1)
					{
						case 45:
						{
							#line 96 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
							isNeg = true;
							continue;
						}
						
						
						case 32:case 9:case 10:case 13:
						{
							#line 99 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
							if (isNeg) 
							{
								return default(global::haxe.lang.Null<int>);
							}
							
							continue;
						}
						
						
					}
					
				}
				
				#line 105 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
				if (( ( c1 >= 48 ) && ( c1 <= 57 ) )) 
				{
					#line 107 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
					if ((  ! (foundAny)  && ( c1 == 48 ) )) 
					{
						#line 109 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
						foundAny = true;
						continue;
					}
					
					#line 112 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
					ret *= @base;
					#line 112 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
					foundAny = true;
					#line 114 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
					ret += ( c1 - 48 );
				}
				 else 
				{
					if (( @base == 16 )) 
					{
						#line 115 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
						if (( ( c1 >= 97 ) && ( c1 <= 102 ) )) 
						{
							#line 117 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
							ret *= @base;
							#line 117 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
							foundAny = true;
							ret += ( ( c1 - 97 ) + 10 );
						}
						 else 
						{
							if (( ( c1 >= 65 ) && ( c1 <= 70 ) )) 
							{
								ret *= @base;
								#line 120 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
								foundAny = true;
								ret += ( ( c1 - 65 ) + 10 );
							}
							 else 
							{
								break;
							}
							
						}
						
					}
					 else 
					{
						#line 125 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
						break;
					}
					
				}
				
			}
			
			#line 130 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			if (foundAny) 
			{
				return ( (isNeg) ? (new global::haxe.lang.Null<int>( - (ret) , true)) : (new global::haxe.lang.Null<int>(ret, true)) );
			}
			 else 
			{
				#line 133 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
				return default(global::haxe.lang.Null<int>);
			}
			
		}
		#line default
	}
	
	
	public static   int random(int x)
	{
		unchecked 
		{
			#line 238 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
			if (( x <= 0 )) 
			{
				#line 238 "C:\\HaxeToolkit\\haxe/std/cs/_std/Std.hx"
				return 0;
			}
			
			return global::Math.rand.Next(((int) (x) ));
		}
		#line default
	}
	
	
}


