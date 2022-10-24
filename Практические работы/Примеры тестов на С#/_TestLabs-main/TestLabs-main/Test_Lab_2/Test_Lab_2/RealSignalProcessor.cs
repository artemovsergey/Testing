using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class RealSignalProcessor: SignalClassData, ISignal
{
    double[] resultArray;

    public void CreateLogFile()
    {
        if (!File.Exists(logPath))
        {
            File.Create(logPath);
            WriteArrayCalculatedValues();
        }    
        else CreateNextCopy();
    }
    public void CreateNextCopy()
    {
        string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
        foreach (string file in files)
        {
            if (file.Contains(logName))
               alreadyExistsCount++;     
        }
        currPath = logName + $"({alreadyExistsCount})" + ".log";
        File.Create(currPath).Close();
    }
    public double[] FullRectify()
    {
        resultArray = ExerciseClasses.ArrayProcessor.SortAndFilter(Samples);
        CreateLogFile();
        WriteArrayCalculatedValues();
        return resultArray;
    }

    public void WriteFile(string data)
    {
        using (StreamWriter writer = new StreamWriter(currPath, true))
            writer.Write(data + "\n");
    }

    public double GetArrayDifference()
    {
        double diff = Samples[0];
        foreach (double elem in Samples)
            diff -= elem;
        return diff;
    }

    public decimal GetArraySum() => (decimal)Samples.Sum();
    public decimal GetArrayAverage() => (decimal)(Samples.Sum() / Samples.Length);
    public void WriteArrayCalculatedValues()
    {
        WriteFile(GetArraySum().ToString());
        WriteFile(GetArrayAverage().ToString());
        WriteFile(GetArrayDifference().ToString());
    }

    public double[] GetSamples()
    {
        return resultArray;
    }
}

