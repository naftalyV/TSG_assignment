using System;
using System.Collections.Generic;
using System.Text;
using TSG_assignmentBL.Models;

namespace TSG_assignmentBL
{
    public static class SettingsInit
    {
        private const string DISPLAY_SETTINGS = "~/display_settings.json/";

        private static DisplaySettings displaySettings = new DisplaySettings();
    }
}
