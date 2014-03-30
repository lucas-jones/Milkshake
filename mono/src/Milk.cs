
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Milk : global::haxe.lang.HxObject 
{
	public static void Main()
	{
		cs.Boot.init();
		main();
	}
	public    Milk(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 12 "src/Milk.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    Milk()
	{
		unchecked 
		{
			#line 14 "src/Milk.hx"
			global::Milk.__hx_ctor__Milk(this);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__Milk(global::Milk __temp_me6)
	{
		unchecked 
		{
			#line 15 "src/Milk.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static   void main()
	{
		unchecked 
		{
			#line 25 "src/Milk.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), default(double), "[Milk] C#", new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{302979532, 1547539107, 1648581351}), new global::Array<object>(new object[]{"main", "Milk", "Milk.hx"}), new global::Array<int>(new int[]{1981972957}), new global::Array<double>(new double[]{((double) (25) )})));
			new global::MilkGame().boot(289, 510);
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 12 "src/Milk.hx"
			return new global::Milk(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 12 "src/Milk.hx"
			return new global::Milk();
		}
		#line default
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public  class MilkGame : global::haxe.lang.HxObject, global::milk.IGame 
{
	public    MilkGame(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 64 "src/Milk.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    MilkGame()
	{
		unchecked 
		{
			#line 71 "src/Milk.hx"
			global::MilkGame.__hx_ctor__MilkGame(this);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__MilkGame(global::MilkGame __temp_me7)
	{
		unchecked 
		{
			#line 72 "src/Milk.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 64 "src/Milk.hx"
			return new global::MilkGame(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 64 "src/Milk.hx"
			return new global::MilkGame();
		}
		#line default
	}
	
	
	public  global::milk.IGameCore gameCore;
	
	public  global::PIXI.Stage stage;
	
	public  global::PIXI.Sprite background;
	
	public virtual   void boot(int width, int height)
	{
		unchecked 
		{
			#line 81 "src/Milk.hx"
			this.gameCore = new global::milk.mono.MonoGame();
			#line 84 "src/Milk.hx"
			this.gameCore.create(this, width, height, 16773120);
		}
		#line default
	}
	
	
	public virtual   void setStage(global::PIXI.Stage stage)
	{
		unchecked 
		{
			#line 89 "src/Milk.hx"
			this.stage = stage;
			this.background = new global::PIXI.Sprite(((global::PIXI.Texture) (global::PIXI.Texture.fromImage("assets/Day_Background.png")) ));
			#line 92 "src/Milk.hx"
			stage.addChild(this.background);
			#line 94 "src/Milk.hx"
			global::haxe.Http http = new global::haxe.Http(global::haxe.lang.Runtime.toString("http://www.timeapi.org/utc/now"));
			http.request(default(global::haxe.lang.Null<bool>));
			global::haxe.Log.trace.__hx_invoke2_o(default(double), default(double), http.responseData, new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{302979532, 1547539107, 1648581351}), new global::Array<object>(new object[]{"setStage", "MilkGame", "Milk.hx"}), new global::Array<int>(new int[]{1981972957}), new global::Array<double>(new double[]{((double) (96) )})));
		}
		#line default
	}
	
	
	public virtual   void update(double delta)
	{
		unchecked 
		{
			#line 100 "src/Milk.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
	{
		unchecked 
		{
			#line 64 "src/Milk.hx"
			switch (hash)
			{
				case 639472622:
				{
					#line 64 "src/Milk.hx"
					this.background = ((global::PIXI.Sprite) (@value) );
					#line 64 "src/Milk.hx"
					return @value;
				}
				
				
				case 67857086:
				{
					#line 64 "src/Milk.hx"
					this.stage = ((global::PIXI.Stage) (@value) );
					#line 64 "src/Milk.hx"
					return @value;
				}
				
				
				case 770358897:
				{
					#line 64 "src/Milk.hx"
					this.gameCore = ((global::milk.IGameCore) (@value) );
					#line 64 "src/Milk.hx"
					return @value;
				}
				
				
				default:
				{
					#line 64 "src/Milk.hx"
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
			#line 64 "src/Milk.hx"
			switch (hash)
			{
				case 117802505:
				{
					#line 64 "src/Milk.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("update"), ((int) (117802505) ))) );
				}
				
				
				case 306172860:
				{
					#line 64 "src/Milk.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setStage"), ((int) (306172860) ))) );
				}
				
				
				case 1092322354:
				{
					#line 64 "src/Milk.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("boot"), ((int) (1092322354) ))) );
				}
				
				
				case 639472622:
				{
					#line 64 "src/Milk.hx"
					return this.background;
				}
				
				
				case 67857086:
				{
					#line 64 "src/Milk.hx"
					return this.stage;
				}
				
				
				case 770358897:
				{
					#line 64 "src/Milk.hx"
					return this.gameCore;
				}
				
				
				default:
				{
					#line 64 "src/Milk.hx"
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
			#line 64 "src/Milk.hx"
			switch (hash)
			{
				case 117802505:
				{
					#line 64 "src/Milk.hx"
					this.update(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					#line 64 "src/Milk.hx"
					break;
				}
				
				
				case 306172860:
				{
					#line 64 "src/Milk.hx"
					this.setStage(((global::PIXI.Stage) (dynargs[0]) ));
					#line 64 "src/Milk.hx"
					break;
				}
				
				
				case 1092322354:
				{
					#line 64 "src/Milk.hx"
					this.boot(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					#line 64 "src/Milk.hx"
					break;
				}
				
				
				default:
				{
					#line 64 "src/Milk.hx"
					return base.__hx_invokeField(field, hash, dynargs);
				}
				
			}
			
			#line 64 "src/Milk.hx"
			return default(object);
		}
		#line default
	}
	
	
	public override   void __hx_getFields(global::Array<object> baseArr)
	{
		unchecked 
		{
			#line 64 "src/Milk.hx"
			baseArr.push("background");
			#line 64 "src/Milk.hx"
			baseArr.push("stage");
			#line 64 "src/Milk.hx"
			baseArr.push("gameCore");
			#line 64 "src/Milk.hx"
			{
				#line 64 "src/Milk.hx"
				base.__hx_getFields(baseArr);
			}
			
		}
		#line default
	}
	
	
}


