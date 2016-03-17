var app = angular.module('myApp');

app.service('dataService', ['$http', function ($http) {
    var self = this;
    delete $http.defaults.headers.common['X-Requested-With'];
    var url = 'http://localhost:12310/api/';

    return {
        getStories: function() {
            return $http.get(url + 'stories'); 
        },

        getTasks: function() {
            return $http.get(url + 'Taskmodels');
        },

        postStory: function(story, callback) {
            $http({
                method: 'POST',
                url: url + 'Stories',
                headers: {'Content-Type': 'application/x-www-form-urlencoded'},
                data: $.param(story)
            }).then(callback);
        },

        postTask: function (task, callback) {
            var data = { 'name': task.name, 'description': task.description, 'estimate': task.estimate, 'priority': task.priority, 'stauts': 0, 'storyId': task.story.id}

            $http({
                method: 'POST',
                url: url + 'Taskmodels',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
                data: $.param(data)
            }).then(callback);
        }

    };

}]);