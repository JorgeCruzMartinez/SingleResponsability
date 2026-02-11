using System.Web;

namespace SingleResponsability
{
    public class FileProcessor
    {
        private readonly string fullFilePath;

        public FileProcessor(string fullFilePath)
        {
            this.fullFilePath = fullFilePath;
        }

        public string ReadAllText()
        {
            return HttpUtility.HtmlEncode(File.ReadAllText(fullFilePath));
        }

        public void WriteToFile(string text)
        {
            string outputFilePath = Path.GetDirectoryName(fullFilePath) + Path.DirectorySeparatorChar +
                                 Path.GetFileNameWithoutExtension(fullFilePath) + ".html";
            using StreamWriter file = new(outputFilePath);
            file.Write(text);
        }
    }
}
