using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TSG_assignment.Models;

namespace TSG_assignment.Controllers
{
    [RoutePrefix("")]
    public class ImagesController : ApiController
    {
        private const byte IMAGE_ARRAY_LENGTH = 4;

        private const string CSV_PATH = "~/images_metadata.csv/";

        private const string DISPLAY_SETTINGS = "~/display_settings.json/";

        private DisplaySettings displaySettings = new DisplaySettings();

        private Image[] images = new Image[IMAGE_ARRAY_LENGTH];



        [Route("getImages")]
        [HttpGet]
        public IHttpActionResult GetImages()
        {
            try
            {
                if (images == null)
                {
                    return NotFound();
                }
                return Ok(images);
            }
            catch (Exception ex)
            {
                return BadRequest(string.Concat(ex.ToString(), " ____ ", ex.StackTrace));
            }

        }
        [Route("getDisplaySettings")]
        [HttpGet]
        public IHttpActionResult GetDisplaySettings()
        {
            try
            {
                if (displaySettings == null)
                {
                    return NotFound();
                }
                return Ok(displaySettings);
            }
            catch (Exception ex)
            {
                return BadRequest(string.Concat(ex.ToString(), " ____ ", ex.StackTrace));
            }

        }
    }
}
