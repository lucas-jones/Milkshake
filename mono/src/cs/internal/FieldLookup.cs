
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang
{
	public  class FieldLookup : global::haxe.lang.HxObject 
	{
		public    FieldLookup(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 25 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    FieldLookup()
		{
			unchecked 
			{
				#line 25 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				global::haxe.lang.FieldLookup.__hx_ctor_haxe_lang_FieldLookup(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_lang_FieldLookup(global::haxe.lang.FieldLookup __temp_me14)
		{
			unchecked 
			{
				#line 25 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  global::Array<int> fieldIds = new global::Array<int>(new int[]{98, 109, 23526, 1821933, 4103979, 4745537, 4949376, 5144726, 5393365, 5442204, 5594513, 5594516, 5741474, 5745024, 5790298, 5843823, 10663594, 52644165, 67857086, 76061764, 87367608, 117802505, 142301684, 157772329, 159136996, 209784577, 243225909, 295397041, 302979532, 306172860, 328878574, 360725482, 380244791, 407283053, 427265337, 452737314, 480756972, 493819893, 501039929, 520590566, 589796196, 610723709, 639472622, 660670753, 735461151, 737456210, 759781412, 770358897, 922671056, 937267591, 946786476, 968744822, 995006396, 999946793, 1029013645, 1041537810, 1042138122, 1067353468, 1092322354, 1103412149, 1136381564, 1137315269, 1147073522, 1149558607, 1156121931, 1158860648, 1181037546, 1191633396, 1196428959, 1204816148, 1214453688, 1224901875, 1238832007, 1247576961, 1247875546, 1271070480, 1280549057, 1280845662, 1282943179, 1292432058, 1313416818, 1348037855, 1352786672, 1381630732, 1395555037, 1488620307, 1532710347, 1533657591, 1537812987, 1547539107, 1620824029, 1621420777, 1639293562, 1648581351, 1661489734, 1668035952, 1693277929, 1705565617, 1705629508, 1723805383, 1744813180, 1763375486, 1795947670, 1830310359, 1836776262, 1855145886, 1915412854, 1916009602, 1955029599, 1981972957, 1987394228, 2003447495, 2022294396, 2025055113, 2048392659, 2081384188, 2082663554, 2084789794, 2127021138});
		
		public static  global::Array<object> fields = new global::Array<object>(new object[]{"b", "m", "io", "isGlobal", "Run", "__a", "cur", "get", "len", "map", "pop", "pos", "set", "sub", "tag", "url", "postData", "match", "stage", "remove", "filter", "update", "resize", "onError", "matched", "output", "readBytes", "GetHashCode", "methodName", "setStage", "iterator", "connect", "readChunk", "hasNext", "content", "reverse", "nOccupied", "getBytes", "insert", "length", "getTag", "writeFullBytes", "background", "chunk_buf", "setTimeout", "Boot", "Draw", "gameCore", "cachedIndex", "prepare", "toString", "Render", "hashes", "Update", "param", "index", "input", "splice", "boot", "copy", "file", "responseHeaders", "game", "request", "responseData", "host", "join", "keys", "readHttpResponse", "concat", "close", "next", "writeByte", "port", "push", "matchedPos", "size", "sort", "quicksort", "type", "vals", "write", "spliceVoid", "writeBytes", "cachedKey", "chunk_size", "concatNative", "noShutdown", "nBuckets", "className", "__unsafe_get", "__unsafe_set", "lookup", "fileName", "headers", "Initialize", "onData", "onStatus", "toDynamic", "regex", "constructs", "readByte", "shutdown", "customParams", "params", "customRequest", "__get", "__set", "Equals", "lineNumber", "cnxTimeout", "filename", "upperBound", "unshift", "_keys", "create", "shift", "__hx_createEmpty", "slice"});
		
		public static   int doHash(string s)
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				int acc = 0;
				{
					#line 35 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
					int _g1 = 0;
					#line 35 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
					int _g = s.Length;
					#line 35 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
					while (( _g1 < _g ))
					{
						#line 35 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
						int i = _g1++;
						#line 37 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
						acc = ( ( ( 223 * (( acc >> 1 )) ) + global::haxe.lang.StringExt.charCodeAt(s, i).@value ) << 1 );
					}
					
				}
				
				#line 40 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				return ((int) (( ((uint) (acc) ) >> 1 )) );
			}
			#line default
		}
		
		
		public static   string lookupHash(int key)
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				global::Array<int> ids = global::haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				int max = ids.length;
				#line 50 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				while (( min < max ))
				{
					#line 52 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
					int mid = ( min + ( (( max - min )) / 2 ) );
					int imid = ids[mid];
					if (( key < imid )) 
					{
						max = mid;
					}
					 else 
					{
						#line 57 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
						if (( key > imid )) 
						{
							#line 57 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
							min = ( mid + 1 );
						}
						 else 
						{
							#line 59 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
							return global::haxe.lang.Runtime.toString(global::haxe.lang.FieldLookup.fields[mid]);
						}
						
					}
					
				}
				
				#line 64 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat("Field not found for hash ", global::haxe.lang.Runtime.toString(key)));
			}
			#line default
		}
		
		
		public static   int hash(string s)
		{
			unchecked 
			{
				#line 69 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				if (string.Equals(s, default(string))) 
				{
					#line 69 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
					return 0;
				}
				
				#line 71 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				int key = default(int);
				#line 71 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				{
					#line 71 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
					int acc = 0;
					#line 71 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
					{
						#line 71 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
						int _g1 = 0;
						#line 71 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
						int _g = s.Length;
						#line 71 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
						while (( _g1 < _g ))
						{
							#line 71 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
							int i = _g1++;
							#line 71 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
							acc = ( ( ( 223 * (( acc >> 1 )) ) + global::haxe.lang.StringExt.charCodeAt(s, i).@value ) << 1 );
						}
						
					}
					
					#line 71 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
					key = ((int) (( ((uint) (acc) ) >> 1 )) );
				}
				
				#line 74 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				global::Array<int> ids = global::haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				int max = ids.length;
				#line 78 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				while (( min < max ))
				{
					#line 80 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
					int mid = ((int) (( min + ( ((double) ((( max - min ))) ) / 2 ) )) );
					int imid = ids[mid];
					if (( key < imid )) 
					{
						max = mid;
					}
					 else 
					{
						#line 85 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
						if (( key > imid )) 
						{
							#line 85 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
							min = ( mid + 1 );
						}
						 else 
						{
							#line 88 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
							string field = global::haxe.lang.Runtime.toString(global::haxe.lang.FieldLookup.fields[mid]);
							if ( ! (string.Equals(field, s)) ) 
							{
								return  ~ (key) ;
							}
							
							return key;
						}
						
					}
					
				}
				
				#line 95 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				ids.insert(min, key);
				global::haxe.lang.FieldLookup.fields.insert(min, s);
				return key;
			}
			#line default
		}
		
		
		public static   int findHash(int hash, global::Array<int> hashs)
		{
			unchecked 
			{
				#line 102 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				int min = 0;
				int max = hashs.length;
				#line 105 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				while (( min < max ))
				{
					#line 107 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
					int mid = ( (( max + min )) / 2 );
					int imid = hashs[mid];
					if (( hash < imid )) 
					{
						max = mid;
					}
					 else 
					{
						#line 112 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
						if (( hash > imid )) 
						{
							#line 112 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
							min = ( mid + 1 );
						}
						 else 
						{
							#line 114 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
							return mid;
						}
						
					}
					
				}
				
				#line 119 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				return  ~ (min) ;
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 25 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				return new global::haxe.lang.FieldLookup(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 25 "C:\\HaxeToolkit\\haxe/std/cs/internal/FieldLookup.hx"
				return new global::haxe.lang.FieldLookup();
			}
			#line default
		}
		
		
	}
}


