appSchoolSchedule.controller('editUserController', function ($scope, $location, userService, authService) {
    authService.authorize();
    userService.getUserProfile().then(function (result) {
        if (result.success === true) {
            console.log("edited", result);
            $scope.editedUser = result.result;
            $scope.fullName = $scope.editedUser.firstName + " " + $scope.editedUser.lastName;
           
        }
        else {
            window.alert('An error ocurred, please try later');
        }
    });

    $scope.editUser = function (user) {
        user.Id = $scope.Id;
        userService.editUser(user).then(function (result) {
            if (result.success === true) {
                $location.path('/UserDetails');
                console.log(result);
            }
            else {
                window.alert('An error ocurred, please try later');
            }
        })
    }

})