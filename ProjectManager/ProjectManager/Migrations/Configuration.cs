using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using ProjectManager.Models;

namespace ProjectManager.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
//            Story story1 = new Story()
//            {
//                id = 1,
//                name = "Make baby cry",
//                priority = 10,
//                description = "make baby cry hard, for days!",
//                isDone = false,
//                actualTime = 0,
//                createdAt = new DateTime(),
//                creator = null,
//                estimat = 5,
//                project = null
//
//            };
//
//            Story story2 = new Story()
//            {
//                id = 2, 
//                name = "Pass exam",
//                priority = 8,
//                description = "And nail it!",
//                isDone = false,
//                actualTime = 0,
//                createdAt = new DateTime(),
//                creator = null,
//                estimat = 10,
//                project = null
//            };
//
//            Taskmodel task1 = new Taskmodel()
//            {
//                id = 1,
//                name = "Do something",
//                estimate = 2,
//                priority = 2,
//                status = 1,
//                description = "Hallo",
//                story = story1,
//                createdAt = new DateTime(),
//                responseable = null
//
//            };
//
//            Taskmodel task2 = new Taskmodel()
//            {
//                id = 2, 
//                name = "Write code",
//                estimate = 5, 
//                priority = 3,
//                status = 2,
//                description = "Make all the code",
//                story = story2,
//                createdAt = new DateTime(),
//                responseable = null
//
//            };
//
//            Project project = new Project()
//            {
//                id = 1,
//                name = "tryhards",
//                description = "We are the tryhard team",
//                createdAt = new DateTime(),
//                creator = null,
//                menberList = new List<User>(),
//                pictureUrl = "",
//                sprints = new List<Sprint>(),
//                stories = new List<Story>()
//
//            };
//
//            story1.addTask(task1);
//            story1.project = project;
//            story2.addTask(task2);
//            story2.project = project;
//
//            project.addStory(story1);
//            project.addStory(story2);
//
//            context.Projects.AddOrUpdate(project);
            
        }
    }
}
