using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models.ViewModels
{
    public class TaskViewModel
    {
        public String name { get; set; }
        public String description { get; set; }
        public int status { get; set; }
        public User responseable { get; set; }
        public int storyId { get; set; }
        public int estimate { get; set; }
        public int priority { get; set; }
        public DateTime createdAt { get; set; }

        public TaskViewModel()
        {

        }

    }
}