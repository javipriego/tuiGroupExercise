using System;
using System.IO;

namespace TuiGroupReadinFiles.Helper
{
    /// <summary>
    /// Class with utils to read files
    /// </summary>
    public class FileUtils
    {
        /// <summary>
        /// Read a text file
        /// </summary>
        /// <param name="path">path of the filename</param>
        /// <returns></returns>
        public static string readTextFile(string path, bool encrypted = false)
        {
            var readText = string.Empty;
            try
            {                
                // This text is added only once to the file.
                if (File.Exists(path))
                {
                    // Open the file to read from.
                    readText = File.ReadAllText(path);

                    // decrypt the file
                    if (encrypted)
                    {
                       readText = decryptFile(readText);
                    }
                }
                return readText;
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return string.Empty;
            }
        }

        /// <summary>
        /// Read a XML file
        /// </summary>
        /// <param name="path">path of the filename</param>
        /// <returns></returns>
        public static string readXMLFile(string path)
        {
            var readText = string.Empty;
            try
            {
                // This text is added only once to the file.
                if (File.Exists(path))
                {
                    // Open the file to read from.
                    readText = File.ReadAllText(path);
                }
                return readText;
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return string.Empty;
            }
        }

        /// <summary>
        /// A tiny way to encrypt or decrypt is to do a reverse
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string decryptFile(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
