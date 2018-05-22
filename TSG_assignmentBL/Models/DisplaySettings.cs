using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TSG_assignmentBL.Models
{
    public static class DisplaySettings
    {
        private const byte SENSORS_LENGTH = 2;

        public static Sensor[] Sensor { get; set; } = new Sensor[SENSORS_LENGTH];
        public static string Background { get; set; }
    }
}