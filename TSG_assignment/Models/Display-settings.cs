﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TSG_assignment.Models
{
    public class Display_settings
    {
        public Sensor[] Sensor { get; set; } = new Sensor[2];
        public string Background { get; set; }
    }
}