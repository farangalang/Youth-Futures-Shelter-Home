(function () {
    'use strict';

    // getting the exsisting module
    angular
        .module('app-edit')
        .controller('editController', editController);

    function editController() {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'editController';

        
    }
})();
