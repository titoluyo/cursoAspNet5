// Definir funcionalidades que se ejecuten inmediatamente --> IIFE
var app;
(function() {  // <<-- Esto es un IIFE
    "use strict";  // controlar la sintaxis
    app = angular.module("productManagement", []);
}());