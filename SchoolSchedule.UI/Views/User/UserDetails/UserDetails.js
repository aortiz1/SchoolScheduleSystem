/// <reference path="C:\archivos\SchoolScheduleProject\SchoolScheduleSystem\SchoolSchedule.UI\Services/UserService.js" />


appSchoolSchedule.controller('userDetailsController', function ($scope, userService) {
    $scope.msg = 'Profile Information';
    if (userService.logged) {
        userService.getUserProfile().then(function (result) {
            if (result.success === true) {
                $scope.profile = result.result;
            }
        });
    }
});