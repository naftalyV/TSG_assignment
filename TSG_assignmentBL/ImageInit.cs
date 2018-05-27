using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TSG_assignmentBL.Models;

namespace TSG_assignmentBL
{
    public static class ImageInit
    {
       // private const string CSV_PATH = "c:\\test\\images_metadata.csv";
      
        public static List<Image> GetImages(string CSV_PATH)
        {
            var imageList = File.ReadAllLines(CSV_PATH)
                   .Skip(1)
                   .Select(x => x.Split(','))
                   .Select(x => new Image
                   {
                       Name = x[0],
                       Sensor =(Sensor) Enum.Parse(typeof(Sensor),x[1]),
                       X = int.Parse(x[2]),
                       Y = int.Parse(x[3]),
                       ClipX = int.Parse(x[4]),
                       ClipY = int.Parse(x[5]),
                       ClipH = int.Parse(x[6]),
                       ClipW = int.Parse(x[7]),
                   }).ToList();

            return imageList;
        }
    }
}
