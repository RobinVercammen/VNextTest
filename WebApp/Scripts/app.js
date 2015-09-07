var vNextApp = angular.module('vNextApp', [
    'ngRoute',

    'vNextApp.services',
    'vNextApp.controllers',

    'vNextApp.home'
]);

angular.module('vNextApp.services', []);
angular.module('vNextApp.controllers', []);

vNextApp.config(['$logProvider', '$routeProvider',
    function ($logProvider, $routeProvider) {
        // Logging
        $logProvider.debugEnabled(true);

        // Route config
        $routeProvider.
            otherwise({
                redirectTo: '/'
            });
    }
]);

vNextApp.run(['$rootScope',
    function ($rootScope) {
        
    }]);