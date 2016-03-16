var app = angular.module('myApp');

app.service('dataService', ['$http', function ($http) {
    var self = this;
    delete $http.defaults.headers.common['X-Requested-With'];
    var url = 'http://localhost:12310/api/';

    return {
        getStories: function () {
            return $http.get(url + 'stories');  //1. this returns promise
        }
    };

}]);