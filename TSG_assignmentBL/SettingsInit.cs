using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TSG_assignmentBL.Models;

namespace TSG_assignmentBL
{
    public static class SettingsInit
    {
        private const string DISPLAY_SETTINGS = "c:\\test\\display_settings.json";

        public static DisplaySettings GetDisplaySettings()
        {
            var json = File.ReadAllText(DISPLAY_SETTINGS);

            JToken o = JObject.Parse(json);

            var BackgroundJ = (string)o.SelectToken("displaySettings").SelectToken("Background");
            var SensorsJ = o.SelectToken("displaySettings").SelectTokens("Sensor").ToList();
            var displaySettings = new DisplaySettings
            {
                Background = BackgroundJ,
                Sensors = SensorsJ.Cast<string>().ToList()
            };

            return displaySettings;
        }
    }
}

