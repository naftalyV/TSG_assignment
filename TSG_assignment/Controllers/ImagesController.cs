using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Web.Http;
using TSG_assignmentBL;
using TSG_assignmentBL.Models;

namespace TSG_assignment.Controllers
{
    [RoutePrefix("tsgAssignment")]
    public class ImagesController : ApiController
    {

        [Route("getImages")]
        [HttpGet]
        public IHttpActionResult GetImages()
        {
            try
            {
                var images = ImageInit.GetImages();
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
        private const string DISPLAY_SETTINGS = "~/AssignmentData/display_settings.json";
        [Route("getDisplaySettings")]
        [HttpGet]
        public IHttpActionResult GetDisplaySettings()
        {
            try
            {
                System.Web.HttpContext context = System.Web.HttpContext.Current;
                string json = File.ReadAllText(context.Server.MapPath(DISPLAY_SETTINGS));
                DisplaySettings result = Newtonsoft.Json.JsonConvert.DeserializeObject<DisplaySettings>(json);

                string displaySettings = SettingsInit.GetDisplaySettings();
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
