var app = angular.module('myApp');

app.controller('StoryController', ['$scope', 'dataService', function ($scope, dataService) {
    var self = this;

    self.stories = stories;
    self.tasksToAdd = [];

    self.addStory = function () {
        var story = $scope.story;
        $scope.story = null;
        story.taskList = self.tasksToAdd;
        self.tasksToAdd = [];
        self.stories.push(story);
    };

    self.addTaskToList = function () {
        var task = $scope.task;
        self.tasksToAdd.push(task);
        $scope.task = null;
    };

    self.getStories = function() {
        dataService.getStories().then(function (d) { 
           self.stories = d.data;
        });
    };

    self.isStoryDone = function (isDone)
    {
        var displayText = "";
        if (isDone) {
            displayText = "Done";
        } else {
            displayText = "ToDo";
        }
        return displayText;
    }

    $scope.handleKeyPress = function(e) {
        var key = e.keyCode || e.which;
        if (key == 13) {
            self.addTaskToList();
        }
    }

    self.getStories();

}]);

var user1 = new User(1, "KyhmeBiatchs", "Marck Jensen", "", "Jeg hedder Marck og er 10 år", []);
var user2 = new User(2, "Ephixs", "Nicolai Rasmussen", "", "Marck er min ven", []);

var project = new Project(1, "Project 1", [], user1, "", []);

var stories = [new Story(1, "Vask Op", "Vask alt opvask op", 2, 10, user1, "", 0, project, []), new Story(2, "Støvsug", "Støvsug over alt", 4, 8, user2, "", 0, project, []), new Story(3, "Støv af", "Støv alt af", 1, 4, user1, "", 0, project, [])];