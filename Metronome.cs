using System;
using System.Threading;
using System.Threading.Tasks;

namespace metronome{
    public class Metronome{
        private int _bpm;
        private int _beats;
        private int _barLength;
        private bool _accent;

        //private Sound _beatSound;  import the Bassoon library for cross platform audio

        

        public Metronome(int bpm, int beats, int barLength, bool accent){
            _bpm = bpm;
            _beats = beats;
            _barLength = barLength;
            _accent = accent;
        }

        private async Task Loop(CancellationToken cancelToken)
        {
            // convert bpm to milliseconds
            var delay = (int)(60F / _bpm * 1000F);
            while(!cancelToken.IsCancellationRequested)
            {
                // play sound

                // wait period
                await Task.Delay(delay, cancelToken);
            }
        }


        public static Metronome Default()
        {
            return new Metronome(120, 4, 4, true);
        }

    }
}