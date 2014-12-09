(function () {
    var helloWorld = angular.module('helloWorld', []);

    helloWorld.value('zzz', [
    'foo', 'boo', 'eat', 'more', 'kale'
    ]);

    helloWorld.value('pageMethods', PageMethods);

    helloWorld.value('business', function (scope) {
        var business = {
            jumpToIt: function (scope) {
                scope.currentRow = whichOne;
                scope.prntArray = scope.zzz[scope.currentRow];
            }

        };
        return business;
    });


    //helloWorld.controller('helloWorldCtrl', function ($scope, zzz, pageMethods, business) {
    helloWorld.controller('helloWorldCtrl', function ($scope, zzz, pageMethods) {
        $scope.message = "Plunker";
        $scope.zzz = zzz;
        $scope.currentRow = 1;
        //$scope.nextRow = 0;

        $scope.changeArray = function () {
            $scope.currentRow = Number($scope.currentRow) + 1;
            if ($scope.currentRow >= $scope.zzz.length) {
                $scope.currentRow = 0;
            }

            $scope.prntArray = $scope.zzz[$scope.currentRow];
        };

        $scope.fromServerArray = function () {
            pageMethods.JunkData(function (data) {
                $scope.zzz = data;
            });
        };
        $scope.jumpToIt = function (whichOne) {
            $scope.currentRow = whichOne;
            $scope.prntArray = $scope.zzz[$scope.currentRow];
        };
        $scope.jumpToItAgain = function (whichOne) {
            pageMethods.SingleJunkData($scope.currentRow, function (data) {
                $scope.zzz[$scope.currentRow] = data;
                console.log(data);
            });
        };
        //$scope.jumpToIt = business.jumpToIt($scope);

    });

})();