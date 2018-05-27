using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TSG_assignmentBL.Models
{
    //public class DisplaySettings
    //{

    //    public Dictionary<string, List<string>> Sensor { get; set; }
    //    public Dictionary<string, string> Background { get; set; }
    //}
    public class DisplaySettings
    {
        public List<string> Sensor { get; set; }
        public string Background { get; set; }
    }

    public class RootObject
    {
        public DisplaySettings displaySettings { get; set; }
    }
}