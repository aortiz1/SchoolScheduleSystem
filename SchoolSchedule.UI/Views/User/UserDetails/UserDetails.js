/// <reference path="C:\archivos\SchoolScheduleProject\SchoolScheduleSystem\SchoolSchedule.UI\Services/UserService.js" />


appSchoolSchedule.controller('userDetailsController', function ($scope,  $cookies, userService, authService) {
    $scope.msg = 'Profile Information';
    authService.authorize();
   
    userService.getUserProfile().then(function (result) {
        //if (result.success) {
        $scope.profile = result.result;
        console.log("profile ", $scope.profile);
        //}
    });
    
    
});