using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invox.Models;
using System.IO;
using System.Text.Json;

namespace Invox.Common
{
    public static class ConfigHelper
    {
        private static readonly string ConfigPath = "dbconfig.json";

        public static void SaveConfig(DbConfig config)
        {
            var json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ConfigPath, json);
        }

        public static DbConfig LoadConfig()
        {
            if (!File.Exists(ConfigPath))
                return null;

            var json = File.ReadAllText(ConfigPath);
            return JsonSerializer.Deserialize<DbConfig>(json);
        }

        public static bool ConfigExists() => File.Exists(ConfigPath);
    }
}
