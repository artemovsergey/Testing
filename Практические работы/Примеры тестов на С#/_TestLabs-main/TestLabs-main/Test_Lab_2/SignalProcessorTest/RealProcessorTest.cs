using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Moq;

[TestClass]
public class RealProcessorTest
{
    public static double[] expectedSamplesSortedFiltered = { -2.3, 0, 1, 1, 1.4, 3, 6, 7.6, 7.8 };

    public static RealSignalProcessor processor = new RealSignalProcessor();
    public static Signal realSignal = new Signal(processor);

    private readonly Mock<ISignal> _signalMoqMock = new Mock<ISignal>();
    private readonly Mock<ISignal> _signalMoqStub = new Mock<ISignal>();
    
    [TestMethod]
    public void FrameworkMockTest()
    {
        var signal = new Signal(_signalMoqMock.Object);
        _signalMoqMock.Verify(r => r.FullRectify());
    }

    [TestMethod]
    public void FrameworkStubTest()
    {
        _signalMoqStub.Setup(r => r.FullRectify()).Returns(expectedSamplesSortedFiltered);
        var signal = new Signal(_signalMoqStub.Object);

        signal.FullRectify();
        Assert.AreEqual(signal.GetSamplesArray(), expectedSamplesSortedFiltered);
    }

    [TestMethod]
    public void SignalDataLogPathExist()
    {
        realSignal.FullRectify();
        Assert.IsTrue(File.Exists(realSignal.logPath));
    }

    [TestMethod]
    public void SignalSamplesSortedAndFiltered()
    {
        CollectionAssert.AreEqual(expectedSamplesSortedFiltered, realSignal.Samples);    
    }

    [TestMethod]
    public void SignalSamplesSumIsCorrect()
    {
        double expected = 23.2;
        double actual = (double)decimal.Round(processor.GetArraySum(), 1);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SignalSamplesDifferenceIsCorrect()
    {
        double expected = -25.5;
        double actual = processor.GetArrayDifference();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SignalSamplesAverageIsCorrect()
    {
        double expected = 2.3;
        double actual = (double)decimal.Round(processor.GetArrayAverage(), 1);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SignalSamplesLogIsNotEmpty()
    {
        //using ()
    }
}

