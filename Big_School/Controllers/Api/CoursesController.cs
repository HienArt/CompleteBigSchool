using Big_School.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Big_School.Controllers.Api
{
    public class CoursesController : ApiController
    {
        public ApplicationDbContext _dbContxet;

        public CoursesController()
        {
            _dbContxet = new ApplicationDbContext();
        }

        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var course = _dbContxet.Courses.Single(c => c.Id == id && c.LecturerId == userId);
            if (course.IsCanceled)
            {
                return NotFound();
            }
            course.IsCanceled = true;
            _dbContxet.SaveChanges();
            return Ok();
        }
    }
}
