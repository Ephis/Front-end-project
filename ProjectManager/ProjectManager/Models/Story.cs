using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class Story
    {
        public int id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public int estimat { get; set; }
        public int priority { get; set; }
        public User creator { get; set; }
        public Boolean isDone { get; set; }
        public int actualTime { get; set; }
        public Project project { get; set; }
        public ICollection<Taskmodel> tasks { get; set; }
        public DateTime createdAt { get; set; }

        public Story()
        {
            
        }

    }
}