using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class Project
    {
        public int id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public ICollection<User> menberList { get; set; }
        public User creator { get; set; }
        public String pictureUrl { get; set; }
        public ICollection<Story> stories { get; set; } 
        public ICollection<Sprint> sprints{ get; set; }
        public DateTime createdAt { get; set; }

        public Project()
        {
            
        }

        public void addStory(Story story)
        {
            stories.Add(story);
        }

        public void addSprints(Sprint sprint)
        {
            sprints.Add(sprint);
        }

        public void addMember(User user)
        {
            menberList.Add(user);
        }

    }
}