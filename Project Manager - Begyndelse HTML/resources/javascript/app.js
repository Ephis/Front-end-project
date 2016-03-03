
var app = angular.module('myApp', ['ngRoute']);

app.config(['$routeProvider',
  function($routeProvider) {
    $routeProvider.
    when('/wall/:projectId', {
        templateUrl: 'ng-views/wall.html',
        controller: 'WallController as wallCtrl'})
    .when('/summary', {
        templateUrl: 'ng-views/summary.html',
        controller: 'SummaryController as sumCtrl'})
    .when('/story/:projectId', {
        templateUrl: 'ng-views/story.html',
        controller: 'StoryController as storyCtrl'})
    .when('/taskboard/:projectId', {
        templateUrl: 'ng-views/taskboard.html',
        controller: 'TaskboardController as taskCtrl'
    })
    .when('/calender', {
        templateUrl: 'ng-views/calender.html',
        controller: 'CalenderController as calenderCtrl'
    })
    .when('/files', {
        templateUrl: 'ng-views/files.html',
        controller: 'FilesController as fileCtrl'
    })
    .when('/settings', {
        templateUrl: 'ng-views/settings.html',
        controller: 'SettingsController as settingsCtrl'
    });
  }]);