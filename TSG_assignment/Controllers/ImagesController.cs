using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TSG_assignmentBL;
using TSG_assignmentBL.Models;

namespace TSG_assignment.Controllers
{
    [RoutePrefix("")]
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

        [Route("getDisplaySettings")]
        [HttpGet]
        public IHttpActionResult GetDisplaySettings()
        {
            try
            {
                var displaySettings = SettingsInit.GetDisplaySettings();
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
