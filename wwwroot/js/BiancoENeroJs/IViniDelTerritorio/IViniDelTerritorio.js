$(document).ready(function () {

    $('.btnPost').on('click', function () {
        var item1 = $(this).val();
        var item2 = $('.tipoVino').val();
        var elems = document.getElementsByClassName('locator');
        for (var i = 0; i < elems.length; i += 1) {
            elems[i].style.display = 'none';
        }


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

        $.ajax({
            type: "POST",
            url: "?handler=SendZone",
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
                $.each(response, function (i, item) {
                    document.getElementById(item).style.display = 'inline-block';
                });
            },
            failure: function (response) {
                alert(response);
            }
        });
    })
});