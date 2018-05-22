

var myApp = angular.module('myApp', ['ui.router', 'ngResource']);

myApp.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise('viewHome');

    $stateProvider
        .state('viewHome', {
            url: '/viewHome',
            templateUrl: 'partials/viewHome.html',
            controller: 'ViewHomeCtrl'
        })
        .state('addHome', {
            url: '/addHome',
            templateUrl: 'partials/addHome.html',
            controller: 'AddHomeCtrl'
        })
        .state('viewFurnitureType', {
            url: '/viewFurnitureType',
            templateUrl: 'partials/viewFurnitureType.html',
            controller: 'ViewFurnitureTypeCtrl'
        })

        .state('addFurnitureType', {
            url: '/addFurnitureType',
            templateUrl: 'partials/addFurnitureType.html',
            controller: 'AddFurnitureTypeCtrl'
        });
});






myApp.factory('Home', ['$resource', function ($resource) {
    var resource = $resource('http://localhost:63668/api/homes', {}, { get: { method: 'GET', isArray: true } });
    return resource;
}]);

myApp.factory('FurnitureType', ['$resource', function ($resource) {
    var resource = $resource('http://localhost:63668/api/Furnituretypes', {}, { get: { method: 'GET', isArray: true } });
    return resource;
}]);


// Controllers
myApp.controller('ViewHomeCtrl', ['$scope', 'Home', function ($scope, Home) {
    $scope.homes = [];
    Home.get(function (response) {
        $scope.homes = response;
    });

}]);
myApp.controller('AddHomeCtrl', ['$scope', 'Home', function ($scope, Home) {
    $scope.phone = '';
    $scope.address = '';

    

    $scope.saveHome = function () {
        Home.save({ Phone: $scope.phone, Address: $scope.address }, function (response) {
            if (response) {
                $scope.notification = 'Home is Saved';

                $scope.phone = '';
                $scope.address = '';
            } else {
                $scope.notification = 'Home is not saved';
            }
        });
    };
}]);

myApp.controller('ViewFurnitureTypeCtrl', ['$scope', 'FurnitureType', function ($scope, FurnitureType) {
    $scope.types = [];
    FurnitureType.get(function (response) {
        $scope.types = response;
    });
}]);
myApp.controller('AddFurnitureTypeCtrl', ['$scope', 'FurnitureType', function ($scope, FurnitureType) {
    
    $scope.type = '';

    

    $scope.saveTypes = function () {
        FurnitureType.save({ Type: $scope.type }, function (response) {
            if (response) {
                $scope.notification = 'Furniture Type is Saved';

                $scope.type = '';
            } else {
                $scope.notification = 'Furniture Type is not saved';
            }
        });
    };
}]);



