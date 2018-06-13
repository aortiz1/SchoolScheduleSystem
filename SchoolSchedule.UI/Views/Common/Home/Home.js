
appSchoolSchedule.controller('homeController', function ($scope, userService, authService, $cookies) {
    $scope.msg = 'Welcome to home page';
    authService.authorize();
    var logged = $cookies.get("logged");
    if (logged) {
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

