using NUnit.Framework;
using System;
using _1_1;

namespace _1_1_Tests
{
    [TestFixture]
    public class ReportViewerWithMockTests
    {
        Classes.MockMergeTemporaryFiles _fa;
        _1_1.ReportViewer _rv;

        [Test]
        public void FileServiceHasCalledWithException()
        {
            _fa = new Classes.MockMergeTemporaryFiles(null);
            _rv = new _1_1.ReportViewer(_fa);

            Assert.Multiple( () =>
            {
                Assert.Throws<ArgumentException>(() => _rv.PrepareData("dir"));
                Assert.That(_fa.MockCalls, Is.EqualTo(1));
            });
        }

        [Test]
        public void FileServiceHasCalledOnseWithoutException()
        {
            _fa = new Classes.MockMergeTemporaryFiles(new string[] { "1.tmp", });
            _rv = new _1_1.ReportViewer(_fa);

            _rv.PrepareData("dir");

            Assert.That(_fa.MockCalls, Is.EqualTo(1));
        }
    }
}
