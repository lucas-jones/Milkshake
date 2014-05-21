package milkshake.game.network;
import js.node.SocketIo.SocketNamespace;
import js.node.SocketIoClient.Io;

class NetworkManager
{
	public var socket:SocketNamespace;
	
	public function new(url:String) 
	{
		socket = Io.connect(url);
	}
	
}