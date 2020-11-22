$(document).ready(function ($) {
            $("#right").on('click', (function (e) {
                document.getElementById("left").removeAttribute("disabled");
                var previous_value = document.getElementById("hidden").getAttribute("value");
                var selected_value = parseInt(previous_value) + 1;
                document.getElementById("hidden").setAttribute("value", selected_value);
                document.getElementById("par" + selected_value).style.display = "table-cell";
                document.getElementById("par" + previous_value).style.display = "none";

                if (selected_value >= 3) {
                    document.getElementById("right").setAttribute("disabled", true);
                }

                return;

            }));

        $("#left").on('click', (function (e) {

            document.getElementById("right").removeAttribute("disabled");
            var previous_value = document.getElementById("hidden").getAttribute("value");
            var selected_value = parseInt(previous_value) - 1;
            document.getElementById("hidden").setAttribute("value", selected_value);
            document.getElementById("par" + selected_value).style.display = "table-cell";
            document.getElementById("par" + previous_value).style.display = "none";

            if (selected_value <= 1) {
            document.getElementById("left").setAttribute("disabled", true);
            }

            return;

        }));

});
