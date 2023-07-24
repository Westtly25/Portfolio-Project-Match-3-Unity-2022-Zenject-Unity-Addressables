using UnityEngine;

namespace Assets.Scripts.Runtime.Save_System
{
    public class SaveHandler
    {
        private const string FILE_PATH = "";
        private readonly FileHandler fileHandler;
        
        private SaveData saveData;

        public SaveHandler()
        {
            fileHandler = new();
        }

        public async void Save() =>
            await fileHandler.WriteFileAsync(FILE_PATH, ConvertToString());

        public async void Load()
        {
            string data = await fileHandler.ReadFileAsync(FILE_PATH);

            saveData = data != null ? 
                ConvertFromJson(data) :
                NewSaveData();
        }

        private SaveData ConvertFromJson(string data) =>
            JsonUtility.FromJson<SaveData>(data);

        private SaveData NewSaveData() => new();

        private string ConvertToString()
            => JsonUtility.ToJson(saveData);
    }
}