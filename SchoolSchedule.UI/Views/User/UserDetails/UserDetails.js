appSchoolSchedule.controller('userDetailsController', function ($scope, userService) {
    $scope.msg = 'Profile Information';
    if(userService.userId!="")
    {
        userService.getUserProfile(userService.userId).then(function (result) {

            if (result.success == true) {
                $scope.profile = result.result;
                console.log(result);

            }

        });
    }
})