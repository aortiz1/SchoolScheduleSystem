/// <reference path="C:\archivos\SchoolScheduleProject\SchoolScheduleSystem\SchoolSchedule.UI\Services/UserService.js" />
/// <reference path="C:\archivos\SchoolScheduleProject\SchoolScheduleSystem\SchoolSchedule.UI\Services/AuthService.js" />


appSchoolSchedule.controller('homeController', function ($scope, userService, authService, $cookies) {
    $scope.msg = 'Welcome to home page';
    authService.authorize();
    if ($cookies.logged) {
        console.log("logged");
        console.log('is auth', $cookies.get("logged"));
        userService.getUserProfile().then(function (result) {
            if (result.success) {
                console.log(result);

                $scope.msg = 'Welcome to home page, ' + userService.profile.firstName;
            }

        });
    }
    else {
        $scope.msg = 'Welcome to home page';
    }
});

