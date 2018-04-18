appSchoolSchedule.factory('loginService', function ($http) {
    loginObj = {};
    loginObj.login = function (user) {
        var loginRequest = $http({ method: 'Post', url: 'http://localhost:55200/api/Account/Login' })
        .then(function (response) {
            return response.data;
        }, function (error) {
            console.log(error);
            return error.data;
        });
        return loginRequest;
    };

    return loginObj;
});

appSchoolSchedule.controller('loginController', function ($scope, userManagementService) {

    $scope.login = function (user) {
        userManagementService.login(user).then(function (result) {
            $localStorage.token = result.token;
            $scope.userId = result.Id;
            $window.location.href = '/home.html';
        });
    }


})