using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Text;
using TSG_assignmentBL.Models;

namespace TSG_assignmentBL
{
    public static class SettingsInit
    {
       // private const string DISPLAY_SETTINGS = "~/display_settings.json";
       // private HttpContext context = HttpContext.Current;

        public static object GetDisplaySettings(string DISPLAY_SETTINGS_PATH)
        {
            string json = File.ReadAllText(DISPLAY_SETTINGS_PATH);

           var result = JsonConvert.DeserializeObject(json);
            return result;
        }
    }
}
