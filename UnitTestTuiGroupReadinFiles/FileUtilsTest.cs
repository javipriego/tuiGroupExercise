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
            var read = FileUtils.readXMLFile(@"c:\filesTUI\javiAdmin.xml", RoleType.Admin);
            Assert.IsTrue(read != string.Empty);
        }
        
        [TestMethod]
        public void readAnonymousXMLFile_WhenPruebaText_ReadFileIsNotCorrect()
        {
            var read = FileUtils.readXMLFile(@"c:\filesTUI\javiAdmin.xml", RoleType.Anonymous);
            Assert.IsTrue(read == string.Empty);
        }

        [TestMethod]
        public void readAdminDEcryptedXMLFile_WhenPruebaText_ReadFileIsCorrect()
        {
            var read = FileUtils.readXMLFile(@"c:\filesTUI\javiDecryptedAdmin.xml", RoleType.Admin);
            Assert.IsTrue(read != string.Empty);
        }

        [TestMethod]
        public void readAdminTXTFile_WhenPruebaText_ReadFileIsCorrect()
        {
            var read = FileUtils.readXMLFile(@"c:\filesTUI\javiAdmin.txt", RoleType.Admin);
            Assert.IsTrue(read != string.Empty);
        }

        [TestMethod]
        public void readAnonymousTXTFile_WhenPruebaText_ReadFileIsNotCorrect()
        {
            var read = FileUtils.readXMLFile(@"c:\filesTUI\javiAdmin.txt", RoleType.Anonymous);
            Assert.IsTrue(read == string.Empty);
        }

        [TestMethod]
        public void readJSONFile_WhenPruebaText_ReadFileIsCorrect()
        {
            var read = FileUtils.readTextFile(@"c:\filesTUI\javi.json");
            Assert.IsTrue(read != string.Empty);
        }
        
        [TestMethod]
        public void readEncryptedJSONFile_WhenPruebaText_ReadFileIsCorrect()
        {
            var read = FileUtils.readTextFile(@"c:\filesTUI\javiEncrypted.json", true);
            Assert.IsTrue(read != string.Empty);
        }
    }
}
