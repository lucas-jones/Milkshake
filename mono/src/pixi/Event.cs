
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pixi
{
	public  class Event<T> : global::haxe.lang.HxObject, global::pixi.Event 
	{
		public    Event(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 3 "src/pixi/Event.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Event()
		{
			unchecked 
			{
				#line 3 "src/pixi/Event.hx"
				global::pixi.Event<object>.__hx_ctor_pixi_Event<T>(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pixi_Event<T2>(global::pixi.Event<T2> __temp_me32)
		{
			unchecked 
			{
				#line 3 "src/pixi/Event.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   object __hx_cast<T3>(global::pixi.Event me)
		{
			unchecked 
			{
				#line 3 "src/pixi/Event.hx"
				return ( (( me != default(global::pixi.Event) )) ? (me.pixi_Event_cast<T3>()) : (default(global::pixi.Event)) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 3 "src/pixi/Event.hx"
				return new global::pixi.Event<object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 3 "src/pixi/Event.hx"
				return new global::pixi.Event<object>();
			}
			#line default
		}
		
		
		public virtual   object pixi_Event_cast<T1>()
		{
			unchecked 
			{
				#line 3 "src/pixi/Event.hx"
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T1))) 
				{
					#line 3 "src/pixi/Event.hx"
					return this;
				}
				
				#line 3 "src/pixi/Event.hx"
				global::pixi.Event<T1> new_me = new global::pixi.Event<T1>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				#line 3 "src/pixi/Event.hx"
				{
					#line 3 "src/pixi/Event.hx"
					object __temp_iterator42 = global::Reflect.fields(this).iterator();
					#line 3 "src/pixi/Event.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator42, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 3 "src/pixi/Event.hx"
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator42, "next", 1224901875, default(global::Array)));
						#line 3 "src/pixi/Event.hx"
						switch (field)
						{
							default:
							{
								#line 3 "src/pixi/Event.hx"
								global::Reflect.setField(new_me, field, ((object) (global::Reflect.field(this, field)) ));
								#line 3 "src/pixi/Event.hx"
								break;
							}
							
						}
						
					}
					
				}
				
				#line 3 "src/pixi/Event.hx"
				return new_me;
			}
			#line default
		}
		
		
		public  string type;
		
		public  T content;
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 3 "src/pixi/Event.hx"
				switch (hash)
				{
					case 427265337:
					{
						#line 3 "src/pixi/Event.hx"
						this.content = global::haxe.lang.Runtime.genericCast<T>(((object) (@value) ));
						#line 3 "src/pixi/Event.hx"
						return @value;
					}
					
					
					default:
					{
						#line 3 "src/pixi/Event.hx"
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
				#line 3 "src/pixi/Event.hx"
				switch (hash)
				{
					case 427265337:
					{
						#line 3 "src/pixi/Event.hx"
						this.content = global::haxe.lang.Runtime.genericCast<T>(@value);
						#line 3 "src/pixi/Event.hx"
						return @value;
					}
					
					
					case 1292432058:
					{
						#line 3 "src/pixi/Event.hx"
						this.type = global::haxe.lang.Runtime.toString(@value);
						#line 3 "src/pixi/Event.hx"
						return @value;
					}
					
					
					default:
					{
						#line 3 "src/pixi/Event.hx"
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
				#line 3 "src/pixi/Event.hx"
				switch (hash)
				{
					case 427265337:
					{
						#line 3 "src/pixi/Event.hx"
						return this.content;
					}
					
					
					case 1292432058:
					{
						#line 3 "src/pixi/Event.hx"
						return this.type;
					}
					
					
					default:
					{
						#line 3 "src/pixi/Event.hx"
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
				#line 3 "src/pixi/Event.hx"
				switch (hash)
				{
					case 427265337:
					{
						#line 3 "src/pixi/Event.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (this.content) ))) );
					}
					
					
					default:
					{
						#line 3 "src/pixi/Event.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 3 "src/pixi/Event.hx"
				baseArr.push("content");
				#line 3 "src/pixi/Event.hx"
				baseArr.push("type");
				#line 3 "src/pixi/Event.hx"
				{
					#line 3 "src/pixi/Event.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pixi
{
	public  interface Event : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject 
	{
		   object pixi_Event_cast<T1>();
		
	}
}


