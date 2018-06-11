appSchoolSchedule.controller('coursesStudentController', function ($scope, $location, coursesService, userService, authService) {
    authService.authorize();

    $scope.coursesStudentList = [];

    userService.getUserProfile().then(function (result) {
        if (result.success === true) {
            $scope.degreeId = result.result.degreeId;
            $scope.studentId = result.result.id;
            $scope.semester = result.result.currentSemester;
            $scope.getCoursesByStudent($scope.studentId, $scope.semester);
        }
        else {
            console.log(result);
        }
    });


    $scope.getCoursesByStudent = function (userId, semester) {

        coursesService.getCoursesByStudent(userId, semester).then(function (result) {
            if (result.success === true) {
                $scope.coursesStudentList = result.result;
            }
        });
    };



});