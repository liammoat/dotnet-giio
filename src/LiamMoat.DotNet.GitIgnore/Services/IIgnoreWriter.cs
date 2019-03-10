using System.Threading.Tasks;

namespace LiamMoat.DotNet.GitIgnore.Services
{
    public interface IIgnoreWriter
    {
        Task WriteIgnoreFileAsync(string contents);
    }
}
