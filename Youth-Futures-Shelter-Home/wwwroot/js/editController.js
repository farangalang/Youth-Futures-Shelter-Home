(function () {
    "use strict";

    angular.module("app-edit", []);

    // getting the exsisting module
    angular
        .module("app-edit")
        .controller("editController", function($scope) {

        });

    angular
        .module("app-edit")
        .directive("hoverEdit", function () {
            return{
                link: function($scope, element, attrs) {
                    element.on("mouseenter",
                        function() {
                            element.css("background-color", "yellow");
                        });
                    element.on("mouseleave",
                        function () {
                            element.css("background-color", "white");
                        });
                }
            }
        });
})();
