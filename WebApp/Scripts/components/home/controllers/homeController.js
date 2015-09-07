angular.module('vNextApp.home.controllers').controller('HomeCtrl', ['$scope', '$http', '$location',
    function ($scope, $http, $location) {

        var url = "http://localhost:63697/api/timesheets";

        $scope.timesheets = [];
        $http.get(url).success(function (timesheets) {
            $scope.timesheets = timesheets;
        });

        $scope.addTimesheet = function () {
            $location.path('/addTimesheet');
        };
    }]);