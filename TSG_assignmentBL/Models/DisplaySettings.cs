using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TSG_assignmentBL.Models
{
    public class DisplaySettings
    {
        public Sensor[] Sensor { get; set; } = new Sensor[2];
        public string Background { get; set; }
    }
}