appSchoolSchedule.controller('editUserController', function ($scope, userService) {

    $scope.editUser = function (user) {
        user.Id = $scope.Id;
        userService.editUser(user).then(function (result) {
            console.log(result);
        })
    }

})