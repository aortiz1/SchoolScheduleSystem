appSchoolSchedule.factory('userService', function ($http) {
    userServiceObj = {};
    userServiceObj.editUser = function (user) {
        var result;
        result = $http({ method: 'Post', url: 'http://localhost:55200/api/Account/UpdateUserInformation', data: user }).
        then(function (response) {
            return response.data.result;
        }, function (error) {
            console.log(error);
            return error.data
        });
        return result;
    };
    userServiceObj.getUserProfile = function (userId) {
        var newUser;
        newUser = $http({ method: 'Get', url: 'http://localhost:55200/api/Account/GetUserInformation/'+ userId})
        .then(function (response) {
            return response.data
        }, function (error) {
            console.log(error);
            return error.data
        });
        return newUser;
    };
  
    return userServiceObj;
});