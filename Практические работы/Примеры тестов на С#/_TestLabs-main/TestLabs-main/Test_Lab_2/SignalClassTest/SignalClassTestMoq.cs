using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestClass]
class SignalClassTestMoq : ISignal
{
    public static bool IsFilesCreated = false;

    public double[] FullRectify()
    {
        CreateNextCopy();
        return null;
    }
    public void CreateNextCopy()
    {
        IsFilesCreated = true;
    }
    public double[] GetSamples()
    {
        return null; 
    }
}

