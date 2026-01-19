<?php
/*TODO: Requerimientos */
require_once("../config/cors.php");
require_once("../models/paises.models.php");
//header('Content-Type: application/json');
error_reporting(0);

$Pais = new Pais();

switch ($_GET["op"]) {

    /* TODO: Listar todos */
    case 'todos':
        $datos = $Pais->todos();
        $todos = array();
        while ($row = mysqli_fetch_assoc($datos)) {
            $todos[] = $row;
        }
        echo json_encode($todos);
        break;

    /* TODO: Obtener uno por Código */
    case 'uno':
        $Codigo = $_POST["Codigo"];
        $datos = $Pais->uno($Codigo);
        $res = mysqli_fetch_assoc($datos);
        echo json_encode($res);
        break;

    /* TODO: Insertar */
    case 'insertar':
        $Codigo = $_POST["Codigo"];
        $NombrePais = $_POST["Pais"]; // coincide con el campo de la tabla
        $respuesta = $Pais->insertar($Codigo, $NombrePais);
        echo json_encode($respuesta);
        break;

    /* TODO: Actualizar */
    case 'actualizar':
        $Codigo = $_POST["Codigo"];
        $NombrePais = $_POST["Pais"];
        $respuesta = $Pais->actualizar($Codigo, $NombrePais);
        echo json_encode($respuesta);
        break;

    /* TODO: Eliminar */
    case 'eliminar':
        $Codigo = $_POST["Codigo"];
        $respuesta = $Pais->eliminar($Codigo);
        echo json_encode($respuesta);
        break;

    /* (Opcional) Validar si existe/repetido */
    case 'repetido':
        $Codigo = $_POST["Codigo"];
        $datos = $Pais->repetido($Codigo);
        $res = mysqli_fetch_assoc($datos);
        echo json_encode($res); // { "numero": X }
        break;

    default:
        echo json_encode(array("error" => "Operación no válida"));
        break;
}
