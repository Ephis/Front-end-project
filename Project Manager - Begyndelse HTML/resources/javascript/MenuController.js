var app = angular.module('myApp');

app.controller('MenuController', function () {
    var self = this;
    self.project = null;
    self.menuShown = false;

    self.projectIconClicked = function (project) {
        if (self.isProjectShown(project)) {
            self.hideProject();
        } else {
            self.showProject(project);
        }
    };

    self.showProject = function (project) {
        self.project = project;
        self.menuShown = true;
    };

    self.isProjectShown = function (project) {
        return self.project === project && self.menuShown === true;
    };

    self.hideProject = function () {
        self.menuShown = false;
    };

});