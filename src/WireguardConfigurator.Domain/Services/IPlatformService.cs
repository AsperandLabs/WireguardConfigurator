using System.Collections.Generic;

namespace WireguardConfigurator.Domain.Services
{
    public interface IPlatformService
    {
        IEnumerable<string> ReadFile(string path);
        void WriteFile(string contents);
        T? ReadTomlFile<T>(string path);
        void WriteTomlFile<T>(T obj, string path);
        T? ReadJsonFile<T>(string path);
        void WriteJsonFile<T>(T obj, string path);
    }
}