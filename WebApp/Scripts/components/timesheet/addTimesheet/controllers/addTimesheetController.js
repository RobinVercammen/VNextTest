angular.module('vNextApp.addTimesheet.controllers').controller('addTimesheetCtrl', ['$scope',
    function ($scope) {
        $scope.addTimesheet = function (timesheet) {
            alert(JSON.stringify(timesheet));
        }
    }]);