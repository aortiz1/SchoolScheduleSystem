
appSchoolSchedule.controller('loginController', ['$scope', '$rootScope', '$location', '$cookies', '$localStorage', 'userService', function ($scope,$rootScope, $location, $cookies, $localStorage, userService) {
    $scope.msg = 'User management';

    $scope.login = function (userLogin) {
        //console.log('user', userLogin);
        $localStorage.bearerHeader = {};
        $cookies.logged = false;
        $rootScope.Auth = false;
        userService.login(userLogin).then(function (result) {
            if (result.access_token !== undefined) {
                $localStorage.token = result.access_token;
                $localStorage.bearerHeader = {
                    Authorization: 'Bearer ' + result.access_token
                };
                $cookies.role = "";
                $cookies.logged = true;
                $rootScope.Auth = true;
                $scope.userId = result.Id;
                $location.path('/Home');
            }
            else {
                window.alert("User not found");
            }
        });
    };


}]);
 