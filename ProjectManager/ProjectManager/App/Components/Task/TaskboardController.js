var app = angular.module('myApp');

app.controller('TaskboardController',[ '$scope', function ($scope) {
    var self = this; 
    self.tasks = Tasks;
    
    $scope.stories = Stories;

    $scope.models = {
        selected: null,
        lists: { "A": [], "B": [] }
    };

    // Generate initial model
    for (var i = 1; i <= 3; ++i) {
        $scope.models.lists.A.push({ label: "Item A" + i });
        $scope.models.lists.B.push({ label: "Item B" + i });
    };

    // Model to JSON for demo purpose
    $scope.$watch('models', function (model) {
        $scope.modelAsJson = angular.toJson(model, true);
    }, true);

}]);

var Tasks = [new Task(1, "Task 1", "desc", 2, "", "uswr1", "story"), new Task(2, "Task 2", "desc", 2, "", "uswr1", "story"),new Task(3, "Task 3", "desc", 2, "", "uswr1", "story")];

var Stories = [new Story(1, "Vask Op", "Vask alt opvask op", 2, 10, user1, "", 0, project, []), new Story(2, "Støvsug", "Støvsug over alt", 4, 8, user2, "", 0, project, []), new Story(3, "Støv af", "Støv alt af", 1, 4, user1, "", 0, project, [])];