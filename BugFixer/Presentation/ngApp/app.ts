namespace BugFixer {
    
    angular.module('BugFixer', ['ngRoute']);

    angular.module('BugFixer').factory('authInterceptor',
        ($q: ng.IQService, $window: ng.IWindowService, $location: ng.ILocationService) => {
            return {
                request: (config) => {
                    config.headers = config.headers || {};
                    let token = $window.localStorage.getItem('token');
                    if (token) {
                        config.headers.Authorization = `Bearer ${token}`;
                    }
                    return config;
                },
                responseError: (response) => {
                    if (response.status === 401) {
                        $location.path('/login');
                    }
                    return $q.reject(response);
                }
            };
        });

    angular.module('BugFixer')
        .config(function ($routeProvider: ng.route.IRouteProvider, $httpProvider: ng.IHttpProvider) {

            $httpProvider.interceptors.push('authInterceptor');

            $routeProvider
                .when('/', {
                    template: 'Hello World!'
                })
                .when('/newBug', {
                    templateUrl: '/Presentation/ngApp/views/bugView.html',
                    controller: BugFixer.Controllers.BugViewController,
                    controllerAs: 'controller'
                })
                .when('/buglist', {
                    templateUrl: '/Presentation/ngApp/views/listBugsView.html',
                    controller: BugFixer.Controllers.BugListingController,
                    controllerAs: 'controller'
                });
        });
}