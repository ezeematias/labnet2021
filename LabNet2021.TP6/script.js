"use strict";
let countBox = 0;
let flag = false;
function MessageString(count) {
    let message = "Debe ingresar un ";
    if (count == 1) {
        message += "nombre válido.";
    } else if (count == 2) {
        message += "apellido válido.";
    } else {
        message += "nombre y un apellido válidos.";
    }
    return message;
}
$(document).ready(function () {
    $("#submit").click(function () {
        if (!$('#txtName').val()) {
            countBox++;
            flag = true;
        }
        if (!$('#txtLastName').val()) {
            countBox += 2;
            flag = true;
        }
        if (flag) {
            alert(MessageString(countBox));
            countBox = 0;
            flag = false;
        }
        clean;
    })
    $("#clean").click(function () {
        $("#infoUser").find('input:text').val('');
        $("input[type=number]").val('');
        if ($("input:radio[name=gender]").is(':checked')) {
            $("input:radio[name=gender]:checked")[0].checked = false;
        }
    })
});

