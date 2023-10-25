// Utilizar el archivo site.js para definir las funciones de Javascript que van a cargar la información mediante Ajax.  
function MostrarActores(IdSerie, nombre) {
    $.ajax({
        type: 'GET',
        datatype: 'JSON',
        url: '/Home/VerActores',
        data: { idS: IdSerie },
        success:
            function (response) {
                let actores = "";
                $("#Titulo").html("Cantidad de Actores " + nombre + ": " + response.length);
                for (const actor of response) {
                    actores = actores + actor.nombre + "<br>"
                }
                $("#Cuerpo").html(actores);
            }
    });
}
function MostrarTemporadas(IdSerie, nombre) {
    $.ajax({
        type: 'GET',
        datatype: 'JSON',
        url: '/Home/VerTemporadas',
        data: { idS: IdSerie },
        success:
            function (response) {
                let temporadas = "";
                $("#Titulo").html("Cantidad de Temporadas " + nombre + ": " + response.length);
                for (const temporada of response) {
                    temporadas = temporadas + temporada.numeroTemporada + ": " + temporada.tituloTemporada + "<br>"
                }
                $("#Cuerpo").html(temporadas)
            }
    });
}
function MostrarInfo(IdSerie, nombre) {
    $.ajax({
        type: 'GET',
        datatype: 'JSON',
        url: '/Home/Verinfo',
        data: { idS: IdSerie },
        success:
            function (response) {
                $("#Titulo").html("Serie: " + nombre);
                $("#Cuerpo").html(response)
            }
    });
}