appSchoolSchedule.controller('registerUserController', function ($scope, $cookies, $rootScope, $location, $localStorage, utilsService, userService, coursesService) {
    $scope.msg = 'User management';
    
    coursesService.getAllDegrees().then(function (response) {
        if (response.success) {
            var degrees = [];
            degrees.push({id:'null', description:'Select Degree'})
            response.result.forEach(function (item) {
                degrees.push(item);
            });
            $scope.degrees = degrees;
        }
    });
    $scope.createNewUser = function (user) {
        $localStorage.bearerHeader = {};
        if (!utilsService.matchPasswords(user.Password, user.ConfirmPassword)) {
            window.alert('Password values do not match');
        }
        else {
            userService.createNewUser(user).then(function (result) {

                if (result.success == true) {
                    var userLogin = {
                        username: user.Email,
                        password: user.Password
                    };
                    userService.login(userLogin).then(function (result) {
                        if (result.access_token !== undefined) {
                            $localStorage.token = result.access_token;
                            $localStorage.bearerHeader = {
                                Authorization: 'Bearer ' + result.access_token
                            };
                            $cookies.put('logged', true);
                            $rootScope.Auth = true;
                            $scope.userId = result.Id;
                            $location.path('/Home');
                        }
                        else {
                            window.alert("User not found");
                        }
                    });

                }
                else {
                    window.alert('An error ocurred when the user was created');
                }

            });
        }
    };
});

// nopo nopos