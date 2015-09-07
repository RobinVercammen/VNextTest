angular.module('vNextApp.home', [
    'vNextApp.home.controllers'
]).config(['$routeProvider',
    function ($routeProvider) {
        // Route config
        $routeProvider.
            when('/', {
                title: 'Home',
                templateUrl: 'Scripts/components/home/views/home.html',
                controller: 'HomeCtrl',
            });
    }
]);

angular.module('vNextApp.home.controllers', []);