appSchoolSchedule.factory('utilsService', function ($http, ) {
    utilsObj = {};
    utilsObj.matchPasswords = function (value, confirmValue) {
        return value == confirmValue;
    };
    return utilsObj;
});