package pixi;
@:native('PIXI.MovieClip')
extern class MovieClip extends Sprite {
  public function new(textures:Array<Texture>):Void;
  public function gotoAndPlay(frameNumber:Int):Void;
  public function gotoAndStop(frameNumber:Int):Void;
  public function play():Void;
  public function stop():Void;

  public var animationSpeed:Float;
  public var currentFrame:Int;
  public var loop:Bool;
  public var onComplete:Void->Void;
  public var playing:Bool;
  public var textures:Array<Texture>;
}