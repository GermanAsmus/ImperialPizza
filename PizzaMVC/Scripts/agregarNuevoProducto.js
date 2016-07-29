//$('#myTable > tbody:last-child').append("<tr><td> @Html.DropDownList('ProductoID', null, htmlAttributes: new { @class = 'form-control'})</td><td>@Html.Editor('Cantidad', new { htmlAttributes = new { @class = 'form-control' } })</td><td>@Html.Display('Precio', new { htmlAttributes = new { @class = 'form-control' } }) </td></tr>");
function myFunction() {
    var table = document.getElementById('myTable');
    var len = table.rows.length-1;
    var row = table.rows[len].cloneNode(true);
    table.appendChild(row);
    return false;
}