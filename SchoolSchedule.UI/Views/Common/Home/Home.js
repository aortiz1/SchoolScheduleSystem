/// <reference path="C:\archivos\SchoolScheduleProject\SchoolScheduleSystem\SchoolSchedule.UI\Services/UserService.js" />


appSchoolSchedule.controller('homeController', function ($scope, userService) {
    $scope.msg = 'Welcome to home page';
    if (userService.logged) {
        console.log("logged");
      
        userService.getUserProfile().then(function (result) {
            if (result.success) {
                console.log(result);

                $scope.msg = 'Welcome to home page, ' + userService.profile.firstName;
            }

        });
    }
    else {
        console.log("not logged");
    }
});

