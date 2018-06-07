appSchoolSchedule.factory('authService', function ($http, $cookies, $location) {
    authServiceObj = {};
    authServiceObj.authorize = function () {
        var logged = $cookies.get('logged');
        if (logged == 'true')
            logged = true;
        if (logged == undefined)
            logged = false;

        if (logged != true)
        {
            event.preventDefault();
         
            console.log("redirect auht service");
            $location.path('/Login');
        }
    };
    return authServiceObj;
});