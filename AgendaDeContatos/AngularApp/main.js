angular.module('agenda', ['minhasDiretivas', 'ngAnimate','ngRoute'])
    .config(function ($routeProvider, $locationProvider) {

        

        $routeProvider.when('/', {
            templateUrl: '/AngularApp/views/index.html',
            controller: 'listaContatosController'

        });


        $routeProvider.when('/contatos/edit/:ID', {
            templateUrl: '/AngularApp/views/detalhes.html',
            controller: 'ContatoController'

        });

        $routeProvider.when('/contatos/new', {
            templateUrl: '/AngularApp/views/contato.html',
            controller: 'ContatoController'

        });

        $routeProvider.otherwise({redirectTo:''})


    });