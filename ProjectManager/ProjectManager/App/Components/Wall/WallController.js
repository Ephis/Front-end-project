var app = angular.module('myApp');

app.controller('WallController', function ($routeParams) {
    var self = this;
    self.projectId = $routeParams.projectId;
    
});