appSchoolSchedule.controller('allCoursesController', function ($scope, $location, coursesService, userService, authService) {
    authService.authorize();
 
    $scope.coursesList = [];

    userService.getUserProfile().then(function (result) {
        if (result.success === true) {
            $scope.degreeId = result.result.degreeId;
            $scope.studentId = result.result.id;
            $scope.getRemainingCourses($scope.studentId, $scope.degreeId);
        }
        else
        {
            console.log(result);
        }
    });

   
    $scope.getRemainingCourses = function (userId, degreeId) {

        coursesService.getRemainingCourses(userId, degreeId).then(function (result) {
            if (result.success === true) {
                $scope.coursesList = result.result;
            }
        });
    };


    $scope.registerToCourse = function (courseId) {
        coursesService.registerToCourse(courseId, $scope.studentId).then(function (result) {
            if(result.success === true)
            {
                $location.path('/UserCourses');
            }
        });
    };

});