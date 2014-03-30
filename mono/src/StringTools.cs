
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class StringTools : global::haxe.lang.HxObject 
{
	public    StringTools(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 32 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    StringTools()
	{
		unchecked 
		{
			#line 32 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			global::StringTools.__hx_ctor__StringTools(this);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__StringTools(global::StringTools __temp_me10)
	{
		unchecked 
		{
			#line 32 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static   string urlEncode(string s)
	{
		unchecked 
		{
			#line 37 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return System.Uri.EscapeUriString(s);
		}
		#line default
	}
	
	
	public static   string urlDecode(string s)
	{
		unchecked 
		{
			#line 62 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return System.Uri.UnescapeDataString(s);
		}
		#line default
	}
	
	
	public static   string htmlEscape(string s, global::haxe.lang.Null<bool> quotes)
	{
		unchecked 
		{
			#line 96 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			s = global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "&").@join("&amp;"), "<").@join("&lt;"), ">").@join("&gt;");
			return ( ((quotes).@value) ? (global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "\"").@join("&quot;"), "\'").@join("&#039;")) : (s) );
		}
		#line default
	}
	
	
	public static   string htmlUnescape(string s)
	{
		unchecked 
		{
			#line 113 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "&gt;").@join(">"), "&lt;").@join("<"), "&quot;").@join("\""), "&#039;").@join("\'"), "&amp;").@join("&");
		}
		#line default
	}
	
	
	public static   bool startsWith(string s, string start)
	{
		unchecked 
		{
			#line 124 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return s.StartsWith(start);
		}
		#line default
	}
	
	
	public static   bool endsWith(string s, string end)
	{
		unchecked 
		{
			#line 141 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return s.EndsWith(end);
		}
		#line default
	}
	
	
	public static   bool isSpace(string s, int pos)
	{
		unchecked 
		{
			#line 163 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			global::haxe.lang.Null<int> c = global::haxe.lang.StringExt.charCodeAt(s, pos);
			return ( ( ( c.@value > 8 ) && ( c.@value < 14 ) ) || global::haxe.lang.Runtime.eq((c).toDynamic(), 32) );
		}
		#line default
	}
	
	
	public static   string ltrim(string s)
	{
		unchecked 
		{
			#line 176 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return s.TrimStart();
		}
		#line default
	}
	
	
	public static   string rtrim(string s)
	{
		unchecked 
		{
			#line 201 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return s.TrimEnd();
		}
		#line default
	}
	
	
	public static   string trim(string s)
	{
		unchecked 
		{
			#line 223 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return s.Trim();
		}
		#line default
	}
	
	
	public static   string lpad(string s, string c, int l)
	{
		unchecked 
		{
			#line 246 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			if (( c.Length <= 0 )) 
			{
				return s;
			}
			
			#line 249 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			while (( s.Length < l ))
			{
				#line 249 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
				s = global::haxe.lang.Runtime.concat(c, s);
			}
			
			#line 252 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return s;
		}
		#line default
	}
	
	
	public static   string rpad(string s, string c, int l)
	{
		unchecked 
		{
			#line 268 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			if (( c.Length <= 0 )) 
			{
				return s;
			}
			
			#line 271 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			while (( s.Length < l ))
			{
				#line 271 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
				s = global::haxe.lang.Runtime.concat(s, c);
			}
			
			#line 274 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return s;
		}
		#line default
	}
	
	
	public static   string replace(string s, string sub, string @by)
	{
		unchecked 
		{
			#line 288 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			if (( sub.Length == 0 )) 
			{
				#line 296 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
				return global::haxe.lang.StringExt.split(s, sub).@join(@by);
			}
			 else 
			{
				#line 298 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
				return s.Replace(sub, @by);
			}
			
		}
		#line default
	}
	
	
	public static   string hex(int n, global::haxe.lang.Null<int> digits)
	{
		unchecked 
		{
			#line 316 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			string s = "";
			string hexChars = "0123456789ABCDEF";
			do 
			{
				s = global::haxe.lang.Runtime.concat(global::haxe.lang.StringExt.charAt(hexChars, ( n & 15 )), s);
				n = ((int) (( ((uint) (n) ) >> 4 )) );
			}
			while (( n > 0 ));
			#line 323 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			if (( ! (global::haxe.lang.Runtime.eq((digits).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) )) 
			{
				while (( s.Length < digits.@value ))
				{
					s = global::haxe.lang.Runtime.concat("0", s);
				}
				
			}
			
			return s;
		}
		#line default
	}
	
	
	public static   int fastCodeAt(string s, int index)
	{
		unchecked 
		{
			#line 339 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return ( (( ((uint) (index) ) < s.Length )) ? (((int) (global::haxe.lang.Runtime.toInt(s[index])) )) : (-1) );
		}
		#line default
	}
	
	
	public static   bool isEof(int c)
	{
		unchecked 
		{
			#line 366 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return ( c == -1 );
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 32 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return new global::StringTools(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 32 "C:\\HaxeToolkit\\haxe/std/StringTools.hx"
			return new global::StringTools();
		}
		#line default
	}
	
	
}


