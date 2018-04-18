appSchoolSchedule.factory('userManagementService', function ($http) {
    userManagementObj = {};
    userManagementObj.getAll = function () {
        var users;
        users = $http({ method: 'Get', url: 'http://localhost:55200/GetAllUsers' }).
        then(function (response) {
            return response.data.result;
        });
        return users;
    };
   
    
    return userManagementObj;
});

appSchoolSchedule.controller('userManagementController', function ($scope, $location, userManagementService) {
    $scope.msg = 'User management';

    //userManagementService.getAll().then(function (results) {
    //    $scope.users = results;
    //})

   
    


})