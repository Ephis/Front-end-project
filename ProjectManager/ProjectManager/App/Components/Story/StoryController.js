var app = angular.module('myApp');

app.controller('StoryController', ['$scope', 'dataService', function ($scope, dataService) {
    var self = this;

    self.stories = [];
    self.tasksToAdd = [];

    self.addStory = function () {
        $('#myModal').modal('toggle');
        var story = $scope.story;
        $scope.story = null;
        story.taskList = self.tasksToAdd;
        self.tasksToAdd = [];
        dataService.postStory(story, function(data) {
            self.stories.push(data.data);
            console.log(data.data);
        });
        console.log(self.stories);
    };

    self.addTaskToList = function () {
        var task = $scope.task;
        self.tasksToAdd.push(task);
        $scope.task = null;
    };

    self.getStories = function() {
        dataService.getStories().then(function (d) {
            d.data.forEach(function (data) {
                self.stories.push(data);
            });
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
