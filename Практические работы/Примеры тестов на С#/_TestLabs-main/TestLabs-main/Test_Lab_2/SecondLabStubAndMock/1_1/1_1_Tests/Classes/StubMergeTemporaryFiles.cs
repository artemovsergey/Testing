using System;
using System.Collections.Generic;
using System.Text;
using _1_1;

namespace _1_1_Tests.Classes
{
    public class StubMergeTemporaryFiles : IFileAccesser
    {
        string[] tmpFiles;
        public StubMergeTemporaryFiles(string[] files)
        {
            tmpFiles = files;
        }
        public int MergeTemporaryFiles(string dir)
        {
            if ( !(tmpFiles is null) )
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
