using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Linq.Expressions;

namespace Week09DemoB_FileIO
{
    public static class MyFiles
    {
        public static bool WriteToFile(string fileName, string content)
        {
            try
            {
                //StreamWriter sw = new StreamWriter(fileName);
                //sw.WriteLine(content);
                //sw.Close();

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.Write(content);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error writing to file: " + ex.Message);
            }
            
        }

        public static string ReadFromFile(string fileName)
        {
            //StreamReader reader = new StreamReader(fileName);
            //string content = reader.ReadToEnd();
            //reader.Close();
            //return content;

            String contents = String.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {  contents = sr.ReadToEnd(); }
            }
            catch (FileNotFoundException ex)
            { throw new Exception("File not found: " + ex.Message); }
            catch (Exception ex)
            {
                throw new Exception("Error reading file: " + ex.Message);
            }
            finally
            {
                // do stuff here that always has to happen
            }
            return contents;
        }

            public static void AppendToFile(string fileName, string content)
        {
            StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine(content);
            writer.Close();
        }

        public static void WriteToFile(string fileName, string[] content)
        {
            StreamWriter writer = new StreamWriter(fileName);
            foreach (string line in content)
            {
                writer.WriteLine(line);
            }
            writer.Close();
        }

        public static string[] ReadFromFileToArray(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            List<string> content = new List<string>();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                content.Add(line);
            }
            reader.Close();
            return content.ToArray();
        }

        public static void AppendToFile(string fileName, string[] content)
        {
            StreamWriter writer = new StreamWriter(fileName, true);
            foreach (string line in content)
            {
                writer.WriteLine(line);
            }
            writer.Close();
        }

    }
}
