using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshark.Models.Entities
{
    public class SubProject
    {
        public string description { get; set; }
        public  List<Submission> submissions { get; set; }
        public List<InputOutput> inputsAndOutputs { get; set; }
    }
}