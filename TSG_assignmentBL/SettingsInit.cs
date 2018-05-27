using System;
using System.Collections.Generic;
using System.Text;
using TSG_assignmentBL.Models;

namespace TSG_assignmentBL
{
    public static class SettingsInit
    {
        private const string DISPLAY_SETTINGS = "~/display_settings.json/";

        public static object GetDisplaySettings()
        {
             var result = JsonConvert.DeserializeObject<int>(body);
            return null;
        }
    }
}
