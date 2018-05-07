appSchoolSchedule.controller('editUserController', function ($scope, userService, authService) {
    authService.authorize();
    //$scope.editedUser = {};
    userService.getUserProfile().then(function (result) {
        if (result.success === true) {
            console.log("edited", result);
            $scope.editedUser = result.result;
            $scope.fullName = $scope.editedUser.firstName + " " + $scope.editedUser.lastName;
        }
    });

    $scope.editUser = function (user) {
        user.Id = $scope.Id;
        userService.editUser(user).then(function (result) {
            console.log(result);
        })
    }

})