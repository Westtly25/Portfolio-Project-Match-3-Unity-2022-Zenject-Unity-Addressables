using Cysharp.Threading.Tasks;

namespace Assets.Scripts.Runtime.Save_System
{
    public interface IFileHandler
    {
        UniTask<string> ReadFileAsync(string filePath);
        UniTask WriteFileAsync(string filePath, string text);
    }
}