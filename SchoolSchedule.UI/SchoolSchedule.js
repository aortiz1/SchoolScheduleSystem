

//$("#menu-toggle").click(function (e) {
//    e.preventDefault();
//    $("#wrapper").toggleClass("toggled");
//});
var appSchoolSchedule = angular.module('appSchoolSchedule', ['ngRoute', 'ngCookies', 'ngStorage']);

appSchoolSchedule.config(function ($routeProvider, $httpProvider) {
  
        $routeProvider.when('/Home', { templateUrl: 'Views/Common/Home/Home.html', controller: 'homeController' });
        $routeProvider.when('/Login', { templateUrl: 'Views/Common/Login/Login.html', controller: 'loginController' });
        $routeProvider.when('/UserDetails', { templateUrl: 'Views/User/UserDetails/UserDetails.html', controller: 'userDetailsController' });
        //$routeProvider.when('/UserManagement', { templateUrl: 'Views/Management/UserManagement/UserManagement.html', controller: 'userManagementController' });
        $routeProvider.when('/NewUser', { templateUrl: 'Views/Management/NewUser/NewUser.html', controller: 'registerUserController' });
        $routeProvider.when('/EditUser', { templateUrl: 'Views/User/UserDetails/EditUser.html', controller: 'editUserController' });

        $routeProvider.when('/LogOut', { controller: 'logoutController' });
        $routeProvider.otherwise({ redirectTo: '/Home' });
  

});
appSchoolSchedule.controller('logoutController', function ($cookies, $cookieStore) {
   
    if ($cookies.logged) {
        $cookies.logged = false;
        $cookieStore.remove("logged");
        $location.path('/Login');
    }

});

//appSchoolSchedule.run(['$rootScope', '$location', '$cookies', function ($rootScope, $location, $cookies) {
//    $rootScope.$on('$routeChangeStart', function (event) {

//        if (!$cookies.logged) {
//            console.log('DENY : Redirecting to Login');
//            event.preventDefault();
//            $location.path('/Login');
//        }
//        else {
//            console.log('ALLOW');
//        }
//    });
//}]);