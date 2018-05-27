using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Web.Http;
using TSG_assignmentBL;
using TSG_assignmentBL.Models;
using System.Web;

namespace TSG_assignment.Controllers
{
    [RoutePrefix("tsgAssignment")]
    public class ImagesController : ApiController
    {
        private  HttpContext context = System.Web.HttpContext.Current;

        private const string DISPLAY_SETTINGS_PATH ="~/AssignmentData/display_settings.json";

        private const string CSV_PATH = "~/AssignmentData/images_metadata.csv";


        [Route("getImages")]
        [HttpGet]
        public IHttpActionResult GetImages()
        {
            try
            {
                var images = ImageInit.GetImages(context.Server.MapPath(CSV_PATH));
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
          
                var displaySettings = SettingsInit.GetDisplaySettings(context.Server.MapPath(DISPLAY_SETTINGS_PATH));
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
