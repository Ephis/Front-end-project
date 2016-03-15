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
            Story story1 = new Story
            {
                id = 1,
                name = "Make Story",
                description = "Bla bla bla",
                actualTime = 0,
                estimat = 5,
                isDone = false,
                createdAt = DateTime.Now

            };
            Story story2 = new Story
            {
                id = 2,
                name = "Make Tasks",
                description = "Bla bla bla",
                actualTime = 0,
                estimat = 5,
                isDone = false,
                createdAt = DateTime.Now

            };
            context.Stories.AddOrUpdate(s => s.id, story1, story2);
            context.Tasks.AddOrUpdate(t => t.id, new Taskmodel {id = 1, name = "task1", description = "", estimate = 4, priority = 1, status = 1, story = story1, createdAt = DateTime.Now },
                new Taskmodel { id = 2, name = "task2", description = "", estimate = 3, priority = 3, status = 1, story = story2, createdAt = DateTime.Now },
                new Taskmodel { id = 3, name = "task3", description = "", estimate = 5, priority = 5, status = 2, story = story2, createdAt = DateTime.Now },
                new Taskmodel { id = 4, name = "task4", description = "", estimate = 2, priority = 7, status = 3, story = story2, createdAt = DateTime.Now },
                new Taskmodel { id = 5, name = "task5", description = "", estimate = 3, priority = 2, status = 4, story = story1, createdAt = DateTime.Now },
                new Taskmodel { id = 6, name = "task6", description = "", estimate = 7, priority = 1, status = 4, story = story1, createdAt = DateTime.Now });
            
        }
    }
}
