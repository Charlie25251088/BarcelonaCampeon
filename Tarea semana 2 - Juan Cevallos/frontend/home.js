function init(){
    $('#countryForm').on('submit', (e)=>{
        guardar(e);
    });
}
const ruta = "http://localhost/web/Semana_2/backend/controllers/pais.controller.php?op=";
$().ready(
    ()=>{
        cargatabla();
    }
);
//?nombre=valor&otro=valor2
var cargatabla = ()=>{
    var html='';
    $.get(ruta + 'todos', (lista_paises)=>{
        lista_paises = JSON.parse(lista_paises);
        console.log(lista_paises);
        $.each(lista_paises,(index, pais)=>{
            html += `<tr>
                  <td><span class="badge text-bg-secondary code-badge">${pais.Codigo}</span></td>
                  <td>${pais.Pais}</td>
                  <td class="text-end">
                    <button class="btn btn-sm btn-outline-primary"
                            data-bs-toggle="modal" data-bs-target="#countryModal"
                            data-mode="edit" data-codigo="EC" data-pais="${pais.Pais}"
                            onclick="solouno('${pais.Codigo}')"
                            >
                      Editar
                    </button>
                    <button class="btn btn-sm btn-outline-danger"
                            onclick="eliminar('${pais.Codigo}')">
                      Eliminar
                    </button>
                  </td>
                </tr>`;
        });
        $('#countriesTbody').html(html);
    })
}

var guardar = (e)=>{
    //se va ausar cuando se cree un nuevo país
    //cuando se edita un pais
    e.preventDefault();
    //var formdata = $('#countryForm').serialize();
    url = "";
    paisid =document.getElementById('paisid').value;
    var formdata = new FormData($('#countryForm')[0]);
    var pais={
        Codigo: $('#Codigo').val(),
        Pais: $('#Pais').val()
    }
    if(paisid==""){
        url = ruta + 'insertar';
    }else{
        url = ruta + 'actualizar';
        //formdata.append('id', paisid);
    }

    //$.post('url', datos, ()=>{})
    $.ajax({
        url: url,
        method: 'POST',
        data: formdata,
        processData: false,
        contentType: false,
        cache: false,
        success: (valor)=>{
            valor = JSON.parse(valor);
            if(valor=='ok'){
                $('#countryModal').modal('hide');
                cargatabla();
            }else{
                alert('Ocurrió un error');
            }
        },
        error: (err)=>{
            console.log(err);
        }
        
    });
}

var solouno = (Codigo)=>{
    $('#countryModalLabel').html('Editar país');
    $.post(ruta + 'uno' 
        ,{ Codigo: Codigo },
        (data)=>{
            data = JSON.parse(data);
            console.log(data);
            $('#Codigo').val(data.Codigo);
            $('#Pais').val(data.Pais);
            $('#paisid').val(data.Codigo);

        });
}

var eliminar = (codigo)=>{

Swal.fire({
  title: "¿Estás seguro?",
  text: "¡No podrás revertir esto!",
  icon: "warning",
  showCancelButton: true,
  confirmButtonColor: "#d33",
  cancelButtonColor: "#3085d6",
  confirmButtonText: "Sí, eliminar!"
}).then((result) => {
  if (result.isConfirmed) {

  $.post(ruta + 'eliminar',
        { Codigo: codigo },
        (valor)=>{
            valor = JSON.parse(valor);
            if(valor=='ok'){
                $('#deleteModal').modal('hide');
                cargatabla();
                 Swal.fire({
      title: "Eliminado!",
      text: "El país ha sido eliminado.",
      icon: "success"
    });
            }else{
                alert('Ocurrió un error');
            }
        });


   
  }
});





  
    
}


var limpiar = ()=>{
    $('#countryModalLabel').html('Nuevo país');
    $('#Codigo').val('');
    $('#Pais').val('');
    $('#paisid').val('');
    $('#countryForm')[0].reset();
    $('#countryModal').modal('hide');

};
init();