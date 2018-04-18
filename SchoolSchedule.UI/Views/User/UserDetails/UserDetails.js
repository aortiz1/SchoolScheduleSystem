appSchoolSchedule.controller('userDetailsController', function ($scope, userService) {
    $scope.msg = 'Profile Information';
    if($scope.userId!="")
    {
        userService.getUserProfile($scope.userId).then(function (result) {

            if (result.success == true) {
                $scope.profile = result.result;
                console.log(result);

            }

        });
    }
})