var app = angular.module('Homeapp', []);

app.controller('HomeController', function ($scope, $http) {

    $scope.pagesz = 3; // kar!
    $scope.pageid = 0;
    
    $scope.getrecords = function () {
        $http.get('/Home/getrecord?search=' + $scope.searchText +
            '&orgid=' + $scope.orgFilter +
            '&typeid=' + $scope.typeFilter +
            '&datefrom=' + $scope.fromFilter +
            '&dateto=' + $scope.toFilter +
            '&pageid=' + $scope.pageid +
            '&pagesz=' + $scope.pagesz).then(function (d) {
                $scope.regdata = d.data[1];
                $scope.pagenr = Math.ceil(d.data[0] / $scope.pagesz);
                console.log($scope.pagenr);
        }, function (error) {
            alert('failed');
        });
        
    }

    $scope.getorg = function () {
        $http.get('/Home/getorg').then(function (d) {
            $scope.orgdata = d.data;
        }, function (error) {
            alert('failed');
        });
    }

    $scope.gettype = function () {
        $http.get('/Home/gettype').then(function (d) {
            $scope.typedata = d.data;
        }, function (error) {
            alert('failed');
        });
    }

    $scope.getdatefrom = function () {
        $http.get('/Home/getdatefrom').then(function (d) {
            $scope.fromdate = d.data;
        }, function (error) {
            alert('failed');
        });
    }

    $scope.getdateto = function () {
        $http.get('/Home/getdateto').then(function (d) {
            $scope.todate = d.data;
        }, function (error) {
            alert('failed');
        });
    }

    $scope.orgFilter = -1;
    $scope.typeFilter = -1;
    $scope.fromFilter = "";
    $scope.toFilter = "";

    $scope.filterchanged = function () {
        console.log(" org: " + $scope.orgFilter + 
            " t: " + $scope.typeFilter +
            " f: " + $scope.fromFilter + 
            " to: " + $scope.toFilter);
        $scope.getrecords(); 
    }

    $scope.searchText = "";
    $scope.searchChange = function () {
        console.log("text=" + $scope.searchText);
        $scope.getrecords(); 
    }
     
    $scope.getdetailed = function ($id) {
        $http.get('/Home/getdetailed?id=' + $id).then(function (d) {
            $scope.detailed = d.data;          
        }, function (error) {
            alert('failed');
        });
    }

    $scope.row_clicked = function ($id) {
        console.log("row_clicked:" + $id);
        document.getElementById("detailedTable").style.visibility = "visible";
        $scope.getdetailed($id);         
    }

    $scope.page_click = function ($index) {
        console.log("page_click:" + $index);
        $scope.pageid = $index;
        $scope.getrecords(); 
    }


    $scope.getrecords(); 
    $scope.getorg();
    $scope.gettype();
    $scope.getdatefrom();
    $scope.getdateto();
    document.getElementById("detailedTable").style.visibility = "hidden";

});