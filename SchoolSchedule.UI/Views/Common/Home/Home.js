appSchoolSchedule.controller('homeController', function ($scope, userService) {
    $scope.msg = 'Welcome to home page';
    if (userService.userId != "")
    {
        console.log("logged");
        userService.getUserProfile(userService.userId).then(function (result) {
            if (result.success == true) {
                console.log(result);
            
                $scope.msg = 'Welcome to home page, ' + userService.profile.FistName;
            }

        });

    }
    else
    {
        console.log("not logged");
       
    }

    
})

