namespace Assets.Scripts.Runtime.Save_System
{
    public interface ISaveLoadHandler
    {
        void LoadAsync();
        void SaveAsync();
    }
}