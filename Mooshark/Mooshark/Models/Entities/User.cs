﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshark.Models.Entities
{
    public class User
    {
        public string username { get; set;  }
        public string email { get; set; }
        public string password { get; set; }
        public string authentication { get; set;  }

    }
}