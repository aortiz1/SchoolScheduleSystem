appSchoolSchedule.factory('authService', function ($http, $cookies, $location) {
    authServiceObj = {};
    authServiceObj.authorize = function () {
        if(!$cookies.logged)
        {
            event.preventDefault();
            $location.path('/Login');
        }
    };
    return authServiceObj;
});