﻿var AngularModule = angular.module('ngCRF', ['ngRoute']);

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

AngularModule.factory('Page', function () {
    var data = {};
    return {
        get: get,
        set: set
    };

    function set(key, value) {
        data[key] = value;
    };

    function get(key) {
        return data[key];
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
        //loading.setValue(true);
        return this.Base(controllerName, "Get").then(successCallBack, errorCallBack);
    };

    this.Get = function (controllerName, obj) {
        var config = {
            params: obj
        };

        //loading.setValue(true);
        return this.BaseWithObj(controllerName, "Get", obj).then(successCallBack, errorCallBack);
    };

    this.Post = function (controllerName, obj) {
        //loading.setValue(true);
        return this.BaseWithObj(controllerName, "Post", obj).then(successCallBack, errorCallBack);
    };

    this.Put = function (controllerName, obj) {
        //loading.setValue(true);
        return this.BaseWithObj(controllerName, "Put", obj).then(successCallBack, errorCallBack);
    };

    this.Delete = function (controllerName, obj) {
        var config = {
            paramas: obj
        }

        //loading.setValue(true);
        return this.BaseWithObj(controllerName, "Delete", obj).then(successCallBack, errorCallBack);
    };

    function successCallBack(response, data, status) {
        //loading.setValue(false);
        if (SuccessMessage != "" && SuccessMessage != undefined) {
            alert(SuccessMessage);
        }
        return response.data;
    };

    function errorCallBack(response) {
        //loading.setValue(false);
        if (ErrorMessage != "" && ErrorMessage != undefined) {
            alert(ErrorMessage);
        }
    };
}]);

AngularModule.config(function ($routeProvider) {
    $routeProvider
        .when("/", { templateUrl: "/Views/main.html", controller: "mainController" })
        .when("/GetPatientCaseNumber", { templateUrl: "/Views/Forms/GetPatientCaseNumber.html", controller: "patientCaseNumberController" })
        .when("/FormIndex", { templateUrl: "/Views/Forms/index.html", controller: "formIndexController" })
        .when("/Form1", { templateUrl: "/Views/Forms/Form1.html", controller: "formController" })
        .when("/Form2", { templateUrl: "/Views/Forms/Form2.html", controller: "formController" })
        .when("/Form3", { templateUrl: "/Views/Forms/Form3.html", controller: "formController" })
        .when("/Form4", { templateUrl: "/Views/Forms/Form4.html", controller: "formController" })
        .when("/Form5", { templateUrl: "/Views/Forms/Form5.html", controller: "formController" })
        .when("/Form6", { templateUrl: "/Views/Forms/Form6.html", controller: "formController" })
        .when("/Form7", { templateUrl: "/Views/Forms/Form7.html", controller: "formController" })
        .when("/Form8", { templateUrl: "/Views/Forms/Form8.html", controller: "formController" })
        .when("/Form9", { templateUrl: "/Views/Forms/Form9.html", controller: "formController" })
        .when("/Form10", { templateUrl: "/Views/Forms/Form10.html", controller: "formController" })
        .when("/Form11", { templateUrl: "/Views/Forms/Form11.html", controller: "formController" })
        .when("/Form12", { templateUrl: "/Views/Forms/Form12.html", controller: "formController" })
        .when("/Form1CSS", { templateUrl: "./Views/Forms/Form1.css" })
        .when("/Form10CSS", { templateUrl: "./Views/Forms/Form10.css" })
        .when("/FormBaseCSS", { templateUrl: "./Views/Forms/FormBaseCSS.css" })
        .otherwise({ templateUrl: "/Views/main.html" });
});

AngularModule.controller('mainController', function ($scope, Page) {
    Page.set("Name", "Dashboard");
    $scope.Page = Page;
});

AngularModule.controller('patientCaseNumberController', function ($scope, PatientCaseNumber, $location, Page) {
    Page.set("Name", "Get Patient Case Number");

    $scope.Cancel = function () {
        $location.path('/');
    };

    $scope.MoveToFormIndex = function () {
        if ($scope.Form.PatientCaseNum != undefined && $scope.Form.PatientCaseNum != "") {
            PatientCaseNumber.set($scope.Form.PatientCaseNum);
            $location.path('/FormIndex');
        }
    };
});

AngularModule.controller('formIndexController', function (Page) {
    Page.set("Name", "Form Index");
});

AngularModule.controller('formController', ['PatientCaseNumber', '$scope', 'ApiCall', function (PatientCaseNumber, $scope, ApiCall, $location, Page) {
    $scope.Form = {};
    console.log(PatientCaseNumber.get());
    $scope.Form.PatientCaseNum = PatientCaseNumber.get();

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
            ApiCall.Post('Base', form);
        }
    };

    $scope.ToggleCheckbox = function (nameOfArray, nameOfElement) {
        if ($scope.Form[nameOfArray] == undefined) {
            $scope.Form[nameOfArray] = [];
        }

        if ($scope.Form[nameOfArray].includes(nameOfElement)) {
            var iPositionOfElement = $scope.Form[nameOfArray].indexOf(nameOfElement);
            $scope.Form[nameOfArray].splice(iPositionOfElement, 1);
        }
        else {
            $scope.Form[nameOfArray].push(nameOfElement);
        }
    };

    $scope.SetTitle = function (title) {
        Page.set("Name", title);
    };

    $scope.ReturnToFormIndex = function(){
        $location.path('/FormIndex');
    }
}]);