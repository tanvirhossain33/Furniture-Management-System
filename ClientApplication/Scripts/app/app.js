'use strict';


// Declare app level module which depends on filters, and services
angular.module('myApp', [
  'ngRoute',
    'ngResource',
  'myApp.filters',
  'myApp.services',
  'myApp.directives',
  'myApp.controllers',
    'myApp.factories'
]).
config(['$routeProvider', function($routeProvider) {
    $routeProvider.when('/viewHome', {templateUrl: 'partials/viewHome.html', controller: 'ViewHomeCtrl'});
    $routeProvider.when('/addHome', {templateUrl: 'partials/addHome.html', controller: 'AddHomeCtrl'});
    $routeProvider.otherwise({ redirectTo: '/viewHome'});
}]);
