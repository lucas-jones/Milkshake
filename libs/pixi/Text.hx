package pixi;
@:native('PIXI.Text')
extern class Text extends Sprite {
  public function new(text:String, ?style:Dynamic);
  public function setStyle(style:Dynamic):Void;
  public function setText(text:String):Void;
}