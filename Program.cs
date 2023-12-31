﻿namespace H_W_Mod3_7
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            string configFilePath = "config.json";
            Config config = Config.ReadFromJsonFile(configFilePath);

            Logger logger = new Logger(config.N);
            App app = new App(logger);

            await app.RunAsync();
        }
    }
}