using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TSG_assignmentBL.Models
{
    public  class DisplaySettings
    {
        private const byte SENSORS_LENGTH = 2;

        public  Sensor[] Sensor { get; set; }
        public  string Background { get; set; }
    }
}