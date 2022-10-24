using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SignalClassTestStub: ISignal
{
    public double[] Samples = { -2.3, 0, 1, 1, 1.4, 3, 6, 7.6, 7.8 };
    public double[] GetSamples()
    {
        return Samples;
    }
    public void CreateNextCopy() {}
    public double[] FullRectify() 
    {
        return Samples;
    }
}

