
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io
{
	public  class Bytes : global::haxe.lang.HxObject 
	{
		public    Bytes(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Bytes(int length, byte[] b)
		{
			unchecked 
			{
				#line 29 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				global::haxe.io.Bytes.__hx_ctor_haxe_io_Bytes(this, length, b);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_io_Bytes(global::haxe.io.Bytes __temp_me26, int length, byte[] b)
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				__temp_me26.length = length;
				__temp_me26.b = b;
			}
			#line default
		}
		
		
		public static   global::haxe.io.Bytes alloc(int length)
		{
			unchecked 
			{
				#line 250 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				return new global::haxe.io.Bytes(((int) (length) ), ((byte[]) (new byte[((int) (length) )]) ));
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				return new global::haxe.io.Bytes(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				return new global::haxe.io.Bytes(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((byte[]) (arr[1]) ));
			}
			#line default
		}
		
		
		public  int length;
		
		public  byte[] b;
		
		public virtual   global::haxe.io.Bytes sub(int pos, int len)
		{
			unchecked 
			{
				#line 101 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > this.length ) )) 
				{
					#line 101 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				#line 117 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				byte[] newarr = new byte[((int) (len) )];
				global::System.Array.Copy(this.b, pos, newarr, 0, len);
				return new global::haxe.io.Bytes(((int) (len) ), ((byte[]) (newarr) ));
			}
			#line default
		}
		
		
		public virtual   string toString()
		{
			unchecked 
			{
				#line 211 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				return global::System.Text.Encoding.UTF8.GetString(this.b, 0, this.length);
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				switch (hash)
				{
					case 520590566:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						this.length = ((int) (@value) );
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return @value;
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				switch (hash)
				{
					case 98:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						this.b = ((byte[]) (@value) );
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return @value;
					}
					
					
					case 520590566:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						this.length = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return @value;
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
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
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				switch (hash)
				{
					case 946786476:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("toString"), ((int) (946786476) ))) );
					}
					
					
					case 5745024:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("sub"), ((int) (5745024) ))) );
					}
					
					
					case 98:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return this.b;
					}
					
					
					case 520590566:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return this.length;
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				switch (hash)
				{
					case 520590566:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return ((double) (this.length) );
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				switch (hash)
				{
					case 946786476:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return this.toString();
					}
					
					
					case 5745024:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
						return this.sub(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
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
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				baseArr.push("b");
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				baseArr.push("length");
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/Bytes.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
		public override string ToString()
		{
			return this.toString();
		}
		
		
	}
}


