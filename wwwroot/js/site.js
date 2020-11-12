// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

document.documentElement.style.fontSize = "16px";


function changeTextSize(delta) {
	var currentFontSize = parseInt(document.documentElement.style.fontSize.replace("px", ""));
	var newFontSize = currentFontSize + delta;
	document.documentElement.style.fontSize = newFontSize + "px";
};

