$(document).ready(function () {

    $('.btnPost').on('click', function () {
        var item1 = $(this).val();
        var item2 = $('.tipoVino').val();
        
        $.ajax({
            type: "POST",
            url: "?handler=Send",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: JSON.stringify({
                Item1: item1,
                Item2: item2
            }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                document.getElementById("text1").style.display = "block";
                var dvItems = $("#text");
                dvItems.empty();
                $.each(response, function (i, item) {
                    var $tr = $('<p id=par' + i + '>').append(item).appendTo(dvItems); 
                });
            },
            failure: function (response) {
                alert(response);
            }
        });
    })
});