package milkshake.game.sound;

class SoundManager
{
    public function new()
    {
        Waud.init();
    }

    public function playSound(url:String, autoPlay:Bool = false, loop:Bool = true, volume:Float = 0.5, onLoad:?IWaudSound -> Void = null):IWaudSound
    {
        return new WaudSound(url, { autoplay: autoPlay, loop: loop, volume: volume, onload: onLoad });
    }
}
