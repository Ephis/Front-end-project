var app = angular.module('myApp');


app.controller('TaskboardController',['$scope', 'dataService', function ($scope, dataService) {

    var self = this; 
  

    $scope.models = {
        selected: null,
        lists: { "ToDo": [], "In progress": [], "Review": [], "Done": [] }
    };


    self.addTask = function () {
        $('#taskModal').modal('toggle');
        var task = $scope.task;
        $scope.task = null;
        dataService.postTask(task, function(data) {
            console.log(data.data);
            $scope.models.lists.ToDo.push(data.data);
        })
    };

    dataService.getStories().then(function (d) {
        $scope.stories = d.data;
    });;

    self.getStories = function() {
        dataService.getTasks().then(function(d) {
            self.dndListInit(d.data);
        });
    };

    self.dndListInit = function(tasks) {
        tasks.forEach(function(task) {
            switch(task.status) {
                case 0:
                    $scope.models.lists.ToDo.push(task);
                    break;
                case 1:
                    $scope.models.lists["In progress"].push(task);
                    break;
                case 2:
                    $scope.models.lists.Review.push(task);
                    break;
                case 3:
                    $scope.models.lists.Done.push(task);
                    break;
            }
        });
    };

    self.getStories();



}]);

var Tasks = [new Task(1, "Task 1", "desc", 2, "", "uswr1", "story"), new Task(2, "Task 2", "desc", 2, "", "uswr1", "story"),new Task(3, "Task 3", "desc", 2, "", "uswr1", "story")];

var Stories = [new Story(1, "Vask Op", "Vask alt opvask op", 2, 10, "", "", 0, "", []), new Story(2, "Støvsug", "Støvsug over alt", 4, 8, "", "", 0, "", []), new Story(3, "Støv af", "Støv alt af", 1, 4, "", "", 0, "", [])];