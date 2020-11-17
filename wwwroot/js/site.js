// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function changeTextSize(delta) {
	var currentFontSize = parseInt(document.documentElement.style.fontSize.replace("px", ""));
	var newFontSize = currentFontSize + delta;
	document.documentElement.style.fontSize = newFontSize + "px";
};




jQuery(document).ready(function ($) {

	$(".btnrating").on('click', (function (e) {

		var previous_value = $("#selected_rating").val();

		var selected_value = $(this).attr("data-attr");
		$("#selected_rating").val(selected_value);

		$(".selected-rating").empty();
		$(".selected-rating").html(selected_value);

		for (i = 1; i <= selected_value; ++i) {
			$("#rating-star-" + i).toggleClass('btn-danger');
			$("#rating-star-" + i).toggleClass('btn-default');
		}

		for (ix = 1; ix <= previous_value; ++ix) {
			$("#rating-star-" + ix).toggleClass('btn-danger');
			$("#rating-star-" + ix).toggleClass('btn-default');
		}


	}));


});