
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io
{
	public  class BytesOutput : global::haxe.io.Output 
	{
		public    BytesOutput(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    BytesOutput()
		{
			unchecked 
			{
				#line 32 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				global::haxe.io.BytesOutput.__hx_ctor_haxe_io_BytesOutput(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_io_BytesOutput(global::haxe.io.BytesOutput __temp_me29)
		{
			unchecked 
			{
				#line 32 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				__temp_me29.b = new global::haxe.io.BytesBuffer();
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				return new global::haxe.io.BytesOutput(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				return new global::haxe.io.BytesOutput();
			}
			#line default
		}
		
		
		public  global::haxe.io.BytesBuffer b;
		
		public override   void writeByte(int c)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				this.b.b.WriteByte(((byte) (c) ));
			}
			#line default
		}
		
		
		public override   int writeBytes(global::haxe.io.Bytes buf, int pos, int len)
		{
			unchecked 
			{
				#line 54 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				{
					#line 54 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
					if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > buf.length ) )) 
					{
						#line 54 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
						throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
					}
					
					#line 54 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
					this.b.b.Write(buf.b, pos, len);
				}
				
				#line 56 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				return len;
			}
			#line default
		}
		
		
		public virtual   global::haxe.io.Bytes getBytes()
		{
			unchecked 
			{
				#line 111 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				return this.b.getBytes();
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				switch (hash)
				{
					case 98:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
						this.b = ((global::haxe.io.BytesBuffer) (@value) );
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
						return @value;
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
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
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				switch (hash)
				{
					case 493819893:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBytes"), ((int) (493819893) ))) );
					}
					
					
					case 1381630732:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("writeBytes"), ((int) (1381630732) ))) );
					}
					
					
					case 1238832007:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("writeByte"), ((int) (1238832007) ))) );
					}
					
					
					case 98:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
						return this.b;
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
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
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				switch (hash)
				{
					case 1238832007:case 1381630732:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 493819893:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
						return this.getBytes();
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
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
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				baseArr.push("b");
				#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
				{
					#line 24 "C:\\HaxeToolkit\\haxe/std/haxe/io/BytesOutput.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}


