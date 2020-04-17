using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Showcase
{
    class MonkeyTapWithSoundPage : MonkeyTapPage
    {
        const int errorDuration = 500;

        // Diminished 7th in 1st inversion: C, Eb, F#, A
        double[] frequencies = { 523.25, 622.25, 739.99, 880 };
        double endFrequency = 65.4;
        List<byte[]> buffers;
        byte[] endBuffer;

        public MonkeyTapWithSoundPage()
        {
            buffers = new List<byte[]>();
            for (int i = 0; i < frequencies.Length; i++)
            {
                buffers.Add(SoundPlayer.MakeBuffer(frequencies[i]));
            }
            endBuffer = SoundPlayer.MakeBuffer(endFrequency, errorDuration);
        }

        protected override void FlashBoxView(int index)
        {
            SoundPlayer.PlayBufferedSound(buffers[index]);
            base.FlashBoxView(index);
        }

        protected override void EndGame()
        {
            SoundPlayer.PlayBufferedSound(endBuffer);
            base.EndGame();
        }
    }
}