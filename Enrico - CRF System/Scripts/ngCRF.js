var ngApp = angular.module('ngCRF', []);

AngularModule.service('ApiCall', ['$http', function ($http) {
    var result;
    var ErrorMessage;
    var SuccessMessage;

    this.BaseWithObj = function (Controller, Method, Obj) {
        return $http({
            method: Method,
            url: "/Api/" + Controller,
            data: Obj
        });
    };

    this.Base = function (Controller, Method) {
        return $http({
            method: Method,
            url: "/Api/" + Controller
        }).then(successCallBack, errorCallBack);
    };

    this.Get = function (controllerName) {
        loading.setValue(true);
        return this.Base(controllerName, "Get").then(successCallBack, errorCallBack);
    };

    this.Get = function (controllerName, obj) {
        var config = {
            params: obj
        };

        loading.setValue(true);
        return this.BaseWithObj(controllerName, "Get", obj).then(successCallBack, errorCallBack);
    };

    this.Post = function (controllerName, obj) {
        loading.setValue(true);
        return this.BaseWithObj(controllerName, "Post", obj).then(successCallBack, errorCallBack);
    };

    this.Put = function (controllerName, obj) {
        loading.setValue(true);
        return this.BaseWithObj(controllerName, "Put", obj).then(successCallBack, errorCallBack);
    };

    this.Delete = function (controllerName, obj) {
        var config = {
            paramas: obj
        }

        loading.setValue(true);
        return this.BaseWithObj(controllerName, "Delete", obj).then(successCallBack, errorCallBack);
    };

    function successCallBack(response, data, status) {
        loading.setValue(false);
        if (SuccessMessage != "" && SuccessMessage != undefined) {
            alert(SuccessMessage);
        }
        return response.data;
    };

    function errorCallBack(response) {
        loading.setValue(false);
        if (ErrorMessage != "" && ErrorMessage != undefined) {
            alert(ErrorMessage);
        }
    };
}]);

ngApp.controller('formController', function ($scope, ApiCall) {
    $scope.SubmitForm = function (formInputs) {
        ApiCall.Post('formController', formInputs);
    }
});