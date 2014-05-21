package milkshake.core;
import pixi.BaseTexture;
import pixi.Point;
import pixi.Rectangle;
import pixi.Texture;

/**
 * ...
 * @author Milkshake-Inc
 */
class TextureMap extends Texture
{
	private var topLeft:Point;
	private var topRight:Point;
	private var bottomLeft:Point;
	private var bottomRight:Point;

	public function new(baseTexture:BaseTexture, ?frame:Rectangle) 
	{
		super(baseTexture, frame);
		
		topLeft = new Point(0,0);
		topRight = new Point(1,0);
		bottomLeft = new Point(0,0);
		bottomRight = new Point(1,1);
	}
	
	override private function _updateWebGLuvs():Void
	{
		super._updateWebGLuvs();
		
		this._uvs.x0 += topLeft.x;
		this._uvs.y0 += topLeft.y;
		
		this._uvs.x1 += topRight.x;
		this._uvs.y1 += topRight.y;
		
		this._uvs.x2 += bottomRight.x;
		this._uvs.y2 += bottomRight.y;
		
		this._uvs.x2 += bottomLeft.x;
		this._uvs.y2 += bottomLeft.y;
	}
	
}