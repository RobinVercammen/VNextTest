angular.module('vNextApp.addTimesheet.controllers').controller('addTimesheetCtrl', ['$scope','$http',
    function ($scope,$http) {
        $scope.addTimesheet = function (timesheet) {


            var insertTimesheet = {
                "Date": new Date(),
                "Company": timesheet.company,
                "Consultant": timesheet.consultant,
                "File": timesheet.file,
                "Status": timesheet.status
            }
            $http({
                method: 'POST',
                url: 'http://localhost:63697/api/timesheets',
                data: insertTimesheet,
                headers: { 'Content-Type': 'application/json' }
            });
        }
    }]);