$(document).ready(function ($) {
            $("#right").on('click', (function () {
                document.getElementById("left").removeAttribute("disabled");
                var previous_value = document.getElementById("hidden").getAttribute("value");
                var selected_value = parseInt(previous_value) + 1;
                if (selected_value >= 1)
                {
                    document.getElementById("right").setAttribute("disabled", true);
                }
                document.getElementById("hidden").setAttribute("value", selected_value);
                document.getElementById("par" + selected_value).style.display = "table-cell";
                document.getElementById("par" + previous_value).style.display = "none";


                return;

            }));

            $("#left").on('click', (function (e) {

                document.getElementById("right").removeAttribute("disabled");
                var previous_value = document.getElementById("hidden").getAttribute("value");
                var selected_value = parseInt(previous_value) - 1;
                if (selected_value <= 0)
                {
                    document.getElementById("left").setAttribute("disabled", true);
                }
                document.getElementById("hidden").setAttribute("value", selected_value);
                document.getElementById("par" + selected_value).style.display = "table-cell";
                document.getElementById("par" + previous_value).style.display = "none";
                return;

            }));

});
