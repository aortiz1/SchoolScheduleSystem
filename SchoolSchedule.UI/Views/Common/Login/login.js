
appSchoolSchedule.controller('loginController', function ($scope, $location, userService) {
    $scope.msg = 'User management';

    $scope.login = function (userLogin) {
        console.log('user', userLogin);
        userService.login(userLogin).then(function (result) {
            if (result.success == true) {
                $scope.token = result.token;
                $scope.userId = result.Id;
                $location.path('/Home');
            }
            else {
                window.alert("User not found");
            }
        });
    }


})