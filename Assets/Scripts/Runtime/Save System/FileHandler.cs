using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Runtime.Save_System
{
    public class FileHandler
    {
        public FileHandler()
        {
        }

        public async Task<string> ReadFileAsync(string filePath)
        {
            using FileStream sourceStream = new(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 4096, useAsync: true);
            using StreamReader reader = new(sourceStream);
            StringBuilder sb = new();

            while (!reader.EndOfStream)
            {
                string line = await reader.ReadLineAsync();
                sb.AppendLine(line);
            }

            return sb.ToString();
        }

        public async Task WriteFileAsync(string filePath, string text)
        {
            using FileStream destinationStream = new(filePath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true);
            using StreamWriter writer = new(destinationStream);
            await writer.WriteLineAsync(text);
        }
    }
}