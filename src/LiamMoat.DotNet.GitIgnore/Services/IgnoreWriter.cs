using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LiamMoat.DotNet.GitIgnore.Services
{
    public class IgnoreWriter : IIgnoreWriter
    {
        public async Task WriteIgnoreFileAsync(string contents)
        {
            string path = Directory.GetCurrentDirectory();
            string fileName = Path.Combine(path, ".gitignore");

            byte[] bytes = new UTF8Encoding(true).GetBytes(contents);

            using (var SourceStream = File.Open(fileName, FileMode.OpenOrCreate))
            {
                SourceStream.Seek(0, SeekOrigin.End);
                await SourceStream.WriteAsync(bytes, 0, bytes.Length);
            }
        }
    }
}
