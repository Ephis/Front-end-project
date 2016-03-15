var app = angular.module('myApp');

app.service('dataService', ['$http', function ($http) {
    var self = this;
    delete $http.defaults.headers.common['X-Requested-With'];
    var url = 'http://localhost:12310/api/';

    var dataService = {
        getStories: function () {
            var promise = $http.get(url + 'stories').then(function(response) {
                console.log(response);

                return response.data;
            });
            return promise;
        }
        
    }


    return dataService;

}]);