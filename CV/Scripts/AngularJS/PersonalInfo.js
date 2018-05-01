var app = angular.module("MyApp", []);

//GETS ALL OF THE PERSONAL INFO FROM GetPersonalInformation
app.controller("PersonalInfoController", function ($scope, $http) {
    $http.get('/Home/GetPersonalInformation').then(function (d) {
        $scope.pi = d.data;
    }, function (error) {
        alert('failed');
    }
);
});