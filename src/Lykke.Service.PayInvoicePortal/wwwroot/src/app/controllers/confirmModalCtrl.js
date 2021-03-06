﻿(function () {
    'use strict';

    angular
        .module('app')
        .controller('confirmModalCtrl', confirmModalCtrl);

    confirmModalCtrl.$inject = ['$scope', '$log', '$rootScope', '$sce'];

    function confirmModalCtrl($scope, $log, $rootScope, $sce) {
        var vm = this;

        var defaultTitle = 'Please confirm';
        var defaultTextYesBtn = 'Yes';

        vm.modal = {
            open: false,
            title: '',
            content: '',
            textYesBtn: '',
            showYesBtn: false,
            yesAction: null,
            closeAction: null
        };

        vm.handlers = {
            yes: yes,
            close: close,
            overlayClick: overlayClick
        };

        vm.events = {
            openConfirmModal: undefined
        };

        activate();

        function activate() {
            vm.events.openConfirmModal = $rootScope.$on('openConfirmModal',
                function(evt, data) {
                    open(data);
                });

            $scope.$on('$destroy',
                function () {
                    if (vm.events.openConfirmModal)
                        vm.events.openConfirmModal();
                });
        }

        function open(data) {
            $rootScope.modalOpened = true;
            vm.modal.open = true;
            vm.modal.title = data.title ? data.title : defaultTitle;
            vm.modal.content = $sce.trustAsHtml(data.content);
            vm.modal.textYesBtn = data.textYesBtn || defaultTextYesBtn;

            if (data.yesAction) {
                vm.modal.showYesBtn = true;
                vm.modal.yesAction = data.yesAction;
                vm.modal.closeAction = data.closeAction || null;
            } else {
                vm.modal.showYesBtn = false;
            }
        }

        function yes() {
            vm.modal.yesAction();
            closeModal();
        }

        function close() {
            closeModal();
            if (vm.modal.closeAction) {
                vm.modal.closeAction();
            }
        }

        function closeModal() {
            if (vm.modal.open) {
                $rootScope.modalOpened = false;
                vm.modal.open = false;
                vm.modal.yesAction = null;
            }
        }

        function overlayClick(e) {
            if (vm.modal.open) {
                e.preventDefault();
                e.stopPropagation();

                close();
            }
        }
    }
})();
