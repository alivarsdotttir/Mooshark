using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshark.Models.Entities
{
    public class Course
    {
        public List<Project> project { get; set; }
        public List<Student> students { get; set; }
        public List<Teacher> teachers { get; set; }
    }
}