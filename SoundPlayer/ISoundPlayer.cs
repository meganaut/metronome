namespace metronome.SoundPlayer
{
    public interface ISoundPlayer
    {
        void Play(SoundTypes type);
        
        void Stop();
    }
}