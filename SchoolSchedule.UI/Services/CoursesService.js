﻿appSchoolSchedule.factory('coursesService', function ($http, $localStorage) {
    userManagementObj = {};
    userManagementObj.getAllCourses = function (degreeId) {
        var users;
        users = $http({ method: 'Get', url: 'http://localhost:55200/api/Courses/GetCoursesByDegree?degreeId=' + degreeId }).
        then(function (response) {
            return response.data.result;
        });
        return users;
    };
    userManagementObj.getAllDegrees = function () {
        var users;
        users = $http({ method: 'Get', url: 'http://localhost:55200/api/Courses/GetAllDegrees' }).
        then(function (response) {
            console.log('degrees', response.data);
            return response.data;
        }, function (error) {
            console.log(error);
            return error.data;
        });
        return users;
    };
    userManagementObj.createNewUser = function (user) {
        var newUser;
        newUser = $http({ method: 'Post', url: 'http://localhost:55200/api/Account/RegisterStudent', data: user })
        .then(function (response) {
            return response.data;
        }, function (error) {
            console.log(error);
            return error.data;
        });
        return newUser;
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