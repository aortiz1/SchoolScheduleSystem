﻿appSchoolSchedule.factory('coursesService', function ($http, $localStorage) {
    coursesObj = {};
    coursesObj.getAllCourses = function (degreeId) {
        var users;
        users = $http({
            method: 'Get'
            , url: 'http://localhost:55200/api/Courses/GetCoursesByDegree?degreeId=' + degreeId
            , headers: $localStorage.bearerHeader
        }).
        then(function (response) {
            return response.data.result;
        });
        return users;
    };
    coursesObj.getAllDegrees = function () {
        var users;
        users = $http({
            method: 'Get'
            , url: 'http://localhost:55200/api/Courses/GetAllDegrees'
            , headers: $localStorage.bearerHeader
        }).
        then(function (response) {
            console.log('degrees', response.data);
            return response.data;
        }, function (error) {
            console.log(error);
            return error.data;
        });
        return users;
    };
    coursesObj.getCoursesByStudent = function (userId, semester) {
        var courses;
        courses = $http({
            method: 'Get'
            , url: 'http://localhost:55200/api/Courses/GetCoursesByStudent?userId=' + userId + "&semester=" + semester
            , headers: $localStorage.bearerHeader
        })
        .then(function (response) {
            return response.data;
        }, function (error) {
            console.log(error);
            return error.data;
        });
        return courses;
    };
    coursesObj.registerToCourse = function (courseId, studentId) {
        var register;
        register = $http({
            method: 'Post'
            , url: 'http://localhost:55200/api/Courses/RegisterToCourse?courseId=' + courseId + "&studentId=" + studentId
            , headers: $localStorage.bearerHeader
        })
        .then(function (response) {
            return response.data;
        }, function (error) {
            console.log(error);
            return error.data;
        });
        return register;
    };
    coursesObj.getCoursesByDegree = function (degreeId) {
        var courses;
        courses = $http({
            method: 'Get'
            , url: 'http://localhost:55200/api/Courses/GetCoursesByDegree?degreeId=' + degreeId
            , headers: $localStorage.bearerHeader
        })
        .then(function (response) {
            return response.data;
        }, function (error) {
            console.log(error);
            return error.data;
        });
        return courses;
    };
   
    coursesObj.getRemainingCourses = function (userId, degreeId) {
        var courses;
        console.log($localStorage.bearerHeader);
        courses = $http({
            method: 'Get'
            , url: 'http://localhost:55200/api/Courses/GetRemainingCourses?userId='+userId+'&degreeId=' + degreeId
            , headers: $localStorage.bearerHeader
        })
        .then(function (response) {
            return response.data;
        }, function (error) {
            console.log(error);
            return error.data;
        });
        return courses;
    };

    return coursesObj;
});