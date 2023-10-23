// Utilizar el archivo site.js para definir las funciones de Javascript que van a cargar la información mediante Ajax.  
function MostarTemporadas(IdS){
    $.ajax(
        {
            type: 'POST',
            datatype: 'JSON',
            url: '/Home/VerTemporadas',
            data: {IdSerie : IdS},
            success: 
            function (response){   
                $("#TituloTemporada").html(response.List)
            }
        }

    )
        
    }

    function MostarActores(IdA){
        $.ajax(
            {
                type: 'POST',
                datatype: 'JSON',
                url: '/Home/VerActores',
                data: {IdSerie : IdS},
                success: 
                function (response){
                    $("#TituloTemporada").html(response.List)
                }
            }
    
        )
            
        }
        function MostarTemporadas(IdS){
            $.ajax(
                {
                    type: 'POST',
                    datatype: 'JSON',
                    url: '/Home/VerTemporadas',
                    data: {IdSerie : IdS},
                    success: 
                    function (response){
                        $("#TituloTemporada").html(response.List)
                    }
                }
        
            )
                
            }