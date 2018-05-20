'use strict';

angular.module('myApp.factories', []).factory('Home', ['$resource',
    function ($resource) {
        var resource = $resource('http://localhost:63668/api/homes', {}, { get: { method: 'GET', isArray: true } });
        return resource;
    }
]);



/* Controllers */

angular.module('myApp.controllers', [])
  .controller('ViewHomeCtrl', ['$scope', 'Home', function ($scope, Home) {
      
      $scope.homes = [];

      Home.get(function (response) {
          $scope.homes = response;
      });

  }])
  .controller('AddHomeCtrl', ['$scope', 'Home', function ($scope, Home) {

      
      $scope.phone = '';
      $scope.address = '';

      $scope.saveHome = function() {
          Home.save({Phone: $scope.phone, Address: $scope.address}, function(response) {
              if (response) {
                  $scope.notification = 'Home is saved';
                 
                  $scope.phone = '';
                  $scope.address = '';
              } else {
                  $scope.notification = 'Home is not saved';
              }
          });
      };

     
  }]);


