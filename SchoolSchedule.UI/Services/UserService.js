appSchoolSchedule.factory('userService', function ($http, $localStorage) {
    userServiceObj = {};
    userServiceObj.profile = {};
    userServiceObj.userId = "";
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
        newUser = $http({
            method: 'Get',
            url: 'http://localhost:55200/api/User/GetUserInformation?userId=' + userId,
            headers: {
                'Content-Type': 'application/json',
                Authorization: 'Bearer ' + $localStorage.token
            }
        })
        .then(function (response) {
            //console.log("data", response.data.result);
            userServiceObj.profile = response.data.result;
            return response.data

        }, function (error) {
            console.log(error);
            return error.data
        });
        return newUser;
    };
    userServiceObj.createNewUser = function (user) {
        var newUser;
        newUser = $http({ method: 'Post', url: 'http://localhost:55200/api/Account/RegisterStudent', data: user })
        .then(function (response) {
            if (response.data.success == true)
            {
                userServiceObj.userId = response.data.result;
                console.log("userid",userServiceObj.userId);
            }
            return response.data
        }, function (error) {
            window.alert('An error happened, please try later');
            console.log(error);
            return error.data
        });
        return newUser;
    };

    userServiceObj.login = function (user) {
      
        var loginRequest = $http({
            method: 'Post',
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            url: 'http://localhost:55200/Token',
            //data: user
            data: $.param({  grant_type: 'password', username: user.username, password: user.password }),
        })
        .then(function (response) {
            console.log("data", response);
            userServiceObj.userId = response.data.userId;
            return response.data;
        }, function (error) {
            console.log("login error",error);
            return error.data;
        });
        return loginRequest;
    };
   
  
    return userServiceObj;
});