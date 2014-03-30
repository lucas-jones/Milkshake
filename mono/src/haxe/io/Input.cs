
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io
{
	public  class Input : global::haxe.lang.HxObject 
	{
		public    Input(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Input()
		{
			unchecked 
			{
				#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
				global::haxe.io.Input.__hx_ctor_haxe_io_Input(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_io_Input(global::haxe.io.Input __temp_me31)
		{
			unchecked 
			{
				#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
				return new global::haxe.io.Input(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
				return new global::haxe.io.Input();
			}
			#line default
		}
		
		
		public virtual   int readByte()
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
				throw global::haxe.lang.HaxeException.wrap("Not implemented");
			}
			#line default
		}
		
		
		public virtual   int readBytes(global::haxe.io.Bytes s, int pos, int len)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
				int k = len;
				byte[] b = s.b;
				if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > s.length ) )) 
				{
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				while (( k > 0 ))
				{
					#line 59 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
					b[pos] = ((byte) (this.readByte()) );
					#line 61 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
					pos++;
					k--;
				}
				
				#line 64 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
				return len;
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
				switch (hash)
				{
					case 243225909:
					{
						#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readBytes"), ((int) (243225909) ))) );
					}
					
					
					case 1763375486:
					{
						#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readByte"), ((int) (1763375486) ))) );
					}
					
					
					default:
					{
						#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
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
				#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
				switch (hash)
				{
					case 243225909:
					{
						#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
						return this.readBytes(((global::haxe.io.Bytes) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
					}
					
					
					case 1763375486:
					{
						#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
						return this.readByte();
					}
					
					
					default:
					{
						#line 28 "C:\\HaxeToolkit\\haxe/std/haxe/io/Input.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
	}
}


