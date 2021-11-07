$(document).ready(function () {
    $('#img').hide();

    $('#btnSalvar').click(function () {
        //submitFormAjax();

        submitForm();
    });

    function submitForm() {
        $('#img').show();
        var customer = $('#customer').val();
        var message = "";

        if (message.length > 0) {
            alert(message);
            return;
        }

        $('#img').hide();
        $('#form').submit();
    }

    function submitFormAjax() {
        $('#img').show();
        var customer = $('#customer').val();
        var select = $('#select').val();
        var message = "";

        if (customer == '') {
            message += "Customer não preenchido!\n";
        }

        if (select == 0) {
            message += "Select não preenchido!\n";
        }

        if (message.length > 0) {
            alert(message);
            return;
        }

        $.post('/Customer/PostAjax', { CustomerName: customer }, function (data) {
            alert(data);
            $('#img').hide();

            $('#customer').val('');
            $('#select').val('0');
        });

        
    }
});

function deletarItem(id) {
    $('#IdDelete').val(id);
    $('#modalDelete').modal('show');
}

function fecharModal() {
    $('#modalDelete').modal('hide');
}