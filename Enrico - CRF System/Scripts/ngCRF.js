var AngularModule = angular.module('ngCRF', ['ngRoute']);

AngularModule.factory('PatientCaseNumber', function () {
    var data = {};
    return {
        get: get,
        set: set
    };

    function set(newValue) {
        data = newValue;
    };

    function get() {
        return data;
    };
});

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

AngularModule.config(function ($routeProvider) {
    $routeProvider
        .when("/", { templateUrl: "/Views/main.html" })
        .when("/GetPatientCaseNumber", { templateUrl: "/Views/Forms/GetPatientCaseNumber.html" })
        .when("/FormIndex", { templateUrl: "/Views/Forms/index.html" })
        .otherwise({ templateUrl: "/Views/main.html" });
});

AngularModule.controller('mainController', function () {
});

AngularModule.controller('patientCaseNumberController', function ($location) {
    $scope.MoveToFormIndex = function () {
        $location.path('/FormIndex');
    };
});

AngularModule.controller('formController', ['PatientCaseNumber', '$scope', 'ApiCall', function (PatientCaseNumber, $scope, ApiCall, $location) {
    $scope.Form = {};
    console.log(PatientCaseNumber.get());

    $scope.SubmitForm = function (formInputs) {
        ApiCall.Post('formController', formInputs);
    }

    $scope.PostDataToServer = function (formName, form) {
        console.log(PatientCaseNumber.get());
        if (form.PatientCaseNum == undefined || form.PatientCaseNum == '') {
            alert('No patient Case Number entered');
            form.Name = formName;
            console.log(form);
        }
        else {
            form.Name = formName;
            console.log(form);
        }
    };

    $scope.ToggleCheckbox = function (nameOfArray, nameOfElement) {
        if ($scope.Form[nameOfArray].includes(nameOfElement)) {
            var iPositionOfElement = $scope.Form[nameOfArray].indexOf(nameOfElement);
            $scope.Form[nameOfArray].splice(iPositionOfElement, 1);
        }
        else {
            $scope.Form[nameOfArray].push(nameOfElement);
        }
    };

    $scope.MoveToFormIndex = function () {
        if ($scope.Form.PatientCaseNum != undefined || $scope.Form.PatientCaseNum != "") {
            PatientCaseNumber.set($scope.Form.PatientCaseNum);
            $location.path('/FormIndex');
        }
    };
}]);