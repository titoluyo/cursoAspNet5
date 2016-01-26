(function() {
    //app.controller("<NOMBRE DEL CONTROLLER>", ["SERVICIOS DE ANGULARJS A USAR", FUNCION DEL CONTROLADOR]);

    app.controller("productController", ["$scope", "$http", productController]);

    function productController($scope, $http) {
        //$scope.newProduct.Id = 0;
        //$scope.newProduct.Description = "";
        //$scope.newProduct.UnitPrice = 0;
        $scope.newProduct =
        {
            Id : 0,
            Description: "",
            UnitPrice: ""
        };

        $scope.filtroProductos = "";
        $scope.estadoNuevo = false;

        $http.get("/api/productrest").success(function(data) {
            $scope.products = data;
        }).error(function() {
            $scope.error = "Se identificó un error durante la consulta de productos";
        });

        $scope.changeStatus = function() {
            $scope.estadoNuevo = !$scope.estadoNuevo;
        };

        $scope.create = function () {
            $http.post("/api/ProductRest", $scope.newProduct).success(function(data) {
                alert("Datos del producto registrado correctamente");
                $scope.estadoNuevo = false;
                $scope.products.push($scope.newProduct);  // Actualizar lista
            }).error(function(data) {
                $scope.error = "Se presentó un error al intentar registrar un producto";
            });
        };
        $scope.update = function() {
            // TODO: llamada al servicio Rest PUT
        }
    }
}());