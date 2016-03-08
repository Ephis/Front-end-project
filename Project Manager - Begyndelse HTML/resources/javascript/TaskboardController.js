var app = angular.module('myApp');

app.controller('TaskboardController', function () {
    var self = this; 
    self.tasks = Tasks;
    
});

var Tasks = [new Task(1,"Task 1","desc",2,"","uswr1","story")];