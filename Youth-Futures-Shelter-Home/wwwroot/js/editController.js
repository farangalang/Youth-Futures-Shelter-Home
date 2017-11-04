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
                        function () {
                            element.css("transition", ".5s ease"),
                                element.css("opacity", "0.3");
                        });
                    element.on("mouseleave",
                        function () {
                            element.css("opacity", "1");
                        });
                }
            }
        });
})();
