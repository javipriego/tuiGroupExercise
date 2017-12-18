using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TuiGroupReadinFiles.Helper;
using TuiGroupReadinFiles.Enum;

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

        [TestMethod]
        public void readEncryptedTextFile_WhenPruebaText_ReadFileIsCorrect()
        {
            var read = FileUtils.readTextFile(@"c:\filesTUI\javiEncrypted.txt",true);
            Assert.IsTrue(read != string.Empty);
        }

        [TestMethod]
        public void readAdminXMLFile_WhenPruebaText_ReadFileIsCorrect()
        {
            var read = FileUtils.readXMLFile(@"c:\filesTUI\javiAdmin.txt", RoleType.Admin);
            Assert.IsTrue(read != string.Empty);
        }


        [TestMethod]
        public void readAnonymousXMLFile_WhenPruebaText_ReadFileIsNotCorrect()
        {
            var read = FileUtils.readXMLFile(@"c:\filesTUI\javiAdmin.txt", RoleType.Anonymous);
            Assert.IsTrue(read == string.Empty);
        }
    }
}
