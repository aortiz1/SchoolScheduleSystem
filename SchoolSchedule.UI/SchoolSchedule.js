
var appSchoolSchedule = angular.module('appSchoolSchedule', ['ngRoute', 'ngCookies', 'ngStorage']);

appSchoolSchedule.config(function ($routeProvider, $httpProvider) {
  
        $routeProvider.when('/Home', { templateUrl: 'Views/Common/Home/Home.html', controller: 'homeController' });
        $routeProvider.when('/Login', { templateUrl: 'Views/Common/Login/Login.html', controller: 'loginController' });
        $routeProvider.when('/UserDetails', { templateUrl: 'Views/User/UserDetails/UserDetails.html', controller: 'userDetailsController' });
        //$routeProvider.when('/UserManagement', { templateUrl: 'Views/Management/UserManagement/UserManagement.html', controller: 'userManagementController' });
        $routeProvider.when('/NewUser', { templateUrl: 'Views/Management/NewUser/NewUser.html', controller: 'registerUserController' });
        $routeProvider.when('/EditUser', { templateUrl: 'Views/User/EditUser/EditUser.html', controller: 'editUserController' });
        $routeProvider.when('/AllCourses', { templateUrl: 'Views/Courses/AllCourses/allCourses.html', controller: 'allCoursesController' });
        $routeProvider.when('/UserCourses', { templateUrl: 'Views/Courses/CoursesByStudent/CoursesByStudent.html', controller: 'coursesStudentController' });
        $routeProvider.when('/Logout', {
            resolve: {
                auth: function ($rootScope, $location, $cookies) {
                    console.log("my logout");
                    $cookies.put('logged', false);
                    $rootScope.Auth = false;
                    $location.path('/Login');

                }
            }
        });
        $routeProvider.otherwise({ redirectTo: '/Home' });
  

});


appSchoolSchedule.run(function ($rootScope, $cookies, $http) {
    var logged = $cookies.get('logged');
    if (logged == 'true')
        logged = true;
    else
        logged = false;
   
    $rootScope.Auth = logged;
    console.log('is auth', logged);
});
    
 

