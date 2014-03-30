
#pragma warning disable 109, 114, 219, 429, 168, 162
public sealed class Array<T> : global::haxe.lang.HxObject, global::Array 
{
	
	public Array(T[] native)
	{
		this.__a = native;
		this.length = native.Length;
	}
	public    Array(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    Array()
	{
		unchecked 
		{
			#line 64 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			global::Array<object>.__hx_ctor__Array<T>(this);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__Array<T2>(global::Array<T2> __temp_me4)
	{
		unchecked 
		{
			#line 66 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			__temp_me4.length = 0;
			__temp_me4.__a = new T2[((int) (0) )];
		}
		#line default
	}
	
	
	public static   object __hx_cast<T3>(global::Array me)
	{
		unchecked 
		{
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return ( (( me != default(global::Array) )) ? (me.Array_cast<T3>()) : (default(global::Array)) );
		}
		#line default
	}
	
	
	public static   global::Array<X> ofNative<X>(X[] native)
	{
		
			return new Array<X>(native);
	
	}
	
	
	public static   global::Array<Y> alloc<Y>(int size)
	{
		
			return new Array<Y>(new Y[size]);
	
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return new global::Array<object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return new global::Array<object>();
		}
		#line default
	}
	
	
	public   object Array_cast<T1>()
	{
		unchecked 
		{
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T1))) 
			{
				#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				return this;
			}
			
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			global::Array<T1> new_me = new global::Array<T1>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			{
				#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				object __temp_iterator33 = global::Reflect.fields(this).iterator();
				#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator33, "hasNext", 407283053, default(global::Array))) ))
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator33, "next", 1224901875, default(global::Array)));
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					switch (field)
					{
						case "__a":
						{
							#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
							{
								#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
								T1[] __temp_new_arr1 = new T1[((int) (this.__a.Length) )];
								#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
								int __temp_i2 = -1;
								#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
								while ((  ++ __temp_i2 < this.__a.Length ))
								{
									#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
									object __temp_obj3 = ((object) (this.__a[__temp_i2]) );
									#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
									if ( ! (global::haxe.lang.Runtime.eq(__temp_obj3, default(T[]))) ) 
									{
										#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
										__temp_new_arr1[__temp_i2] = global::haxe.lang.Runtime.genericCast<T1>(__temp_obj3);
									}
									
								}
								
								#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
								new_me.__a = __temp_new_arr1;
							}
							
							#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
							break;
						}
						
						
						default:
						{
							#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
							global::Reflect.setField(new_me, field, ((object) (global::Reflect.field(this, field)) ));
							#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
							break;
						}
						
					}
					
				}
				
			}
			
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return new_me;
		}
		#line default
	}
	
	
	public  int length;
	
	public  T[] __a;
	
	public   global::Array<T> concat(global::Array<T> a)
	{
		unchecked 
		{
			#line 75 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			int len = ( this.length + a.length );
			T[] retarr = new T[((int) (len) )];
			global::System.Array.Copy(this.__a, 0, retarr, 0, this.length);
			global::System.Array.Copy(a.__a, 0, retarr, this.length, a.length);
			#line 80 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return global::Array<object>.ofNative<T>(retarr);
		}
		#line default
	}
	
	
	public   void concatNative(T[] a)
	{
		unchecked 
		{
			#line 85 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			T[] __a = this.__a;
			int len = ( this.length + a.Length );
			if (( __a.Length >= len )) 
			{
				global::System.Array.Copy(a, 0, __a, this.length, this.length);
			}
			 else 
			{
				#line 91 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				T[] newarr = new T[((int) (len) )];
				global::System.Array.Copy(__a, 0, newarr, 0, this.length);
				global::System.Array.Copy(a, 0, newarr, this.length, a.Length);
				#line 95 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				this.__a = newarr;
			}
			
			#line 98 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			this.length = len;
		}
		#line default
	}
	
	
	public   string @join(string sep)
	{
		unchecked 
		{
			#line 106 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			global::StringBuf buf = new global::StringBuf();
			int i = -1;
			#line 109 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			bool first = true;
			int length = this.length;
			while ((  ++ i < length ))
			{
				#line 113 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				if (first) 
				{
					first = false;
				}
				 else 
				{
					#line 116 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					buf.b.Append(((object) (global::Std.@string(sep)) ));
				}
				
				buf.b.Append(((object) (global::Std.@string(this.__a[i])) ));
			}
			
			#line 120 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return buf.toString();
		}
		#line default
	}
	
	
	public   global::haxe.lang.Null<T> pop()
	{
		unchecked 
		{
			#line 128 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			T[] __a = this.__a;
			int length = this.length;
			if (( length > 0 )) 
			{
				#line 132 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				T val = __a[ -- length];
				__a[length] = default(T);
				this.length = length;
				#line 136 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				return new global::haxe.lang.Null<T>(val, true);
			}
			 else 
			{
				return default(global::haxe.lang.Null<T>);
			}
			
		}
		#line default
	}
	
	
	public   int push(T x)
	{
		unchecked 
		{
			#line 147 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (( this.length >= this.__a.Length )) 
			{
				#line 149 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				int newLen = ( (( this.length << 1 )) + 1 );
				T[] newarr = new T[((int) (newLen) )];
				this.__a.CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
				#line 153 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				this.__a = newarr;
			}
			
			#line 156 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			this.__a[this.length] = x;
			return  ++ this.length;
		}
		#line default
	}
	
	
	public   void reverse()
	{
		unchecked 
		{
			#line 165 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			int i = 0;
			int l = this.length;
			T[] a = this.__a;
			int half = ( l >> 1 );
			l -= 1;
			while (( i < half ))
			{
				#line 172 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				T tmp = a[i];
				a[i] = a[( l - i )];
				a[( l - i )] = tmp;
				i += 1;
			}
			
		}
		#line default
	}
	
	
	public   global::haxe.lang.Null<T> shift()
	{
		unchecked 
		{
			#line 184 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			int l = this.length;
			if (( l == 0 )) 
			{
				return default(global::haxe.lang.Null<T>);
			}
			
			#line 188 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			T[] a = this.__a;
			T x = a[0];
			l -= 1;
			global::System.Array.Copy(a, 1, a, 0, ( this.length - 1 ));
			a[l] = default(T);
			this.length = l;
			#line 195 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return new global::haxe.lang.Null<T>(x, true);
		}
		#line default
	}
	
	
	public   global::Array<T> slice(int pos, global::haxe.lang.Null<int> end)
	{
		unchecked 
		{
			#line 206 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (( pos < 0 )) 
			{
				pos = ( this.length + pos );
				if (( pos < 0 )) 
				{
					pos = 0;
				}
				
			}
			
			#line 211 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (global::haxe.lang.Runtime.eq((end).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) 
			{
				end = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(this.length, true).@value, true);
			}
			 else 
			{
				if (( end.@value < 0 )) 
				{
					end = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(( this.length + end.@value ), true).@value, true);
				}
				
			}
			
			if (( end.@value > this.length )) 
			{
				end = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(this.length, true).@value, true);
			}
			
			int len = ( end.@value - pos );
			if (( len < 0 )) 
			{
				#line 218 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				return new global::Array<T>();
			}
			
			#line 220 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			T[] newarr = new T[((int) (len) )];
			global::System.Array.Copy(this.__a, pos, newarr, 0, len);
			#line 223 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return global::Array<object>.ofNative<T>(newarr);
		}
		#line default
	}
	
	
	public   void sort(global::haxe.lang.Function f)
	{
		unchecked 
		{
			#line 233 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (( this.length == 0 )) 
			{
				return ;
			}
			
			this.quicksort(0, ( this.length - 1 ), f);
		}
		#line default
	}
	
	
	public   void quicksort(int lo, int hi, global::haxe.lang.Function f)
	{
		unchecked 
		{
			#line 244 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			T[] buf = this.__a;
			int i = lo;
			#line 245 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			int j = hi;
			T p = buf[( ( i + j ) >> 1 )];
			while (( i <= j ))
			{
				#line 249 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				while (( ((int) (f.__hx_invoke2_f(default(double), default(double), buf[i], p)) ) < 0 ))
				{
					#line 249 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					i++;
				}
				
				while (( ((int) (f.__hx_invoke2_f(default(double), default(double), buf[j], p)) ) > 0 ))
				{
					#line 250 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					j--;
				}
				
				if (( i <= j )) 
				{
					#line 253 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					T t = buf[i];
					buf[i++] = buf[j];
					buf[j--] = t;
				}
				
			}
			
			#line 259 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (( lo < j )) 
			{
				#line 259 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				this.quicksort(lo, j, f);
			}
			
			if (( i < hi )) 
			{
				#line 260 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				this.quicksort(i, hi, f);
			}
			
		}
		#line default
	}
	
	
	public   global::Array<T> splice(int pos, int len)
	{
		unchecked 
		{
			#line 268 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (( len < 0 )) 
			{
				#line 268 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				return new global::Array<T>();
			}
			
			if (( pos < 0 )) 
			{
				pos = ( this.length + pos );
				if (( pos < 0 )) 
				{
					#line 271 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					pos = 0;
				}
				
			}
			
			#line 273 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (( pos > this.length )) 
			{
				pos = 0;
				len = 0;
			}
			 else 
			{
				if (( ( pos + len ) > this.length )) 
				{
					len = ( this.length - pos );
					if (( len < 0 )) 
					{
						#line 278 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
						len = 0;
					}
					
				}
				
			}
			
			#line 280 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			T[] a = this.__a;
			#line 282 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			T[] ret = new T[((int) (len) )];
			global::System.Array.Copy(a, pos, ret, 0, len);
			global::Array<T> ret1 = global::Array<object>.ofNative<T>(ret);
			#line 286 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			int end = ( pos + len );
			global::System.Array.Copy(a, end, a, pos, ( this.length - end ));
			this.length -= len;
			while ((  -- len >= 0 ))
			{
				a[( this.length + len )] = default(T);
			}
			
			return ret1;
		}
		#line default
	}
	
	
	public   void spliceVoid(int pos, int len)
	{
		unchecked 
		{
			#line 296 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (( len < 0 )) 
			{
				#line 296 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				return ;
			}
			
			if (( pos < 0 )) 
			{
				pos = ( this.length + pos );
				if (( pos < 0 )) 
				{
					#line 299 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					pos = 0;
				}
				
			}
			
			#line 301 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (( pos > this.length )) 
			{
				pos = 0;
				len = 0;
			}
			 else 
			{
				if (( ( pos + len ) > this.length )) 
				{
					len = ( this.length - pos );
					if (( len < 0 )) 
					{
						#line 306 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
						len = 0;
					}
					
				}
				
			}
			
			#line 308 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			T[] a = this.__a;
			#line 310 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			int end = ( pos + len );
			global::System.Array.Copy(a, end, a, pos, ( this.length - end ));
			this.length -= len;
			while ((  -- len >= 0 ))
			{
				a[( this.length + len )] = default(T);
			}
			
		}
		#line default
	}
	
	
	public   string toString()
	{
		unchecked 
		{
			#line 322 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			global::StringBuf ret = new global::StringBuf();
			T[] a = this.__a;
			ret.b.Append(((object) ("[") ));
			bool first = true;
			{
				#line 326 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				int _g1 = 0;
				#line 326 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				int _g = this.length;
				#line 326 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				while (( _g1 < _g ))
				{
					#line 326 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					int i = _g1++;
					#line 328 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					if (first) 
					{
						first = false;
					}
					 else 
					{
						#line 331 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
						ret.b.Append(((object) (",") ));
					}
					
					ret.b.Append(((object) (global::Std.@string(a[i])) ));
				}
				
			}
			
			#line 335 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			ret.b.Append(((object) ("]") ));
			return ret.toString();
		}
		#line default
	}
	
	
	public   void unshift(T x)
	{
		unchecked 
		{
			#line 344 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			T[] __a = this.__a;
			int length = this.length;
			if (( length >= __a.Length )) 
			{
				#line 348 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				int newLen = ( (( length << 1 )) + 1 );
				T[] newarr = new T[((int) (newLen) )];
				global::System.Array.Copy(__a, 0, newarr, 1, length);
				#line 352 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				this.__a = newarr;
			}
			 else 
			{
				global::System.Array.Copy(__a, 0, __a, 1, length);
			}
			
			#line 357 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			this.__a[0] = x;
			 ++ this.length;
		}
		#line default
	}
	
	
	public   void insert(int pos, T x)
	{
		unchecked 
		{
			#line 367 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			int l = this.length;
			if (( pos < 0 )) 
			{
				pos = ( l + pos );
				if (( pos < 0 )) 
				{
					#line 370 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					pos = 0;
				}
				
			}
			
			#line 372 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (( pos >= l )) 
			{
				this.push(x);
				return ;
			}
			 else 
			{
				if (( pos == 0 )) 
				{
					this.unshift(x);
					return ;
				}
				
			}
			
			#line 380 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (( l >= this.__a.Length )) 
			{
				#line 382 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				int newLen = ( (( this.length << 1 )) + 1 );
				T[] newarr = new T[((int) (newLen) )];
				global::System.Array.Copy(this.__a, 0, newarr, 0, pos);
				newarr[pos] = x;
				global::System.Array.Copy(this.__a, pos, newarr, ( pos + 1 ), ( l - pos ));
				#line 388 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				this.__a = newarr;
				 ++ this.length;
			}
			 else 
			{
				#line 391 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				T[] __a = this.__a;
				global::System.Array.Copy(__a, pos, __a, ( pos + 1 ), ( l - pos ));
				global::System.Array.Copy(__a, 0, __a, 0, pos);
				__a[pos] = x;
				 ++ this.length;
			}
			
		}
		#line default
	}
	
	
	public   bool @remove(T x)
	{
		unchecked 
		{
			#line 406 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			T[] __a = this.__a;
			int i = -1;
			int length = this.length;
			while ((  ++ i < length ))
			{
				if (global::haxe.lang.Runtime.eq(__a[i], x)) 
				{
					#line 413 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					global::System.Array.Copy(__a, ( i + 1 ), __a, i, ( ( length - i ) - 1 ));
					__a[ -- this.length] = default(T);
					#line 416 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return true;
				}
				
			}
			
			#line 420 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return false;
		}
		#line default
	}
	
	
	public   global::Array<S> map<S>(global::haxe.lang.Function f)
	{
		unchecked 
		{
			#line 424 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			global::Array<S> ret = new global::Array<S>(new S[]{});
			{
				#line 425 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				int _g = 0;
				#line 425 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				global::Array<T> _g1 = this;
				#line 425 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				while (( _g < _g1.length ))
				{
					#line 425 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					T elt = _g1[_g];
					#line 425 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					 ++ _g;
					ret.push(global::haxe.lang.Runtime.genericCast<S>(f.__hx_invoke1_o(default(double), elt)));
				}
				
			}
			
			return ret;
		}
		#line default
	}
	
	
	public   global::Array<T> filter(global::haxe.lang.Function f)
	{
		unchecked 
		{
			#line 431 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			global::Array<T> ret = new global::Array<T>(new T[]{});
			{
				#line 432 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				int _g = 0;
				#line 432 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				global::Array<T> _g1 = this;
				#line 432 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				while (( _g < _g1.length ))
				{
					#line 432 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					T elt = _g1[_g];
					#line 432 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					 ++ _g;
					if (((bool) (f.__hx_invoke1_o(default(double), elt)) )) 
					{
						ret.push(elt);
					}
					
				}
				
			}
			
			return ret;
		}
		#line default
	}
	
	
	public   global::Array<T> copy()
	{
		unchecked 
		{
			#line 444 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			int len = this.length;
			T[] __a = this.__a;
			T[] newarr = new T[((int) (len) )];
			global::System.Array.Copy(__a, 0, newarr, 0, len);
			return global::Array<object>.ofNative<T>(newarr);
		}
		#line default
	}
	
	
	public   object iterator()
	{
		unchecked 
		{
			#line 454 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			global::Array<object> _g = new global::Array<object>(new object[]{this});
			#line 456 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			global::Array<int> i = new global::Array<int>(new int[]{0});
			global::Array<int> len = new global::Array<int>(new int[]{this.length});
			#line 459 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			{
				global::haxe.lang.Function __temp_odecl43 = new global::Fun_de727b9b(((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (len) ))) ), ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (i) ))) ));
				global::haxe.lang.Function __temp_odecl44 = new global::Fun_4588d59e<T>(((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (i) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) ));
				#line 459 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				return new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{407283053, 1224901875}), new global::Array<object>(new object[]{__temp_odecl43, __temp_odecl44}), new global::Array<int>(new int[]{}), new global::Array<double>(new double[]{}));
			}
			
		}
		#line default
	}
	
	
	public   T __get(int idx)
	{
		unchecked 
		{
			#line 467 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			T[] __a = this.__a;
			uint idx1 = ((uint) (idx) );
			if (( idx1 >= this.length )) 
			{
				return default(T);
			}
			
			#line 472 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return __a[((int) (idx1) )];
		}
		#line default
	}
	
	
	public   T __set(int idx, T v)
	{
		unchecked 
		{
			#line 477 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			uint idx1 = ((uint) (idx) );
			T[] __a = this.__a;
			if (( idx1 >= __a.Length )) 
			{
				#line 481 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				uint len = ( idx1 + 1 );
				if (( idx1 == __a.Length )) 
				{
					len = ((uint) (( (( idx1 << 1 )) + 1 )) );
				}
				
				T[] newArr = new T[((int) (len) )];
				__a.CopyTo(((global::System.Array) (newArr) ), ((int) (0) ));
				this.__a = __a = newArr;
			}
			
			#line 489 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			if (( idx1 >= this.length )) 
			{
				this.length = ((int) (( idx1 + 1 )) );
			}
			
			#line 492 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return __a[((int) (idx1) )] = v;
		}
		#line default
	}
	
	
	public   T __unsafe_get(int idx)
	{
		unchecked 
		{
			#line 496 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return this.__a[idx];
		}
		#line default
	}
	
	
	public   T __unsafe_set(int idx, T val)
	{
		unchecked 
		{
			#line 501 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return this.__a[idx] = val;
		}
		#line default
	}
	
	
	public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
	{
		unchecked 
		{
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			switch (hash)
			{
				case 520590566:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					this.length = ((int) (@value) );
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return @value;
				}
				
				
				default:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
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
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			switch (hash)
			{
				case 4745537:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					this.__a = ((T[]) (@value) );
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return @value;
				}
				
				
				case 520590566:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					this.length = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return @value;
				}
				
				
				default:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
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
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			switch (hash)
			{
				case 1621420777:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("__unsafe_set"), ((int) (1621420777) ))) );
				}
				
				
				case 1620824029:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("__unsafe_get"), ((int) (1620824029) ))) );
				}
				
				
				case 1916009602:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("__set"), ((int) (1916009602) ))) );
				}
				
				
				case 1915412854:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("__get"), ((int) (1915412854) ))) );
				}
				
				
				case 328878574:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("iterator"), ((int) (328878574) ))) );
				}
				
				
				case 1103412149:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("copy"), ((int) (1103412149) ))) );
				}
				
				
				case 87367608:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("filter"), ((int) (87367608) ))) );
				}
				
				
				case 5442204:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("map"), ((int) (5442204) ))) );
				}
				
				
				case 76061764:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("remove"), ((int) (76061764) ))) );
				}
				
				
				case 501039929:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("insert"), ((int) (501039929) ))) );
				}
				
				
				case 2025055113:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("unshift"), ((int) (2025055113) ))) );
				}
				
				
				case 946786476:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("toString"), ((int) (946786476) ))) );
				}
				
				
				case 1352786672:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("spliceVoid"), ((int) (1352786672) ))) );
				}
				
				
				case 1067353468:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("splice"), ((int) (1067353468) ))) );
				}
				
				
				case 1282943179:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("quicksort"), ((int) (1282943179) ))) );
				}
				
				
				case 1280845662:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("sort"), ((int) (1280845662) ))) );
				}
				
				
				case 2127021138:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("slice"), ((int) (2127021138) ))) );
				}
				
				
				case 2082663554:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("shift"), ((int) (2082663554) ))) );
				}
				
				
				case 452737314:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("reverse"), ((int) (452737314) ))) );
				}
				
				
				case 1247875546:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("push"), ((int) (1247875546) ))) );
				}
				
				
				case 5594513:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("pop"), ((int) (5594513) ))) );
				}
				
				
				case 1181037546:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("join"), ((int) (1181037546) ))) );
				}
				
				
				case 1532710347:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("concatNative"), ((int) (1532710347) ))) );
				}
				
				
				case 1204816148:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("concat"), ((int) (1204816148) ))) );
				}
				
				
				case 4745537:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.__a;
				}
				
				
				case 520590566:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.length;
				}
				
				
				default:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
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
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			switch (hash)
			{
				case 520590566:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return ((double) (this.length) );
				}
				
				
				default:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
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
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			switch (hash)
			{
				case 1621420777:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.__unsafe_set(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
				}
				
				
				case 1620824029:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.__unsafe_get(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
				}
				
				
				case 1916009602:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.__set(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
				}
				
				
				case 1915412854:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.__get(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
				}
				
				
				case 328878574:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.iterator();
				}
				
				
				case 1103412149:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.copy();
				}
				
				
				case 87367608:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.filter(((global::haxe.lang.Function) (dynargs[0]) ));
				}
				
				
				case 5442204:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.map<object>(((global::haxe.lang.Function) (dynargs[0]) ));
				}
				
				
				case 76061764:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.@remove(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
				}
				
				
				case 501039929:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					this.insert(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					break;
				}
				
				
				case 2025055113:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					this.unshift(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					break;
				}
				
				
				case 946786476:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.toString();
				}
				
				
				case 1352786672:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					this.spliceVoid(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					break;
				}
				
				
				case 1067353468:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.splice(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
				}
				
				
				case 1282943179:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					this.quicksort(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::haxe.lang.Function) (dynargs[2]) ));
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					break;
				}
				
				
				case 1280845662:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					this.sort(((global::haxe.lang.Function) (dynargs[0]) ));
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					break;
				}
				
				
				case 2127021138:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.slice(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
				}
				
				
				case 2082663554:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return (this.shift()).toDynamic();
				}
				
				
				case 452737314:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					this.reverse();
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					break;
				}
				
				
				case 1247875546:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.push(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
				}
				
				
				case 5594513:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return (this.pop()).toDynamic();
				}
				
				
				case 1181037546:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.@join(global::haxe.lang.Runtime.toString(dynargs[0]));
				}
				
				
				case 1532710347:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					this.concatNative(((T[]) (dynargs[0]) ));
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					break;
				}
				
				
				case 1204816148:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return this.concat(((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (dynargs[0]) ))) ));
				}
				
				
				default:
				{
					#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
					return base.__hx_invokeField(field, hash, dynargs);
				}
				
			}
			
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return default(object);
		}
		#line default
	}
	
	
	public override   void __hx_getFields(global::Array<object> baseArr)
	{
		unchecked 
		{
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			baseArr.push("__a");
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			baseArr.push("length");
			#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			{
				#line 36 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
				base.__hx_getFields(baseArr);
			}
			
		}
		#line default
	}
	
	
	public T this[int index]
	{
		get
		{
			return this.__get(index);
		}
		set
		{
			this.__set(index,value);
		}
	}
	object global::Array.this[int key]
	{
		get
		{
			return ((object) this.__get(key));
		}
		set
		{
			this.__set(key, (T) value);
		}
	}
	
	
	public override string ToString()
	{
		return this.toString();
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Fun_de727b9b : global::haxe.lang.Function 
{
	public    Fun_de727b9b(global::Array<int> len, global::Array<int> i) : base(0, 0)
	{
		unchecked 
		{
			#line 460 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			this.len = len;
			#line 460 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			this.i = i;
		}
		#line default
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			#line 460 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return ( this.i[0] < this.len[0] );
		}
		#line default
	}
	
	
	public  global::Array<int> len;
	
	public  global::Array<int> i;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Fun_4588d59e<T> : global::haxe.lang.Function 
{
	public    Fun_4588d59e(global::Array<int> i, global::Array<object> _g) : base(0, 0)
	{
		unchecked 
		{
			#line 461 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			this.i = i;
			#line 461 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			this._g = _g;
		}
		#line default
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			#line 461 "C:\\HaxeToolkit\\haxe/std/cs/_std/Array.hx"
			return ((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (this._g[0]) ))) ).__a[this.i[0]++];
		}
		#line default
	}
	
	
	public  global::Array<int> i;
	
	public  global::Array<object> _g;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public  interface Array : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject 
{
	   object Array_cast<T1>();
	
	object this[int key]
	{
		get;
		set;
	}
	
	
}


