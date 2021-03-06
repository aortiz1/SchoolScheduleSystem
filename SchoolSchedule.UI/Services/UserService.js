﻿appSchoolSchedule.factory('userService', function ($http, $localStorage) {
    userServiceObj = {};
    userServiceObj.profile = {};
    userServiceObj.userId = "";
    userServiceObj.logged = false;
    userServiceObj.editUser = function (user) {
        var result;
        result = $http({ method: 'Post', url: 'http://localhost:55200/api/User/UpdateUserInformation', data: user, headers : $localStorage.bearerHeader }).
        then(function (response) {
            return response.data.result;
        }, function (error) {
            console.log(error);
            return error.data;
        });
        return result;
    };
    userServiceObj.getUserProfile = function () {
        var currentUser;
        console.log("bearer", $localStorage.bearerHeader)
        currentUser = $http({
            method: 'Get',
            url: 'http://localhost:55200/api/User/GetUserLoggedInformation',
            //headers: {
            //    Authorization: 'Bearer ' + $localStorage.token
            //}
            headers : $localStorage.bearerHeader
        })
        .then(function (response) {
            //console.log("data", response.data.result);
            userServiceObj.profile = response.data.result;
            return response.data;

        }, function (error) {
            console.log(error);
            return error.data;
        });
        return currentUser;
    };

    userServiceObj.createNewUser = function (user) {
        var newUser;
        newUser = $http({
            method: 'Post',
            url: 'http://localhost:55200/api/Account/RegisterStudent',
            data: user
        })
        .then(function (response) {
            if (response.data.success === true)
            {
                userServiceObj.userId = response.data.result;
                console.log("userid",userServiceObj.userId);
            }
            return response.data;
        }, function (error) {
            window.alert('An error happened, please try later');
            console.log(error);
            return error.data;
        });
        return newUser;
    };

    userServiceObj.login = function (user) {
      
        var loginRequest = $http({
            method: 'Post',
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            url: 'http://localhost:55200/Token',
            //data: user
            data: $.param({  grant_type: 'password', username: user.username, password: user.password })
        })
        .then(function (response) {
            console.log("data", response);
            userServiceObj.logged = true;
            return response.data;
        }, function (error) {
            console.log("login error",error);
            return error.data;
        });
        return loginRequest;
    };
    
  
    return userServiceObj;
});