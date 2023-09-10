using System.IO;
using Newtonsoft.Json;

namespace H_W_Mod3_7
{
    public class Config
    {
        public int N { get; set; }

        public static Config ReadFromJsonFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Config>(json);
        }
    }
}
