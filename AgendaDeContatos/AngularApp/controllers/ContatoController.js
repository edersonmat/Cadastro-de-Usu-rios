angular.module('agenda').controller('ContatoController', function ($scope, $http, $routeParams) {

    $scope.contato = {};
    //var id = $routeParams.ID;
   // console.log(id);

    if ($routeParams.ID) {

        var promise = $http.get('api/contatos/' + $routeParams.ID);
        promise.then(function (retorno) {
            $scope.contato = retorno.data;
        }).catch(function (error) {
            alert('Não possível obter os dados do contato');
            console.log(error);
        });

       
                     
    }


    $scope.submeter = function () {

        if ($routeParams.ID) {

            var promise = $http.put('api/contatos/' + $routeParams.ID, $scope.contato);
            promise.then(function () {
                alert('Contato alterado com sucesso');

            }).catch(function (error) {
                console.log(error);
                alert('Não foi possível alterar o contato');
            });



        } else {

            var promise = $http.post('api/contatos/', $scope.contato);
            promise.then(function () {
                alert('contato cadastrado com sucesso');
                console.log($scope.contato);
            }).catch(function (error) {
                console.log(error);
                alert('Não foi possível cadastrar o contato');
            });



        };
    };


});