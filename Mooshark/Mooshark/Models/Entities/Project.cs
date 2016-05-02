using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshark.Models.Entities
{
    public class Project
    {
        public string description { get; set; }
        public DateTime deadline { get; set; }
        public int groupMembers { get; set; }
        public List<SubProject> subprojects { get; set; }
        
    }
}