angular.module('agenda').controller('listaContatosController', function ($scope, $http) {
    $scope.contatos = [];

     $scope.filtro = ''
    //Outra forma de ler os dados 
    /*$http.get("/api/contatos")
        .success(function (data) {
            $scope.contatos = data;
        })
        .error(function (erro) {
            console.log(erro);
        })*/

    //pegando a lista de contatos
    var promise = $http.get('api/contatos');
    promise.then(function (retorno) {
        console.log(retorno.data);
        $scope.contatos = retorno.data;
    }).catch(function (error) {
        console.log(error);
    });

    //removendo um contato
    $scope.remover = function (contato) {
        console.log(contato.ID);
        var promisse = $http.delete('/api/contatos/' + contato.ID);
        promise.then(function () {
            var indiceDoContato = $scope.contatos.indexOf(contato);
            $scope.contatos.splice(indiceDoContato, 1);
            
        }).catch(function (error) {
            console.log(error);
        });
    }

    


});