$(document).ready(function () {
    $('#btnAdd').on('click', function () {
        var selectPropertyValue = $('#selectProperty').val();
        var selectPropertyText = $('#selectProperty option:selected').text();
        var txtProperty = $('#txtPropertyValue').val();

        var message = validarCamposProperties(selectPropertyValue, txtProperty);

        if (message == "") {
            //adicionar na tabela
            if (validarAddTabela(selectPropertyText)) {
                preencherTabela(selectPropertyValue, selectPropertyText, txtProperty);
            }
            else {
                alert('O item já foi adicionado!');
            }
        }
        else {
            alert(message);
        }

        limparCampos();
    });

    $('#btnSave').on('click', function () {
        salvarInformacao();
    });

    function validarCamposProperties(selectProperty, txtPropertyValue) {
        var message = "";

        if (selectProperty == "0") {
            message += "Preencha o campo Property Name\n";
        }

        if (txtPropertyValue == "") {
            message += "Preencha o campo Property Value\n";
        }

        return message;
    }

    function preencherTabela(selectPropertyId, selectProperty, txtPropertyValue) {
        var content = "";

        content += "<tr>";
        content += `<td>${selectProperty}</td>`;
        content += `<td>${txtPropertyValue}</td>`;
        content += "<td><button onclick='deletarRow(this);' class='btn btn-danger'>X</button></td>";
        content += `<td hidden>${selectPropertyId}</td>`;
        content += "</tr>";

        $('#bodyTable').append(content);
    }

    function validarAddTabela(value) {
        var result = true;

        $('#table > tbody > tr').each(function () {
            var tr = $(this)[0];

            var tdPropertyName = tr.children[0];

            if (tdPropertyName.innerText == value) {
                result = false;
            }
        });

        return result;
    }

    function limparCampos() {
        $('#selectProperty').val("0");
        $('#txtPropertyValue').val("");
    }
});

function deletarRow(btn) {
    var tr = $(btn).closest('tr');

    var result = confirm("Deseja remover o item?");

    if (result) {
        tr.remove();
    }
}

function salvarInformacao() {
    var model = {
        AssemblyName : '',
        Factory: {
            Id : 0
        },
        Customer: {
            Id: 0
        },
        Properties: []
    }

    model.AssemblyName = $('#txtAssemblyName').val();
    model.Factory.Id = $('#selectFactory').val();
    model.Customer.Id = $('#selectCustomer').val();

    $('#table > tbody > tr').each(function () {
        var tr = $(this)[0];

        var tdPropertyValue = tr.children[1];
        var tdPropertyId = tr.children[3];

        model.Properties.push({
            FK_Property: parseInt(tdPropertyId.innerText),
            PropertyValue: tdPropertyValue.innerText
        });
    });

    var json = JSON.stringify(model);

    $('#jsonObject').val(json);
    $('#form').submit();
}