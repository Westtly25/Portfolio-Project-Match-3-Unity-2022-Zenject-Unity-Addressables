using UnityEngine;
using Assets.Scripts.Runtime.Save_System;

namespace Assets.Scripts.Runtime.Utilities
{
    public class Logger : ILogger
    {
        private const string FILE = "log.txt";
        private readonly string path;

        private FileHandler handler = new FileHandler();

        public Logger()
        {
            handler = new();

            path = Application.persistentDataPath + FILE;
        }

        public async void Log(string msg) =>
            await handler.WriteFileAsync(path, msg);
    }
}
