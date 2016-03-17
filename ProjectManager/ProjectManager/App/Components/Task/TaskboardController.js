var app = angular.module('myApp');


app.controller('TaskboardController',['$scope', 'dataService', function ($scope, dataService) {

    var self = this; 
    self.tasks = Tasks;
    self.task = [];

    self.addTask = function () {
        var task = $scope.task;
        $scope.task = null;
        $scope.models.lists.ToDo.push(task);
    };
    
    

    $scope.stories = Stories;

    $scope.models = {
        selected: null,
        lists: { "ToDo": [], "In progress": [], "Review": [], "Done": [] }
    };

    self.getStories = function() {
        dataService.getTasks().then(function(d) {
            $scope.tasks = d.data;
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

var Stories = [new Story(1, "Vask Op", "Vask alt opvask op", 2, 10, user1, "", 0, project, []), new Story(2, "Støvsug", "Støvsug over alt", 4, 8, user2, "", 0, project, []), new Story(3, "Støv af", "Støv alt af", 1, 4, user1, "", 0, project, [])];