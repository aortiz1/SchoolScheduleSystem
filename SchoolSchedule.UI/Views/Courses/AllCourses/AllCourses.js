appSchoolSchedule.controller('allCoursesController', function ($scope, coursesService, userService, authService) {
    authService.authorize();
 
    $scope.coursesList = [];

    userService.getUserProfile().then(function (result) {
        if (result.success === true) {
            $scope.degreeId = result.result.degreeId;
            $scope.GetCourses($scope.degreeId);
        }
        else
        {
            console.log(result);
        }
    });

   
    $scope.GetCourses = function (degreeId) {
        
        coursesService.getCoursesByDegree(degreeId).then(function (result) {
            if (result.success == true)
            {
                $scope.coursesList = result.result;
            }
        })
    };

});