using Big_School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Big_School.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course>UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}