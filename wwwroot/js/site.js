function mostrarSeries(IdS)
{
    console.log("entre");
    $.ajax(
        {
            type: "POST",
            dataType: "JSON",
            url: "/Home/VerDetalleSerie",
            data: {IdSerie: IdS},
            success:
            function(response)
            {
                console.log(response.nombre);
                $("#Nombre").html(response.nombre);
                //$("#AñoIncio").html(response.añoInicio);
                $("#InfoSerie").html(response.sinopsis);
                //$("#ImagenSerie").attr("src", "/" + response.imagenSerie);
            }
        }
    );
}
function mostrarTemporadas(IdS)
{
    console.log("entre");
    $.ajax(
        {
            type: "POST",
            dataType: "JSON",
            url: "/Home/cargarTemporadas",
            data: {IdSerie: IdS},
            success:
            function(response)
            {
                $("#Nombre").html("");
                $("#InfoSerie").html("");
                for (const Temporadas of response) 
                {
                    $("#InfoSerie").html(Temporadas.TituloTemporadas)
                }
            }
        }
    );
}
function mostrarActores(IdS)
{
    $.ajax(
        {
            type: "POST",
            dataType: "JSON",
            url: "/Home/cargarActores",
            data: {IdSerie: IdS},
            success:
            function(response)
            {   
                $("#Nombre").html("");
                $("#InfoSerie").html("");
                for (const Actores of response) 
                {
                    $("#InfoSerie").html(Actores.nombre)
                }
            }
        }
    );
}