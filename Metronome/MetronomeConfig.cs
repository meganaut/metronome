using metronome.SoundPlayer;

namespace metronome.Metronome{
    public class MetronomeConfig{
        public int Bpm {get;set;}

        public int Beats {get;set;}

        public int BarLength {get;set;}

        public SoundTypes PrimarySound {get;set;}

        public SoundTypes AccentSound {get; set;}

        public bool ShouldAccent {get;set;}
    }
}