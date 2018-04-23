
appSchoolSchedule.controller('loginController', function ($scope, $location, $localStorage, userService) {
    $scope.msg = 'User management';

    $scope.login = function (userLogin) {
        console.log('user', userLogin);
        userService.login(userLogin).then(function (result) {
            if (result.access_token != undefined) {
                $localStorage.token = result.access_token;
                $scope.userId = result.Id;
                $location.path('/Home');
            }
            else {
                window.alert("User not found");
            }
        });
    };


});