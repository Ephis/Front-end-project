var app = angular.module('myApp');

app.controller('ProjectController', function () {
    var self = this; 
    self.projects = Projects;
    
    self.addProject = new function(project){
        self.projects.push(project);
    };
});



var user1 = new User(1, "KyhmeBiatchs", "Marck Jensen", "", "Jeg hedder Marck og er 10 år", []);
var user2 = new User(2, "Ephixs", "Nicolai Rasmussen", "", "Marck er min ven", []);

var Projects = [new Project(1,"Project 1",[],user1,"",[]), new Project(2,"Project 2",[],user2,"",[]), new Project(3,"Project 3",[],user1,"",[]), new Project(4,"Project 4",[], user1,"",[]), new Project(5,"Project 5",[],user2,"",[])];