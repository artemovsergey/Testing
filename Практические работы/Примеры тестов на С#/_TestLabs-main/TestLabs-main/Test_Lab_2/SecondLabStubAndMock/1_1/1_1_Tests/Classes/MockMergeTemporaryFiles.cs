using System;
using _1_1;

namespace _1_1_Tests.Classes
{
    public class MockMergeTemporaryFiles : IFileAccesser
    {
        string[] tmpFiles;
        public int MockCalls { get; private set; }
        public MockMergeTemporaryFiles(string[] files)
        {
            tmpFiles = files;
            MockCalls = 0;
        }
        public int MergeTemporaryFiles(string dir)
        {
            MockCalls++;
            if (!(tmpFiles is null))
            {
                return tmpFiles.Length;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
