using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TuiGroupReadinFiles.Helper;

namespace UnitTestTuiGroupReadinFiles
{
    [TestClass]
    public class FileUtilsTest
    {
        [TestMethod]
        public void readTextFile_WhenPruebaText_ReadFileIsCorrect()
        {
            var read = FileUtils.readTextFile(@"c:\filesTUI\javi.txt");
            Assert.IsTrue(read != string.Empty);
        }

        [TestMethod]
        public void readXMLFile_WhenPruebaText_ReadFileIsCorrect()
        {
            var read = FileUtils.readXMLFile(@"c:\filesTUI\javi.xml");
            Assert.IsTrue(read != string.Empty);
        }
    }
}
