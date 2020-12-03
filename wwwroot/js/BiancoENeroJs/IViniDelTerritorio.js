function runClick() {
    document.getElementById("text").style.display = "block";
    return;

};

$(function () {
    $('#btn').on('click', function (evt) {
        evt.preventDefault();
        $.post('', $('form').serialize(), function () {
            alert('Posted using jQuery');
        });
    });
});
