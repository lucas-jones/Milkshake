
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe
{
	public  class Http : global::haxe.lang.HxObject 
	{
		static Http() 
		{
			#line 73 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
			global::haxe.Http.PROXY = default(object);
		}
		public    Http(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Http(string url)
		{
			unchecked 
			{
				#line 87 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				global::haxe.Http.__hx_ctor_haxe_Http(this, url);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_Http(global::haxe.Http __temp_me20, string url)
		{
			unchecked 
			{
				#line 724 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				__temp_me20.onStatus = ( (( global::haxe.Fun_d41d8cd9_1.__hx_current != default(global::haxe.Fun_d41d8cd9_1) )) ? (global::haxe.Fun_d41d8cd9_1.__hx_current) : (global::haxe.Fun_d41d8cd9_1.__hx_current = ((global::haxe.Fun_d41d8cd9_1) (new global::haxe.Fun_d41d8cd9_1()) )) );
				#line 714 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				__temp_me20.onError = ( (( global::haxe.Fun_d41d8cd9_0.__hx_current != default(global::haxe.Fun_d41d8cd9_0) )) ? (global::haxe.Fun_d41d8cd9_0.__hx_current) : (global::haxe.Fun_d41d8cd9_0.__hx_current = ((global::haxe.Fun_d41d8cd9_0) (new global::haxe.Fun_d41d8cd9_0()) )) );
				#line 704 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				__temp_me20.onData = ( (( global::haxe.Fun_d41d8cd9.__hx_current != default(global::haxe.Fun_d41d8cd9) )) ? (global::haxe.Fun_d41d8cd9.__hx_current) : (global::haxe.Fun_d41d8cd9.__hx_current = ((global::haxe.Fun_d41d8cd9) (new global::haxe.Fun_d41d8cd9()) )) );
				#line 88 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				__temp_me20.url = url;
				__temp_me20.headers = new global::haxe.ds.StringMap<object>();
				__temp_me20.@params = new global::haxe.ds.StringMap<object>();
				#line 94 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				__temp_me20.cnxTimeout = ((double) (10) );
			}
			#line default
		}
		
		
		public static  object PROXY;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				return new global::haxe.Http(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				return new global::haxe.Http(global::haxe.lang.Runtime.toString(arr[0]));
			}
			#line default
		}
		
		
		public  string url;
		
		public  string responseData;
		
		public  bool noShutdown;
		
		public  double cnxTimeout;
		
		public  global::haxe.ds.StringMap<object> responseHeaders;
		
		public  global::haxe.lang.Null<int> chunk_size;
		
		public  global::haxe.io.Bytes chunk_buf;
		
		public  object file;
		
		public  string postData;
		
		public  global::haxe.ds.StringMap<object> headers;
		
		public  global::haxe.ds.StringMap<object> @params;
		
		public virtual   void request(global::haxe.lang.Null<bool> post)
		{
			unchecked 
			{
				#line 160 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				global::haxe.Http me = this;
				#line 313 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				global::Array<object> me1 = new global::Array<object>(new object[]{this});
				global::Array<object> output = new global::Array<object>(new object[]{new global::haxe.io.BytesOutput()});
				global::Array<object> old = new global::Array<object>(new object[]{this.onError});
				global::Array<bool> err = new global::Array<bool>(new bool[]{false});
				this.onError = new global::haxe.Fun_8e188927(((global::Array<bool>) (global::Array<object>.__hx_cast<bool>(((global::Array) (err) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (output) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (old) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (me1) ))) ));
				#line 326 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				this.customRequest(post.@value, ((global::haxe.io.BytesOutput) (output[0]) ), default(object), default(string));
				if ( ! (err[0]) ) 
				{
					#line 331 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					((global::haxe.Http) (me1[0]) ).onData.__hx_invoke1_o(default(double), ((global::haxe.Http) (me1[0]) ).responseData = ((global::haxe.io.BytesOutput) (output[0]) ).getBytes().toString());
				}
				
			}
			#line default
		}
		
		
		public virtual   void customRequest(bool post, global::haxe.io.Output api, object sock, string method)
		{
			unchecked 
			{
				#line 343 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				this.responseData = default(string);
				global::EReg url_regexp = new global::EReg(global::haxe.lang.Runtime.toString("^(https?://)?([a-zA-Z\\.0-9-]+)(:[0-9]+)?(.*)$"), global::haxe.lang.Runtime.toString(""));
				if ( ! (url_regexp.match(this.url)) ) 
				{
					this.onError.__hx_invoke1_o(default(double), "Invalid URL");
					return ;
				}
				
				#line 349 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				bool secure = string.Equals(url_regexp.matched(1), "https://");
				if (global::haxe.lang.Runtime.refEq(sock, default(object))) 
				{
					#line 350 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					if (secure) 
					{
						throw global::haxe.lang.HaxeException.wrap("Https is only supported with -lib hxssl");
					}
					 else 
					{
						#line 360 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						sock = new global::sys.net.Socket();
					}
					
				}
				
				#line 362 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				string host = url_regexp.matched(2);
				string portString = url_regexp.matched(3);
				string request = url_regexp.matched(4);
				if (string.Equals(request, "")) 
				{
					request = "/";
				}
				
				global::haxe.lang.Null<int> port = ( (( string.Equals(portString, default(string)) || string.Equals(portString, "") )) ? (new global::haxe.lang.Null<int>(( (secure) ? (443) : (80) ), true)) : (global::Std.parseInt(global::haxe.lang.StringExt.substr(portString, 1, new global::haxe.lang.Null<int>(( portString.Length - 1 ), true)))) );
				object data = default(object);
				#line 370 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				bool multipart = ( ! (global::haxe.lang.Runtime.refEq(this.file, default(object))) );
				string boundary = default(string);
				string uri = default(string);
				if (multipart) 
				{
					post = true;
					boundary = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::Std.@string(global::Std.random(1000)), global::Std.@string(global::Std.random(1000))), global::Std.@string(global::Std.random(1000))), global::Std.@string(global::Std.random(1000)));
					while (( boundary.Length < 38 ))
					{
						boundary = global::haxe.lang.Runtime.concat("-", boundary);
					}
					
					global::StringBuf b = new global::StringBuf();
					{
						#line 379 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						object __temp_iterator38 = this.@params.keys();
						#line 379 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator38, "hasNext", 407283053, default(global::Array))) ))
						{
							#line 379 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							string p = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator38, "next", 1224901875, default(global::Array)));
							b.b.Append(((object) ("--") ));
							b.b.Append(((object) (global::Std.@string(boundary)) ));
							b.b.Append(((object) ("\r\n") ));
							b.b.Append(((object) ("Content-Disposition: form-data; name=\"") ));
							b.b.Append(((object) (global::Std.@string(p)) ));
							b.b.Append(((object) ("\"") ));
							b.b.Append(((object) ("\r\n") ));
							b.b.Append(((object) ("\r\n") ));
							b.b.Append(((object) (global::Std.@string(global::haxe.lang.Runtime.toString(this.@params.@get(p).@value))) ));
							b.b.Append(((object) ("\r\n") ));
						}
						
					}
					
					#line 391 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					b.b.Append(((object) ("--") ));
					b.b.Append(((object) (global::Std.@string(boundary)) ));
					b.b.Append(((object) ("\r\n") ));
					b.b.Append(((object) ("Content-Disposition: form-data; name=\"") ));
					b.b.Append(((object) (global::Std.@string(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(this.file, "param", 1029013645, true)))) ));
					b.b.Append(((object) ("\"; filename=\"") ));
					b.b.Append(((object) (global::Std.@string(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(this.file, "filename", 2003447495, true)))) ));
					b.b.Append(((object) ("\"") ));
					b.b.Append(((object) ("\r\n") ));
					b.b.Append(((object) (global::Std.@string(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Content-Type: ", "application/octet-stream"), "\r\n"), "\r\n"))) ));
					uri = b.toString();
				}
				 else 
				{
					{
						object __temp_iterator37 = this.@params.keys();
						#line 402 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator37, "hasNext", 407283053, default(global::Array))) ))
						{
							string p1 = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator37, "next", 1224901875, default(global::Array)));
							if (string.Equals(uri, default(string))) 
							{
								uri = "";
							}
							 else 
							{
								#line 407 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								uri = global::haxe.lang.Runtime.concat(uri, "&");
							}
							
							uri = global::haxe.lang.Runtime.concat(uri, global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::StringTools.urlEncode(p1), "="), global::StringTools.urlEncode(global::haxe.lang.Runtime.toString(this.@params.@get(p1).@value))));
						}
						
					}
					
				}
				
				#line 412 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				global::StringBuf b1 = new global::StringBuf();
				if ( ! (string.Equals(method, default(string))) ) 
				{
					b1.b.Append(((object) (global::Std.@string(method)) ));
					b1.b.Append(((object) (" ") ));
				}
				 else 
				{
					if (post) 
					{
						b1.b.Append(((object) ("POST ") ));
					}
					 else 
					{
						#line 419 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						b1.b.Append(((object) ("GET ") ));
					}
					
				}
				
				#line 421 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				if (( ! (global::haxe.lang.Runtime.refEq(global::haxe.Http.PROXY, default(object))) )) 
				{
					b1.b.Append(((object) ("http://") ));
					b1.b.Append(((object) (global::Std.@string(host)) ));
					if (( ! (global::haxe.lang.Runtime.eq((port).toDynamic(), 80)) )) 
					{
						b1.b.Append(((object) (":") ));
						b1.b.Append(((object) (global::Std.@string((port).toDynamic())) ));
					}
					
				}
				
				#line 429 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				b1.b.Append(((object) (global::Std.@string(request)) ));
				#line 431 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				if ((  ! (post)  &&  ! (string.Equals(uri, default(string)))  )) 
				{
					if (( global::haxe.lang.StringExt.indexOf(request, "?", new global::haxe.lang.Null<int>(0, true)) >= 0 )) 
					{
						b1.b.Append(((object) ("&") ));
					}
					 else 
					{
						#line 435 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						b1.b.Append(((object) ("?") ));
					}
					
					b1.b.Append(((object) (global::Std.@string(uri)) ));
				}
				
				#line 438 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				b1.b.Append(((object) (global::Std.@string(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(" HTTP/1.1\r\nHost: ", host), "\r\n"))) ));
				if ( ! (string.Equals(this.postData, default(string))) ) 
				{
					b1.b.Append(((object) (global::Std.@string(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Content-Length: ", global::haxe.lang.Runtime.toString(this.postData.Length)), "\r\n"))) ));
				}
				 else 
				{
					if (( post &&  ! (string.Equals(uri, default(string)))  )) 
					{
						if (( multipart || string.Equals(global::haxe.lang.Runtime.toString(this.headers.@get("Content-Type").@value), default(string)) )) 
						{
							b1.b.Append(((object) ("Content-Type: ") ));
							if (multipart) 
							{
								b1.b.Append(((object) ("multipart/form-data") ));
								b1.b.Append(((object) ("; boundary=") ));
								b1.b.Append(((object) (global::Std.@string(boundary)) ));
							}
							 else 
							{
								#line 449 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								b1.b.Append(((object) ("application/x-www-form-urlencoded") ));
							}
							
							b1.b.Append(((object) ("\r\n") ));
						}
						
						#line 452 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						if (multipart) 
						{
							b1.b.Append(((object) (global::Std.@string(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Content-Length: ", global::haxe.lang.Runtime.toString((( ( ( uri.Length + ((int) (global::haxe.lang.Runtime.getField_f(this.file, "size", 1280549057, true)) ) ) + boundary.Length ) + 6 )))), "\r\n"))) ));
						}
						 else 
						{
							#line 455 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							b1.b.Append(((object) (global::Std.@string(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Content-Length: ", global::haxe.lang.Runtime.toString(uri.Length)), "\r\n"))) ));
						}
						
					}
					
				}
				
				#line 457 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				{
					#line 457 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					object __temp_iterator39 = this.headers.keys();
					#line 457 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator39, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 457 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						string h = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator39, "next", 1224901875, default(global::Array)));
						b1.b.Append(((object) (global::Std.@string(h)) ));
						b1.b.Append(((object) (": ") ));
						b1.b.Append(((object) (global::Std.@string(global::haxe.lang.Runtime.toString(this.headers.@get(h).@value))) ));
						b1.b.Append(((object) ("\r\n") ));
					}
					
				}
				
				#line 463 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				b1.b.Append(((object) ("\r\n") ));
				if ( ! (string.Equals(this.postData, default(string))) ) 
				{
					b1.b.Append(((object) (global::Std.@string(this.postData)) ));
				}
				 else 
				{
					if (( post &&  ! (string.Equals(uri, default(string)))  )) 
					{
						b1.b.Append(((object) (global::Std.@string(uri)) ));
					}
					
				}
				
				try 
				{
					if (( ! (global::haxe.lang.Runtime.refEq(global::haxe.Http.PROXY, default(object))) )) 
					{
						global::haxe.lang.Runtime.callField(sock, "connect", 360725482, new global::Array<object>(new object[]{new global::sys.net.Host(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(global::haxe.Http.PROXY, "host", 1158860648, true))), ((int) (global::haxe.lang.Runtime.getField_f(global::haxe.Http.PROXY, "port", 1247576961, true)) )}));
					}
					 else 
					{
						#line 472 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						global::haxe.lang.Runtime.callField(sock, "connect", 360725482, new global::Array<object>(new object[]{new global::sys.net.Host(global::haxe.lang.Runtime.toString(host)), (port).toDynamic()}));
					}
					
					global::haxe.lang.Runtime.callField(sock, "write", 1348037855, new global::Array<object>(new object[]{b1.toString()}));
					if (multipart) 
					{
						int bufsize = 4096;
						global::haxe.io.Bytes buf = global::haxe.io.Bytes.alloc(bufsize);
						while (( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(this.file, "size", 1280549057, true)) ), 0) > 0 ))
						{
							int size = ( (( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(this.file, "size", 1280549057, true)) ), bufsize) > 0 )) ? (bufsize) : (((int) (global::haxe.lang.Runtime.getField_f(this.file, "size", 1280549057, true)) )) );
							int len = 0;
							try 
							{
								#line 480 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								len = ((global::haxe.io.Input) (global::haxe.lang.Runtime.getField(this.file, "io", 23526, true)) ).readBytes(buf, 0, size);
							}
							catch (global::System.Exception __temp_catchallException49)
							{
								#line 482 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								object __temp_catchall50 = __temp_catchallException49;
								#line 482 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								if (( __temp_catchall50 is global::haxe.lang.HaxeException )) 
								{
									#line 482 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									__temp_catchall50 = ((global::haxe.lang.HaxeException) (__temp_catchallException49) ).obj;
								}
								
								#line 482 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								if (( __temp_catchall50 is global::haxe.io.Eof )) 
								{
									#line 482 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									global::haxe.io.Eof e = ((global::haxe.io.Eof) (__temp_catchall50) );
									#line 482 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									{
										#line 482 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
										break;
									}
									
								}
								 else 
								{
									#line 482 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									throw;
								}
								
							}
							
							
							((global::haxe.io.Output) (global::haxe.lang.Runtime.getField(sock, "output", 209784577, true)) ).writeFullBytes(buf, 0, len);
							{
								#line 484 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								object __temp_dynop40 = this.file;
								#line 484 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								global::haxe.lang.Runtime.setField_f(__temp_dynop40, "size", 1280549057, ((double) (( ((int) (global::haxe.lang.Runtime.getField_f(__temp_dynop40, "size", 1280549057, true)) ) - ((int) (len) ) )) ));
							}
							
						}
						
						#line 486 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						global::haxe.lang.Runtime.callField(sock, "write", 1348037855, new global::Array<object>(new object[]{"\r\n"}));
						global::haxe.lang.Runtime.callField(sock, "write", 1348037855, new global::Array<object>(new object[]{"--"}));
						global::haxe.lang.Runtime.callField(sock, "write", 1348037855, new global::Array<object>(new object[]{boundary}));
						global::haxe.lang.Runtime.callField(sock, "write", 1348037855, new global::Array<object>(new object[]{"--"}));
					}
					
					#line 491 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					this.readHttpResponse(api, sock);
					global::haxe.lang.Runtime.callField(sock, "close", 1214453688, default(global::Array));
				}
				catch (global::System.Exception __temp_catchallException47)
				{
					object __temp_catchall48 = __temp_catchallException47;
					#line 493 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					if (( __temp_catchall48 is global::haxe.lang.HaxeException )) 
					{
						#line 493 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						__temp_catchall48 = ((global::haxe.lang.HaxeException) (__temp_catchallException47) ).obj;
					}
					
					#line 493 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					{
						#line 493 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						object e1 = __temp_catchall48;
						try 
						{
							#line 494 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							global::haxe.lang.Runtime.callField(sock, "close", 1214453688, default(global::Array));
						}
						catch (global::System.Exception __temp_catchallException45)
						{
							#line 494 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							object __temp_catchall46 = __temp_catchallException45;
							#line 494 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							if (( __temp_catchall46 is global::haxe.lang.HaxeException )) 
							{
								#line 494 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								__temp_catchall46 = ((global::haxe.lang.HaxeException) (__temp_catchallException45) ).obj;
							}
							
							#line 494 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							{
								#line 494 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								object e2 = __temp_catchall46;
								#line 494 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								{
								}
								
							}
							
						}
						
						
						this.onError.__hx_invoke1_o(default(double), global::Std.@string(e1));
					}
					
				}
				
				
			}
			#line default
		}
		
		
		public virtual   void readHttpResponse(global::haxe.io.Output api, object sock)
		{
			unchecked 
			{
				#line 501 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				global::haxe.io.BytesBuffer b = new global::haxe.io.BytesBuffer();
				int k = 4;
				global::haxe.io.Bytes s = global::haxe.io.Bytes.alloc(4);
				global::haxe.lang.Runtime.callField(sock, "setTimeout", 735461151, new global::Array<object>(new object[]{this.cnxTimeout}));
				while (true)
				{
					int p = ((global::haxe.io.Input) (global::haxe.lang.Runtime.getField(sock, "input", 1042138122, true)) ).readBytes(s, 0, k);
					while (( p != k ))
					{
						p += ((global::haxe.io.Input) (global::haxe.lang.Runtime.getField(sock, "input", 1042138122, true)) ).readBytes(s, p, ( k - p ));
					}
					
					{
						#line 509 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						if (( ( k < 0 ) || ( k > s.length ) )) 
						{
							#line 509 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
						}
						
						#line 509 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						b.b.Write(s.b, 0, k);
					}
					
					switch (k)
					{
						case 1:
						{
							#line 512 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							byte c = s.b[0];
							if (( c == 10 )) 
							{
								goto label1;
							}
							
							if (( c == 13 )) 
							{
								k = 3;
							}
							 else 
							{
								#line 518 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								k = 4;
							}
							
							#line 511 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							break;
						}
						
						
						case 2:
						{
							#line 520 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							byte c1 = s.b[1];
							if (( c1 == 10 )) 
							{
								if (( s.b[0] == 13 )) 
								{
									goto label1;
								}
								
								k = 4;
							}
							 else 
							{
								if (( c1 == 13 )) 
								{
									k = 3;
								}
								 else 
								{
									#line 528 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									k = 4;
								}
								
							}
							
							#line 519 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							break;
						}
						
						
						case 3:
						{
							#line 530 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							byte c2 = s.b[2];
							if (( c2 == 10 )) 
							{
								#line 531 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								if (( s.b[1] != 13 )) 
								{
									#line 533 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									k = 4;
								}
								 else 
								{
									if (( s.b[0] != 10 )) 
									{
										k = 2;
									}
									 else 
									{
										#line 537 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
										goto label1;
									}
									
								}
								
							}
							 else 
							{
								if (( c2 == 13 )) 
								{
									#line 538 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									if (( ( s.b[1] != 10 ) || ( s.b[0] != 13 ) )) 
									{
										#line 540 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
										k = 1;
									}
									 else 
									{
										#line 542 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
										k = 3;
									}
									
								}
								 else 
								{
									#line 544 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									k = 4;
								}
								
							}
							
							#line 529 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							break;
						}
						
						
						case 4:
						{
							#line 546 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							byte c3 = s.b[3];
							if (( c3 == 10 )) 
							{
								#line 547 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								if (( s.b[2] != 13 )) 
								{
									#line 549 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									continue;
								}
								 else 
								{
									if (( ( s.b[1] != 10 ) || ( s.b[0] != 13 ) )) 
									{
										k = 2;
									}
									 else 
									{
										#line 553 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
										goto label1;
									}
									
								}
								
							}
							 else 
							{
								if (( c3 == 13 )) 
								{
									#line 554 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									if (( ( s.b[2] != 10 ) || ( s.b[1] != 13 ) )) 
									{
										#line 556 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
										k = 3;
									}
									 else 
									{
										#line 558 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
										k = 1;
									}
									
								}
								
							}
							
							#line 545 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							break;
						}
						
						
					}
					
				}
				
				#line 505 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				label1: {};
				#line 565 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				global::Array<object> headers = global::haxe.lang.StringExt.split(b.getBytes().toString(), "\r\n");
				#line 567 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				string response = global::haxe.lang.Runtime.toString(headers.shift().@value);
				global::Array<object> rp = global::haxe.lang.StringExt.split(response, " ");
				global::haxe.lang.Null<int> status = global::Std.parseInt(global::haxe.lang.Runtime.toString(rp[1]));
				if (( global::haxe.lang.Runtime.eq((status).toDynamic(), 0) || global::haxe.lang.Runtime.eq((status).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic()) )) 
				{
					throw global::haxe.lang.HaxeException.wrap("Response status error");
				}
				
				#line 574 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				headers.pop();
				headers.pop();
				this.responseHeaders = new global::haxe.ds.StringMap<object>();
				global::haxe.lang.Null<int> size = default(global::haxe.lang.Null<int>);
				bool chunked = false;
				{
					#line 579 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					int _g = 0;
					#line 579 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					while (( _g < headers.length ))
					{
						#line 579 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						string hline = global::haxe.lang.Runtime.toString(headers[_g]);
						#line 579 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						 ++ _g;
						global::Array<object> a = global::haxe.lang.StringExt.split(hline, ": ");
						string hname = global::haxe.lang.Runtime.toString(a.shift().@value);
						string hval = ( (( a.length == 1 )) ? (global::haxe.lang.Runtime.toString(a[0])) : (a.@join(": ")) );
						this.responseHeaders.@set(hname, hval);
						{
							#line 584 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							string _g1 = hname.ToLower();
							#line 584 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							switch (_g1)
							{
								case "content-length":
								{
									#line 586 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									size = new global::haxe.lang.Null<int>(global::Std.parseInt(hval).@value, true);
									#line 586 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									break;
								}
								
								
								case "transfer-encoding":
								{
									#line 588 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									chunked = string.Equals(hval.ToLower(), "chunked");
									#line 588 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
				#line 593 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				this.onStatus.__hx_invoke1_o(default(double), (status).toDynamic());
				#line 595 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				global::EReg chunk_re = new global::EReg(global::haxe.lang.Runtime.toString("^([0-9A-Fa-f]+)[ ]*\r\n"), global::haxe.lang.Runtime.toString("m"));
				this.chunk_size = new global::haxe.lang.Null<int>(default(global::haxe.lang.Null<int>).@value, true);
				this.chunk_buf = default(global::haxe.io.Bytes);
				#line 599 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				int bufsize = 1024;
				global::haxe.io.Bytes buf = global::haxe.io.Bytes.alloc(bufsize);
				if (global::haxe.lang.Runtime.eq((size).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) 
				{
					if ( ! (this.noShutdown) ) 
					{
						global::haxe.lang.Runtime.callField(sock, "shutdown", 1795947670, new global::Array<object>(new object[]{false, true}));
					}
					
					try 
					{
						#line 604 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						while (true)
						{
							#line 606 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							int len = ((global::haxe.io.Input) (global::haxe.lang.Runtime.getField(sock, "input", 1042138122, true)) ).readBytes(buf, 0, bufsize);
							if (chunked) 
							{
								#line 607 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								if ( ! (this.readChunk(chunk_re, api, buf, len)) ) 
								{
									#line 609 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									break;
								}
								
							}
							 else 
							{
								#line 611 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								api.writeBytes(buf, 0, len);
							}
							
						}
						
					}
					catch (global::System.Exception __temp_catchallException53)
					{
						#line 613 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						object __temp_catchall54 = __temp_catchallException53;
						#line 613 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						if (( __temp_catchall54 is global::haxe.lang.HaxeException )) 
						{
							#line 613 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							__temp_catchall54 = ((global::haxe.lang.HaxeException) (__temp_catchallException53) ).obj;
						}
						
						#line 613 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						if (( __temp_catchall54 is global::haxe.io.Eof )) 
						{
							#line 613 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							global::haxe.io.Eof e = ((global::haxe.io.Eof) (__temp_catchall54) );
							#line 613 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							{
								#line 613 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								{
								}
								
							}
							
						}
						 else 
						{
							#line 613 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							throw;
						}
						
					}
					
					
				}
				 else 
				{
					#line 616 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					api.prepare(size.@value);
					try 
					{
						#line 617 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						while (( size.@value > 0 ))
						{
							#line 619 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							int len1 = ((global::haxe.io.Input) (global::haxe.lang.Runtime.getField(sock, "input", 1042138122, true)) ).readBytes(buf, 0, ( (( size.@value > bufsize )) ? (bufsize) : (size.@value) ));
							if (chunked) 
							{
								#line 620 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								if ( ! (this.readChunk(chunk_re, api, buf, len1)) ) 
								{
									#line 622 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
									break;
								}
								
							}
							 else 
							{
								#line 624 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								api.writeBytes(buf, 0, len1);
							}
							
							size = new global::haxe.lang.Null<int>(((int) (( size.@value - new global::haxe.lang.Null<int>(len1, true).@value )) ), true);
						}
						
					}
					catch (global::System.Exception __temp_catchallException51)
					{
						#line 627 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						object __temp_catchall52 = __temp_catchallException51;
						#line 627 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						if (( __temp_catchall52 is global::haxe.lang.HaxeException )) 
						{
							#line 627 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							__temp_catchall52 = ((global::haxe.lang.HaxeException) (__temp_catchallException51) ).obj;
						}
						
						#line 627 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						if (( __temp_catchall52 is global::haxe.io.Eof )) 
						{
							#line 627 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							global::haxe.io.Eof e1 = ((global::haxe.io.Eof) (__temp_catchall52) );
							#line 627 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							{
								#line 627 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								throw global::haxe.lang.HaxeException.wrap("Transfert aborted");
							}
							
						}
						 else 
						{
							#line 627 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							throw;
						}
						
					}
					
					
				}
				
				#line 631 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				if (( chunked && (( ( ! (global::haxe.lang.Runtime.eq((this.chunk_size).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ) || ( this.chunk_buf != default(global::haxe.io.Bytes) ) )) )) 
				{
					throw global::haxe.lang.HaxeException.wrap("Invalid chunk");
				}
				
				if (( ( status.@value < 200 ) || ( status.@value >= 400 ) )) 
				{
					throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat("Http Error #", global::haxe.lang.Runtime.toString(status.@value)));
				}
				
				api.close();
			}
			#line default
		}
		
		
		public virtual   bool readChunk(global::EReg chunk_re, global::haxe.io.Output api, global::haxe.io.Bytes buf, int len)
		{
			unchecked 
			{
				#line 639 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				if (global::haxe.lang.Runtime.eq((this.chunk_size).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) 
				{
					if (( this.chunk_buf != default(global::haxe.io.Bytes) )) 
					{
						global::haxe.io.BytesBuffer b = new global::haxe.io.BytesBuffer();
						{
							#line 642 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							global::haxe.io.Bytes src = this.chunk_buf;
							#line 642 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							b.b.Write(src.b, 0, src.length);
						}
						
						{
							#line 643 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							if (( ( len < 0 ) || ( len > buf.length ) )) 
							{
								#line 643 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
								throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
							}
							
							#line 643 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							b.b.Write(buf.b, 0, len);
						}
						
						buf = b.getBytes();
						len += this.chunk_buf.length;
						this.chunk_buf = default(global::haxe.io.Bytes);
					}
					
					#line 651 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					if (chunk_re.match(buf.toString())) 
					{
						#line 653 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						object p = chunk_re.matchedPos();
						if (( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(p, "len", 5393365, true)) ), len) <= 0 )) 
						{
							string cstr = chunk_re.matched(1);
							this.chunk_size = new global::haxe.lang.Null<int>(global::Std.parseInt(global::haxe.lang.Runtime.concat("0x", cstr)).@value, true);
							if (string.Equals(cstr, "0")) 
							{
								this.chunk_size = new global::haxe.lang.Null<int>(default(global::haxe.lang.Null<int>).@value, true);
								this.chunk_buf = default(global::haxe.io.Bytes);
								return false;
							}
							
							#line 662 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
							len = ( ((int) (len) ) - ((int) (global::haxe.lang.Runtime.getField_f(p, "len", 5393365, true)) ) );
							return this.readChunk(chunk_re, api, buf.sub(((int) (global::haxe.lang.Runtime.getField_f(p, "len", 5393365, true)) ), len), len);
						}
						
					}
					
					#line 667 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					if (( len > 10 )) 
					{
						this.onError.__hx_invoke1_o(default(double), "Invalid chunk");
						return false;
					}
					
					#line 671 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					this.chunk_buf = buf.sub(0, len);
					return true;
				}
				
				#line 674 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				if (( this.chunk_size.@value > len )) 
				{
					{
						#line 675 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						global::haxe.Http __temp_nullbinop55 = this;
						#line 675 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						__temp_nullbinop55.chunk_size = new global::haxe.lang.Null<int>(((int) (( __temp_nullbinop55.chunk_size.@value - new global::haxe.lang.Null<int>(len, true).@value )) ), true);
					}
					
					api.writeBytes(buf, 0, len);
					return true;
				}
				
				#line 679 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				int end = ( this.chunk_size.@value + 2 );
				if (( len >= end )) 
				{
					if (( this.chunk_size.@value > 0 )) 
					{
						api.writeBytes(buf, 0, this.chunk_size.@value);
					}
					
					len -= end;
					this.chunk_size = new global::haxe.lang.Null<int>(default(global::haxe.lang.Null<int>).@value, true);
					if (( len == 0 )) 
					{
						return true;
					}
					
					return this.readChunk(chunk_re, api, buf.sub(end, len), len);
				}
				
				#line 689 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				if (( this.chunk_size.@value > 0 )) 
				{
					api.writeBytes(buf, 0, this.chunk_size.@value);
				}
				
				{
					#line 691 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					global::haxe.Http __temp_nullbinop56 = this;
					#line 691 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					__temp_nullbinop56.chunk_size = new global::haxe.lang.Null<int>(((int) (( __temp_nullbinop56.chunk_size.@value - new global::haxe.lang.Null<int>(len, true).@value )) ), true);
				}
				
				return true;
			}
			#line default
		}
		
		
		public  global::haxe.lang.Function onData;
		
		public  global::haxe.lang.Function onError;
		
		public  global::haxe.lang.Function onStatus;
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				switch (hash)
				{
					case 1136381564:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.file = ((object) (@value) );
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 1987394228:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.cnxTimeout = ((double) (@value) );
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					default:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
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
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				switch (hash)
				{
					case 1705565617:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.onStatus = ((global::haxe.lang.Function) (@value) );
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 157772329:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.onError = ((global::haxe.lang.Function) (@value) );
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 1693277929:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.onData = ((global::haxe.lang.Function) (@value) );
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 1836776262:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.@params = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 1661489734:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.headers = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 10663594:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.postData = global::haxe.lang.Runtime.toString(@value);
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 1136381564:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.file = ((object) (@value) );
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 660670753:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.chunk_buf = ((global::haxe.io.Bytes) (@value) );
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 1488620307:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.chunk_size = new global::haxe.lang.Null<int>(global::haxe.lang.Null<object>.ofDynamic<int>(@value).@value, true);
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 1137315269:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.responseHeaders = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 1987394228:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.cnxTimeout = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 1533657591:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.noShutdown = ((bool) (@value) );
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 1156121931:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.responseData = global::haxe.lang.Runtime.toString(@value);
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					case 5843823:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.url = global::haxe.lang.Runtime.toString(@value);
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return @value;
					}
					
					
					default:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
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
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				switch (hash)
				{
					case 1705565617:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.onStatus;
					}
					
					
					case 157772329:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.onError;
					}
					
					
					case 1693277929:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.onData;
					}
					
					
					case 380244791:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readChunk"), ((int) (380244791) ))) );
					}
					
					
					case 1196428959:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readHttpResponse"), ((int) (1196428959) ))) );
					}
					
					
					case 1855145886:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("customRequest"), ((int) (1855145886) ))) );
					}
					
					
					case 1149558607:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("request"), ((int) (1149558607) ))) );
					}
					
					
					case 1836776262:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.@params;
					}
					
					
					case 1661489734:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.headers;
					}
					
					
					case 10663594:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.postData;
					}
					
					
					case 1136381564:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.file;
					}
					
					
					case 660670753:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.chunk_buf;
					}
					
					
					case 1488620307:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return (this.chunk_size).toDynamic();
					}
					
					
					case 1137315269:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.responseHeaders;
					}
					
					
					case 1987394228:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.cnxTimeout;
					}
					
					
					case 1533657591:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.noShutdown;
					}
					
					
					case 1156121931:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.responseData;
					}
					
					
					case 5843823:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.url;
					}
					
					
					default:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
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
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				switch (hash)
				{
					case 1136381564:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.file)) );
					}
					
					
					case 1987394228:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.cnxTimeout;
					}
					
					
					default:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
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
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				switch (hash)
				{
					case 380244791:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return this.readChunk(((global::EReg) (dynargs[0]) ), ((global::haxe.io.Output) (dynargs[1]) ), ((global::haxe.io.Bytes) (dynargs[2]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ));
					}
					
					
					case 1196428959:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.readHttpResponse(((global::haxe.io.Output) (dynargs[0]) ), dynargs[1]);
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						break;
					}
					
					
					case 1855145886:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.customRequest(((bool) (dynargs[0]) ), ((global::haxe.io.Output) (dynargs[1]) ), dynargs[2], global::haxe.lang.Runtime.toString(dynargs[3]));
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						break;
					}
					
					
					case 1149558607:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						this.request(global::haxe.lang.Null<object>.ofDynamic<bool>(dynargs[0]));
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						break;
					}
					
					
					default:
					{
						#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("onStatus");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("onError");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("onData");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("params");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("headers");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("postData");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("file");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("chunk_buf");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("chunk_size");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("responseHeaders");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("cnxTimeout");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("noShutdown");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("responseData");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				baseArr.push("url");
				#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				{
					#line 49 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe
{
	public  class Fun_8e188927 : global::haxe.lang.Function 
	{
		public    Fun_8e188927(global::Array<bool> err, global::Array<object> output, global::Array<object> old, global::Array<object> me1) : base(1, 0)
		{
			unchecked 
			{
				#line 317 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				this.err = err;
				#line 317 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				this.output = output;
				#line 317 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				this.old = old;
				#line 317 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				this.me1 = me1;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 317 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				string e = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (global::haxe.lang.Runtime.toString(__fn_float1)) : (global::haxe.lang.Runtime.toString(__fn_dyn1)) );
				#line 321 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				((global::haxe.Http) (this.me1[0]) ).responseData = ((global::haxe.io.BytesOutput) (this.output[0]) ).getBytes().toString();
				#line 323 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				this.err[0] = true;
				((global::haxe.lang.Function) (this.old[0]) ).__hx_invoke1_o(default(double), e);
				#line 317 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				return default(object);
			}
			#line default
		}
		
		
		public  global::Array<bool> err;
		
		public  global::Array<object> output;
		
		public  global::Array<object> old;
		
		public  global::Array<object> me1;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe
{
	public  class Fun_d41d8cd9_1 : global::haxe.lang.Function 
	{
		public    Fun_d41d8cd9_1() : base(1, 0)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public static  global::haxe.Fun_d41d8cd9_1 __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 724 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				int status = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((int) (__fn_float1) )) : (((int) (global::haxe.lang.Runtime.toInt(__fn_dyn1)) )) );
				#line 724 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				{
				}
				
				#line 724 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				return default(object);
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe
{
	public  class Fun_d41d8cd9_0 : global::haxe.lang.Function 
	{
		public    Fun_d41d8cd9_0() : base(1, 0)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public static  global::haxe.Fun_d41d8cd9_0 __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 714 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				string msg = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (global::haxe.lang.Runtime.toString(__fn_float1)) : (global::haxe.lang.Runtime.toString(__fn_dyn1)) );
				#line 714 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				{
				}
				
				#line 714 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				return default(object);
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe
{
	public  class Fun_d41d8cd9 : global::haxe.lang.Function 
	{
		public    Fun_d41d8cd9() : base(1, 0)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public static  global::haxe.Fun_d41d8cd9 __hx_current;
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 704 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				string data = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (global::haxe.lang.Runtime.toString(__fn_float1)) : (global::haxe.lang.Runtime.toString(__fn_dyn1)) );
				#line 704 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				{
				}
				
				#line 704 "C:\\HaxeToolkit\\haxe/std/haxe/Http.hx"
				return default(object);
			}
			#line default
		}
		
		
	}
}


