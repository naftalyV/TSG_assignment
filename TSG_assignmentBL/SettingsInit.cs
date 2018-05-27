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
        private const string DISPLAY_SETTINGS = "~/display_settings.json";
       // private HttpContext context = HttpContext.Current;

        public static string GetDisplaySettings( )
        {
            var json = File.ReadAllText(DISPLAY_SETTINGS);
             var result = JsonConvert.DeserializeObject<DisplaySettings>(json);
            return "ok";
        }
    }
}
