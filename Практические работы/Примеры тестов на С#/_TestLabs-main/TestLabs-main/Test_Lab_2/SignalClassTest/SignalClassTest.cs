using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

[TestClass]
public class SignalClassTest
{
    [TestMethod]
    public void SignalClassSampleSorted()
    {
        // Modelling correct state 
        var stub = new SignalClassTestStub();
        Signal testSignal = new(stub);
        Assert.AreEqual(stub.Samples, testSignal.Samples);
    }

     [TestMethod]
    public void FullRectifyCallCreateNextCopy()
    {
        Signal testSignal = new Signal(new SignalClassTestMoq());
        testSignal.FullRectify();

        // Checking Signal calls behaviour 
        Assert.IsTrue(SignalClassTestMoq.IsFilesCreated);
    }
}

