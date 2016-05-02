using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshark.Models.Entities
{
    public class Student : User
    {
        public List<Course> courses { get; set; }
    }
}