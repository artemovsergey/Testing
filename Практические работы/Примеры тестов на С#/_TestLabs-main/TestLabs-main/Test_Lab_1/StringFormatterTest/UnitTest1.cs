using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringFormatterTest
{
    [TestClass]
    public class UnitTest1
    {
        public string expected = "MYFILE.TMP";

        [TestMethod]
        public void TestWithExt()
        {
            // arrange
            string pathWithExt = @"C:\User\Desktop\MyFile.txt";
            
            // act
            string actual = ExerciseClasses.StringFormatter.ShortFileString(pathWithExt);       

            // assert
            Assert.AreEqual(expected, actual);      
        }

        [TestMethod]
        public void TestWithoutExt()
        {
            // arrange
            string pathNoExt = @"C:\User\Desktop\MyFile";

            // act
            string actual = ExerciseClasses.StringFormatter.ShortFileString(pathNoExt);
            // asert

            Assert.AreEqual(expected, actual);
        }

    }
}
