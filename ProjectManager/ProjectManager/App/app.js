
var app = angular.module('myApp', ['ngRoute', 'ngMessages', 'dndLists']);

app.config(['$routeProvider',
  function($routeProvider) {
    $routeProvider.
    when('/wall/:projectId', {
        templateUrl: '/app/components/wall/wall.html',
        controller: 'WallController as wallCtrl'})
    .when('/summary', {
        templateUrl: '/app/components/summary/summary.html',
        controller: 'SummaryController as sumCtrl'})
    .when('/story/:projectId', {
        templateUrl: '/app/components/story/story.html',
        controller: 'StoryController as storyCtrl'})
    .when('/taskboard/:projectId', {
        templateUrl: '/app/components/task/taskboard.html',
        controller: 'TaskboardController as taskCtrl'
    })
    .when('/calender', {
        templateUrl: '/app/components/calender/calender.html',
        controller: 'CalenderController as calenderCtrl'
    })
    .when('/files', {
        templateUrl: '/app/components/files/files.html',
        controller: 'FilesController as fileCtrl'
    })
    .when('/settings', {
        templateUrl: '/app/components/settings/settings.html',
        controller: 'SettingsController as settingsCtrl'
    });
  }]);