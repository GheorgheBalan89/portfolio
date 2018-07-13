angular.module("umbraco").controller("Rangelisteditor",
    function ($scope, $routeParams, $http, umbRequestHelper, editorState) {
        $scope.sliderValue = $scope.model.value;
        $scope.update = function () {
            $scope.sliderValue = $scope.sliderValue;
            $scope.model.value = $scope.sliderValue;
        }
});