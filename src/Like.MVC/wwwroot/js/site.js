// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function RegisterLike() {
    var myData = {
        idArticle: "10"
    }
    $.ajax({
        url: 'Home/Update',
        type: 'POST',
        dataType: "json",
        contentType: 'application/json',
        data: JSON.stringify(myData),
        success: function (data) {
            console.log(data);
            $("#total").text(data.total);
        },
        error: function (data) {
            alert(data.Message);
        }
    });
}