$(function () {

    $("#SubTodoFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    //After abp v7.2 use dynamicForm 'column-size' instead of the following settings
    //$('#SubTodoCollapse div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#SubTodoFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/SubTodoFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('MyTodo');

    var service = myTodo.subTodos.subTodo;
    var createModal = new abp.ModalManager(abp.appPath + 'SubTodos/SubTodo/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'SubTodos/SubTodo/EditModal');

    var dataTable = $('#SubTodoTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('MyTodo.SubTodo.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('MyTodo.SubTodo.Delete'),
                                confirmMessage: function (data) {
                                    return l('SubTodoDeletionConfirmationMessage', data.record.id);
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
                title: l('SubTodoName'),
                data: "name"
            },
            {
                title: l('SubTodoDescription'),
                data: "description"
            },
            {
                title: l('SubTodoStatusTodo'),
                data: "statusTodo"
            },
            {
                title: l('SubTodoTodoId'),
                data: "todoId"
            },
            {
                title: l('SubTodoTodo'),
                data: "todo"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewSubTodoButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
