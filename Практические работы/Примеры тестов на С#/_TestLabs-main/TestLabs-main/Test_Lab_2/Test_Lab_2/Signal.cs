using System;
using System.IO;
using System.Collections.Generic;

public class Signal: SignalClassData
{
    public readonly ISignal _signalProcessor;
    public Signal(ISignal signalProcessor)
    {
        _signalProcessor = signalProcessor;
        Samples = _signalProcessor.FullRectify();
    }

    public void FullRectify()
    {
        _signalProcessor.FullRectify();
    }
}
