using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class Taskmodel
    {
        public int Id { get; set; }

        public string tiltle { get; set; }

        public int estimate { get; set; }

        public int priority { get; set; }

        public int owner { get; set; }
    }
}