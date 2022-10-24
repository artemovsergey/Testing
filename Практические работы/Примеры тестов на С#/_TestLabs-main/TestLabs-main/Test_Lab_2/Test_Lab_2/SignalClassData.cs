using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SignalClassData
{
    public double[] Samples = new double[] { 0, 1, 1, -2.3, -2.3, 1.4, 3, 6, 7.8, 7.6 };
    public int alreadyExistsCount = 0;
    public string logPath = "results.log";
    public string logName = "results", currPath;

    public double[] GetSamplesArray()
    {
        return Samples;
    }
    public void SetSamplesArray(double[] array)
    {
        Samples = array;
    }
}

