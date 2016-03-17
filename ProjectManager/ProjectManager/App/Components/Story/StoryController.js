var app = angular.module('myApp');

app.controller('StoryController', ['$scope', 'dataService', function ($scope, dataService) {
    var self = this;

    self.stories = [];
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
            console.log(self.stories);
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
