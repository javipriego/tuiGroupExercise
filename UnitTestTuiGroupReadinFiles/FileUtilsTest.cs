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
            FileUtils.readTextFile(@"c:\javi.txt");
        }
    }
}
