using System;
using System.Threading;
using System.Threading.Tasks;
using metronome.SoundPlayer;

namespace metronome.Metronome
{
    public class Metronome
    {
        private readonly MetronomeConfig _config;
        private readonly ISoundPlayer _player;

        public Metronome(MetronomeConfig config, ISoundPlayer player)
        {
            _config = config;
            _player = player;
        }

        private async Task Loop(CancellationToken cancelToken)
        {
            // convert bpm to milliseconds
            var delay = (int)(60F / _config.Bpm * 1000F);
            while (!cancelToken.IsCancellationRequested)
            {
                // play sound

                // wait period
                await Task.Delay(delay, cancelToken);
            }
        }
    }
}