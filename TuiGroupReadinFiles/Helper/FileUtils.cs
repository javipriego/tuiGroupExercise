using System;
using System.IO;
using TuiGroupReadinFiles.Enum;

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
        /// <remarks>Is obsolete use readFile</remarks>
        /// <returns></returns>
        public static string readTextFile(string path, bool encrypted = false, RoleType role = RoleType.Anonymous)
        {
            return readFile(path, role, encrypted);
        }

        /// <summary>
        /// Read a XML file
        /// </summary>
        /// <param name="path">path of the filename</param>
        /// <remarks>Is obsolete use readFile</remarks>
        /// <returns></returns>
        public static string readXMLFile(string path, RoleType role = RoleType.Anonymous, bool encrypted = false)
        {
            return readFile(path, role, encrypted);
        }

        /// <summary>
        /// Read a file (XML or TXT)
        /// </summary>
        /// <param name="path"></param>
        /// <param name="role"></param>
        /// <param name="encrypted"></param>
        /// <returns></returns>
        public static string readFile(string path, RoleType role = RoleType.Anonymous, bool encrypted = false)
        {
            var readText = string.Empty;
            try
            {
                // This text is added only once to the file.
                if (File.Exists(path))
                {
                    FileInfo fileInfo = new FileInfo(path);

                    //If the file has more than 10 minutes created need to be Admin to access
                    if (fileInfo.CreationTime.AddMinutes(10) > DateTime.Now || RoleType.Admin.Equals(role))
                    {
                        // Open the file to read from.
                        readText = File.ReadAllText(path);

                        // decrypt the file
                        if (encrypted)
                        {
                            readText = decryptFile(readText);
                        }
                    }
                    else
                    {
                        throw new Exception("The user has no grant to access this file");
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
        /// Read a JSON file
        /// </summary>
        /// <param name="path">path of the filename</param>
        /// <returns></returns>
        public static string readJSONFile(string path, bool encrypted = false)
        {
            var text = string.Empty;
            try
            {
                var readText = File.ReadAllText(path);
                dynamic deserializeJson = Newtonsoft.Json.JsonConvert.DeserializeObject(readText);
                text = deserializeJson[0].hws[2];
                if (encrypted)
                {
                    readText = decryptFile(readText);
                }
                return text;
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
