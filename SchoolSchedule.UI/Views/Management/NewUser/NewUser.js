appSchoolSchedule.controller('registerUserController', function ($scope, $location , userManagementService) {
    $scope.msg = 'User management';

   
    $scope.createNewUser = function (user) {
        userManagementService.createNewUser(user).then(function (result) {
            if (result.success == true)
            {
                $scope.msg = "Profile created";
                $scope.Id = result.Id;
                $location.path('/Home');
                console.log(result);
            }
           
        });

    }

})