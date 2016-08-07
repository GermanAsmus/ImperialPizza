var meses = ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"];

function ObtenerMes()
{
    var mes = document.getElementById('mesHeader');
    mes.innerHtml = meses[DateTime.Now.Month];
    return false;
}
   