$(document).ready(function () {

    $('.btnPost').on('click', function () {
        var item = $(this).val();
        $("#VinoSelected").val(item);
    })

    $('.locator').on('click', function () {
        var item1 = $("#VinoSelected").val();
        var item2 = $(".tipoVino").val();
        var item3 = $(event.target).data('nome-zona');
        if (item1 != null && item1 != "") {
            $.ajax({
                type: "POST",
                url: "?handler=Check",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader("XSRF-TOKEN",
                        $('input:hidden[name="__RequestVerificationToken"]').val());
                },
                data: JSON.stringify({
                    Item1: item1,
                    Item2: item2,
                    Item3: item3,
                }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    $("#" + item3).css("display", "none");
                    if (response == true) {
                        $("#" + item1).css("background-color", "green");
                        $("#" + item1).css("color", "white");
                        $("#" + item3 + "_True").css("display", "inline-block");
                    }

                    else {
                        $("#" + item1).css("background-color", "white");
                        $("#" + item1).css("color", "brown");
                        $("#" + item3 + "_False").css("display", "inline-block");
                    }
                },
                failure: function (response) {
                    alert(response);
                }
            });
        }

    })
        
    
});