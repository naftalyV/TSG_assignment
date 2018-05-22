using System;
using System.Collections.Generic;
using System.Text;
using TSG_assignmentBL.Models;

namespace TSG_assignmentBL
{
    public static class ImageInit
    {
        private const string CSV_PATH = "~/images_metadata.csv/";

        private const byte IMAGE_ARRAY_LENGTH = 4;
        private static Image[] images = new Image[IMAGE_ARRAY_LENGTH];

        public static object GetImages()
        {
            throw new NotImplementedException();
        }
    }
}
