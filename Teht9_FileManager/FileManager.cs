using System;
using System.IO;
using System.Text;

namespace Teht9_FileManager
{
    // Custom exception
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {

        }
    }

    class FileManager
    {
        private string filePath;

        // Constructor
        public FileManager()
        {
            this.filePath = string.Empty;
        }

        // Constructor
        public FileManager(string filePath)
        {
            //this.filePath = string.Empty;
            this.filePath = filePath;
        }

        public string ReadWords()
        {
            string content = string.Empty;
            try
            {
                content = ReadFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return content;
        }

        /* Method reads file from a local 
         * directory path.
         */
        private string ReadFile()
        {
            if (!File.Exists(filePath))
            {
                // Throw exception if file does not exists
                //throw new FileNotFoundException("File not available");
                throw new WordListNotFoundException("File not available");
            }

            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
            return fileContent;
        }
    }
}
