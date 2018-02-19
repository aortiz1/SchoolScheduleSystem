$("#menu-toggle").click(function (e) {
    e.preventDefault();
    $("#wrapper").toggleClass("active");
});

var appSchoolSchedule = angular.module('appSchoolSchedule', ['ngRoute']);

appSchoolSchedule.config(function ($routeProvider, $httpProvider) {
    $routeProvider.when('/Home', { templateUrl: 'Views/Common/Home/Home.html', controller: 'homeController' });
    $routeProvider.when('/Login', { templateUrl: 'Views/Common/Login/Login.html' });
    $routeProvider.when('/UserDetails', { templateUrl: 'Views/User/UserDetails/UserDetails.html', controller: 'userDetailsController' });
    $routeProvider.when('/LogOut', {});
    $routeProvider.otherwise({ redirectTo: '/Home' });
});