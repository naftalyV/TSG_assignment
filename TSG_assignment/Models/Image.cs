using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TSG_assignment.Models
{
      public  enum Sensor
        {
            OGEN,
            IKONOS,
            GEOEYE,
            OFEK
        }
    public class Image
    {
        public string Name { get; set; }
        public Sensor Sensor { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int ClipX { get; set; }
        public int ClipY { get; set; }
        public int ClipW { get; set; }
        public int ClipH { get; set; }
    }
}