appSchoolSchedule.factory('userManagementService', function ($http) {
    userManagementObj = {};
    userManagementObj.getAll = function () {
        var users;
        users = $http({ method: 'Get', url: 'http://localhost:55200/GetAllUsers' }).
        then(function (response) {
            return response.data.result;
        });
        return users;
    };
   
    userManagementObj.login = function (user) {
        var loginRequest;
        loginRequest = $http({ method: 'Post', url: 'http://localhost:55200/api/Account/Login', data: user })
        .then(function (response) {
            return response.data;

        },
        function (error) {
            return error.data;
        }
        );
        return loginRequest;
    };
    return userManagementObj;
});

appSchoolSchedule.controller('userManagementController', function ($scope, userManagementService) {
    $scope.msg = 'User management';

    //userManagementService.getAll().then(function (results) {
    //    $scope.users = results;
    //})

   
    $scope.login = function (user) {
        userManagementService.login(user).then(function (result) {
            $localStorage.token = result.token;
            $scope.userId = result.Id;
            $window.location.href = '/home.html';
        });
    }


})