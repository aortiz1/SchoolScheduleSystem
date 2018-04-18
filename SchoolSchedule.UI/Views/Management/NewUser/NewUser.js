appSchoolSchedule.controller('registerUserController', function ($scope, $cookies, $rootScope, $location, utilsService, userService) {
    $scope.msg = 'User management';

   
    $scope.createNewUser = function (user) {
      
        if (!utilsService.matchPasswords(user.Password, user.ConfirmPassword)) {
            window.alert('Password values do not match');
        }
        else {
            userService.createNewUser(user).then(function (result) {

                if (result.success == true) {
                    $cookies.put("Auth", "true");
                    $scope.msg = "Profile created";
                    $scope.userId = result.result;
                    $location.path('/Home');
                    console.log(result);
                
                }

            });
        }
    }

})