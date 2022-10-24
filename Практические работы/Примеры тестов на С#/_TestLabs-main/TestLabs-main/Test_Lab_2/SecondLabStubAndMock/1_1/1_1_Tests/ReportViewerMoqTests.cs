using NUnit.Framework;
using System;
using _1_1;
using Moq;

namespace _1_1_Tests
{
    [TestFixture]
    public class ReportViewerMoqTests
    {
        Mock<IFileAccesser> _mockFA;
        ReportViewer rv;

        [Test]
        public void DirectoryDoesntExistException()
        {
            _mockFA = new Mock<IFileAccesser>();
            rv = new ReportViewer(_mockFA.Object);

            _mockFA
                .Setup(x => x.MergeTemporaryFiles(It.IsAny<string>()))
                .Throws<ArgumentException>();

            try
            {
                rv.PrepareData("dir");
            }
            catch { }

            _mockFA.Verify(x => x.MergeTemporaryFiles(It.IsAny<string>()));
        }

        [Test]
        public void DirectoryIsEmptyException()
        {
            _mockFA = new Mock<IFileAccesser>();
            rv = new ReportViewer(_mockFA.Object);

            _mockFA
                .Setup(x => x.MergeTemporaryFiles(It.IsAny<string>()))
                .Returns(0);

            try
            {
                rv.PrepareData("dir");
            }
            catch { }

            _mockFA.Verify(x => x.MergeTemporaryFiles(It.IsAny<string>()), Times.Once());
        }

        [Test]
        public void DirectoryHasFiles()
        {
            _mockFA = new Mock<IFileAccesser>();
            rv = new ReportViewer(_mockFA.Object);

            _mockFA
                .Setup(x => x.MergeTemporaryFiles(It.IsAny<string>()))
                .Returns(2);

            rv.PrepareData("dir");

            _mockFA.Verify(x => x.MergeTemporaryFiles(It.IsAny<string>()), Times.Once());
        }

    }
}
