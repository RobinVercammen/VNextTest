angular.module('vNextApp.home.controllers').controller('HomeCtrl', ['$scope', '$http',
    function ($scope, $http) {

        var url = "http://localhost:63697/api/timesheets";

        $scope.timesheets = [];
        $http.get(url).success(function (timesheets) {
            console.log(timesheets);
            $scope.timesheets = timesheets;
        });
    }]);