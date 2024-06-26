﻿namespace Muza.Preprocess.WaveNS;

public partial class Wave
{
    public static Wave operator *(Wave wave, double amplitude)
    {
        foreach (var frame in wave)
            wave[frame] *= amplitude;
        return wave;
    }

    public static Wave operator /(Wave wave, double amplitude)
    {
        foreach (var frame in wave)
            wave[frame] /= amplitude;
        return wave;
    }
}
