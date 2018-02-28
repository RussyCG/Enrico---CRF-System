var AngularModule = angular.module('ngCRF', ['ui.bootstrap', 'ui.bootstrap.datetimepicker']);

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

AngularModule.controller('formController', function ($scope, ApiCall) {
    $scope.Form = {};

    var CheckBoxContainers = ['HistoryOfCardiacRiskFactors', 'HistoryOfCardiacDisease', 'HistoryOfRespiratoryDisease', 'HistoryOfRenalDisease', 'HistoryOfVascularDisease', 'HistoryOfOtherDiseases', 'SurgicalInterventions'];

    for (var i = 0; i < CheckBoxContainers.length; i++) {
        $scope.Form[CheckBoxContainers[i]] = [];
    }

    var DateTimePickers2 = [{ Name: 'dtInformedConsent', containers: { Section: 'InformedConsent', idInner: 'indtInformedConsent', Subsection: null } },
        { Name: 'dtPhysicalAssessment', containers: { Section: 'PhysicalAssessment', idInner: 'indtPhysicalAssessment', Subsection: null } },
        { Name: 'dtStudyRandomization', containers: { Section: 'StudyRandomisation', idInner: 'indtStudyRandomization', Subsection: null } },
        { Name: 'dtHistoryOfVascularDiseaseStroke', containers: { Section: 'HistoryOfVascularDisease', idInner: 'indtHistoryOfVascularDiseaseStroke', Subsection: 'Stroke' } },
        { Name: 'dtSurgicalInterventionCardiacSurgery', containers: { Section: 'SurgicalInterventions', idInner: 'indtSurgicalInterventionCardiacSurgery', Subsection: 'CardiacSurgery' } },
        { Name: 'dtSurgicalInterventionCarotidSurgery', containers: { Section: 'SurgicalInterventions', idInner: 'indtSurgicalInterventionCarotidSurgery', Subsection: 'CarotidSurgery' } },
        { Name: 'dtSurgicalInterventionOtherSurgery', containers: { Section: 'SurgicalInterventions', idInner: 'indtSurgicalInterventionOtherSurgery', Subsection: 'OtherSurgery' } }
    ];

   
   /* $(function () {

        for (var i = 0; i < DateTimePickers2.length; i++) {
            var dateTimePicker = DateTimePickers2[i];
           
            $("#" + dateTimePicker.Name).on("dp.change", function () {
                if (dateTimePicker.containers.Subsection == null) {
                    console.log(document.getElementById(DateTimePickers2.Name));       
                    $scope.Form[dateTimePicker.containers.Section] = {};
                    $scope.Form[dateTimePicker.containers.Section].DateTime = $("#" + dateTimePicker.containers.idInner).val();
                }
                else {
                    console.log(document.getElementById(dateTimePicker.Name));
                   // console.log(DateTimePickers2)
                    $scope.Form[dateTimePicker.containers.Section][dateTimePicker.containers.Subsection] = {};
                    $scope.Form[dateTimePicker.containers.Section][dateTimePicker.containers.Subsection].DateTime = $("#" + dateTimePicker.containers.idInner).val();
                }
            });
        }

        //$("#dtSurgicalInterventionOtherSurgery").on("dp.change", function () {
        //    $scope.Form.SurgicalInterventions.OtherSurgery = {};
        //    $scope.Form.SurgicalInterventions.OtherSurgery.DateTime = $("#indtSurgicalInterventionOtherSurgery").val();
        //});

   


    });
    */
    
$scope.SubmitForm = function (formInputs) {
        ApiCall.Post('formController', formInputs);
    }

    $scope.PostDataToServer = function (formName, form) {
        form.Name = formName;
        console.log(form);
        console.log($scope.Form);
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
});