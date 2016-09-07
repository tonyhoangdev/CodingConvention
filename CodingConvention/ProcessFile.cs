using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodingConvention
{
    public class ProcessFile
    {
        // Path file in
        string pathFileIn = "";
        // Save file name
        string fileIn = "";
        // Content of file name;
        string fileContents = "";
        // Content of each line
        string[] lines;
        //
        StreamReader sr;

        public ProcessFile(string path)
        {
            pathFileIn = path;
            StringBuilder sb = new StringBuilder();

            sr = new StreamReader(path);
            try
            {
                using (sr)
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        sb.Append(line);
                    }
                }
                fileContents = sb.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }           
        }

        public string ReadFile()
        {
            return fileContents;
        }
    }
}
