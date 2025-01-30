using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pong.Classes
{
    public static class GameSettings
    {
        public static bool sfx_muted = false;

        public static Dictionary<string, object> settingsData = new Dictionary<string, object>()
        {
            { "sfx_muted", sfx_muted },
        };

        public static void saveSettings()
        {
            try
            {
                settingsData["sfx_muted"] = sfx_muted;

                var json = JsonSerializer.Serialize(settingsData);
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "settings.json";
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Problem while saving settings {ex.Message}");
            }
            finally
            {

            }
        }

        public static void loadSettings()
        {
            try
            {
                string filepath = $"{AppDomain.CurrentDomain.BaseDirectory + "settings.json"}";
                if (!File.Exists(filepath))
                {
                    saveSettings();
                }
                var json = File.ReadAllText(filepath);
                settingsData = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
                if (settingsData != null)
                {
                    sfx_muted = Convert.ToBoolean(settingsData["sfx_muted"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Problem while loading settings {ex.Message}");
            }
            finally
            {

            }
        }
    }
}
