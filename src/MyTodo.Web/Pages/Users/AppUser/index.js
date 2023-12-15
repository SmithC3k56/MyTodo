$(function () {

    $("#AppUserFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    //After abp v7.2 use dynamicForm 'column-size' instead of the following settings
    //$('#AppUserCollapse div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#AppUserFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/AppUserFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('MyTodo');

    var service = myTodo.users.appUser;
    var createModal = new abp.ModalManager(abp.appPath + 'Users/AppUser/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Users/AppUser/EditModal');

    var dataTable = $('#AppUserTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,//disable default searchbox
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList,getFilter),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('MyTodo.AppUser.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('MyTodo.AppUser.Delete'),
                                confirmMessage: function (data) {
                                    return l('AppUserDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('AppUserUserName'),
                data: "userName"
            },
            {
                title: l('AppUserEmail'),
                data: "email"
            },
            {
                title: l('AppUserName'),
                data: "name"
            },
            {
                title: l('AppUserSurname'),
                data: "surname"
            },
            {
                title: l('AppUserIsActive'),
                data: "isActive"
            },
            {
                title: l('AppUserEmailConfirmed'),
                data: "emailConfirmed"
            },
            {
                title: l('AppUserPhoneNumber'),
                data: "phoneNumber"
            },
            {
                title: l('AppUserPhoneNumberConfirmed'),
                data: "phoneNumberConfirmed"
            },
            {
                title: l('AppUserBird'),
                data: "bird"
            },
            {
                title: l('AppUsertodos'),
                data: "todos"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewAppUserButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
