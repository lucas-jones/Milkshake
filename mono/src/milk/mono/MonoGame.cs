
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace milk.mono
{
	public  class MonoGame : global::PIXI.MonoCanvas, global::haxe.lang.IHxObject, global::milk.IGameCore 
	{
		public    MonoGame(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    MonoGame() : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				return new global::milk.mono.MonoGame(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				return new global::milk.mono.MonoGame();
			}
			#line default
		}
		
		
		public  global::milk.IGame game;
		
		public  global::PIXI.Stage stage;
		
		public virtual   void create(global::milk.IGame game, int width, int height, int color)
		{
			unchecked 
			{
				#line 21 "src/milk/mono/MonoGame.hx"
				this.game = game;
				this.Boot(width, height);
				#line 24 "src/milk/mono/MonoGame.hx"
				this.stage = new global::PIXI.Stage(((int) (color) ));
				#line 26 "src/milk/mono/MonoGame.hx"
				this.Run();
			}
			#line default
		}
		
		
		protected override   void Draw(global::Microsoft.Xna.Framework.GameTime gameTime)
		{
			unchecked 
			{
				#line 34 "src/milk/mono/MonoGame.hx"
				this.Render(this.stage);
				base.Draw(gameTime);
			}
			#line default
		}
		
		
		protected override   void Update(global::Microsoft.Xna.Framework.GameTime gameTime)
		{
			unchecked 
			{
				#line 41 "src/milk/mono/MonoGame.hx"
				base.Update(gameTime);
				this.game.update(((double) (1) ));
			}
			#line default
		}
		
		
		protected override   void Initialize()
		{
			unchecked 
			{
				#line 48 "src/milk/mono/MonoGame.hx"
				base.Initialize();
				this.game.setStage(this.stage);
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				if (isCheck) 
				{
					#line 9 "src/milk/mono/MonoGame.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 9 "src/milk/mono/MonoGame.hx"
					if (throwErrors) 
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return default(object);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupField_f(string field, int hash, bool throwErrors)
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				if (throwErrors) 
				{
					#line 9 "src/milk/mono/MonoGame.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 9 "src/milk/mono/MonoGame.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				switch (hash)
				{
					default:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return this.__hx_lookupSetField_f(field, hash, @value);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				switch (hash)
				{
					case 67857086:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						this.stage = ((global::PIXI.Stage) (@value) );
						#line 9 "src/milk/mono/MonoGame.hx"
						return @value;
					}
					
					
					case 1147073522:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						this.game = ((global::milk.IGame) (@value) );
						#line 9 "src/milk/mono/MonoGame.hx"
						return @value;
					}
					
					
					default:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return this.__hx_lookupSetField(field, hash, @value);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				switch (hash)
				{
					case 968744822:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Render"), ((int) (968744822) ))) );
					}
					
					
					case 4103979:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Run"), ((int) (4103979) ))) );
					}
					
					
					case 737456210:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Boot"), ((int) (737456210) ))) );
					}
					
					
					case 1668035952:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Initialize"), ((int) (1668035952) ))) );
					}
					
					
					case 999946793:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Update"), ((int) (999946793) ))) );
					}
					
					
					case 759781412:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Draw"), ((int) (759781412) ))) );
					}
					
					
					case 2081384188:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("create"), ((int) (2081384188) ))) );
					}
					
					
					case 67857086:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return this.stage;
					}
					
					
					case 1147073522:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return this.game;
					}
					
					
					default:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return this.__hx_lookupField(field, hash, throwErrors, isCheck);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				switch (hash)
				{
					default:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return this.__hx_lookupField_f(field, hash, throwErrors);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_invokeField(string field, int hash, global::Array dynargs)
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				switch (hash)
				{
					case 759781412:case 999946793:case 1668035952:case 737456210:case 4103979:case 968744822:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 2081384188:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						this.create(((global::milk.IGame) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ));
						#line 9 "src/milk/mono/MonoGame.hx"
						break;
					}
					
					
					default:
					{
						#line 9 "src/milk/mono/MonoGame.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 9 "src/milk/mono/MonoGame.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 9 "src/milk/mono/MonoGame.hx"
				baseArr.push("stage");
				#line 9 "src/milk/mono/MonoGame.hx"
				baseArr.push("game");
			}
			#line default
		}
		
		
	}
}


