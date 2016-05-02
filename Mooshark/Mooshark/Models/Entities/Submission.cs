using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshark.Models.Entities
{
    public class Submission
    {
        public int date { get; set; }
        public int time { get; set; }
        public bool accepted { get; set; }
        public int testCasesPassed { get; set; }
    }
}