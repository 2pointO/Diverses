using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFile
{
    class TextFileOperations
    {

        public static string ReadTextFileContents(string fileName)
        {
            return File.ReadAllText(fileName);
        }
        public static void WriteTextFileContents(string fileName, string text)
        {
            File.WriteAllText(fileName,text);
        }
        public static string ReadAndFilterTextFileContents(string fileName)
        {
            StringBuilder fileContent = new StringBuilder();
            int charCode;
            StreamReader fileReader = new StreamReader(fileName);

            while((charCode = fileReader.Read()) != -1)
            {
                switch (charCode)
                {
                    case 34: fileContent.Append("&quot;");
                        break;
                    case 38: // &
                        fileContent.Append("&amp;");
                        break;
                    case 39: // '
                        fileContent.Append("&apos;");
                        break;
                    case 60: // <
                        fileContent.Append("&lt;");
                        break;
                    case 62: // >
                        fileContent.Append("&gt;");
                        break;
                    default: fileContent.Append((char)charCode);
                        break;
                }
            }
            return fileContent.ToString();
        }

    }

}
