
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace milk
{
	public  interface IGame : global::haxe.lang.IHxObject 
	{
		   void setStage(global::PIXI.Stage stage);
		
		   void update(double delta);
		
	}
}


