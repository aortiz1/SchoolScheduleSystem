
appSchoolSchedule.controller('loginController', function ($scope, $location, userService) {
    $scope.msg = 'User management';

    $scope.login = function (userLogin) {
        console.log('user', userLogin);
        userService.login(userLogin).then(function (result) {
            if (result.access_token != undefined) {
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