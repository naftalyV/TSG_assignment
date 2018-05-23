using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TSG_assignmentBL.Models;

namespace TSG_assignmentBL
{
    public static class ImageInit
    {
       // private const string CSV_PATH =@" D:/Users/ויסנשטרן/Desktop/TSG_assignment/AssignmentData/images_metadata.csv/";
         private const string CSV_PATH = "c:\\test\\images_metadata.csv";
       // private const string CSV_PATH = "~\\images_metadata.csv";
        // private const byte IMAGE_ARRAY_LENGTH = 4;
        private static readonly List<Image> imageList = new List<Image>();



        public static List<Image> GetImages()
        {
            string[] st = File.ReadAllLines(CSV_PATH);

            return imageList;
        }
    }
}
