angular.module('vNextApp.addTimesheet', [
    'vNextApp.addTimesheet.controllers'
]).config(['$routeProvider',
    function ($routeProvider) {
        // Route config
        $routeProvider.
            when('/addTimesheet', {
                title: 'Add Timesheet',
                templateUrl: 'Scripts/components/timesheet/addTimesheet/views/addTimesheet.html',
                controller: 'addTimesheetCtrl',
            });
    }
]);

angular.module('vNextApp.addTimesheet.controllers', []);