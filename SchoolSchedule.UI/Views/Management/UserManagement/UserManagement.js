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
    userManagementObj.createNewUser = function (user) {
        var newUser;
        newUser = $http({ method: 'Post', url: 'http://localhost:55200/api/Account/RegisterStudent', data: user })
        .then(function (response) {
            return response.data
        }, function (error) {
            console.log(error);
            return error.data
        });
        return newUser;
    };
    return userManagementObj;
});

appSchoolSchedule.controller('userManagementController', function ($scope, userManagementService) {
    $scope.msg = 'User management';

    userManagementService.getAll().then(function (results) {
        $scope.users = results;
    })

    $scope.createNewUser = function (user) {
        userManagementService.createNewUser(user).then(function (result) {
            $scope.msg = "Profile created";
            console.log(result);
        })
      
    }

})