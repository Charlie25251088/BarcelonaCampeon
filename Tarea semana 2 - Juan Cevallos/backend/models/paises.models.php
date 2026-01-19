<?php

    require_once('../config/conexion.php');


class Pais
{
    public function todos()
    {
        $con = new ClaseConectar();
        $con = $con->ProcedimientoConectar();

        $cadena = "SELECT * FROM `Paises`";
        $datos = mysqli_query($con, $cadena);

        $con->close();
        return $datos;
    }

    public function uno($Codigo)
    {
        $con = new ClaseConectar();
        $con = $con->ProcedimientoConectar();

        // Codigo es varchar(2) => se usa comillas
        $Codigo = mysqli_real_escape_string($con, $Codigo);
        $cadena = "SELECT `Codigo`, `Pais` FROM `Paises` WHERE `Codigo`='$Codigo'";
        $datos = mysqli_query($con, $cadena);

        $con->close();
        return $datos;
    }

    public function repetido($Codigo)
    {
        $con = new ClaseConectar();
        $con = $con->ProcedimientoConectar();

        $Codigo = mysqli_real_escape_string($con, $Codigo);
        $cadena = "SELECT count(*) as numero FROM `Paises` WHERE `Codigo`='$Codigo'";
        $datos = mysqli_query($con, $cadena);

        $con->close();
        return $datos;
    }

    public function insertar($Codigo, $Pais)
    {
        $con = new ClaseConectar();
        $con = $con->ProcedimientoConectar();

        $Codigo = mysqli_real_escape_string($con, $Codigo);
        $Pais   = mysqli_real_escape_string($con, $Pais);

        $cadena = "INSERT INTO `Paises`(`Codigo`, `Pais`) VALUES ('$Codigo','$Pais')";

        if (mysqli_query($con, $cadena)) {
            // No hay autoincrement, devolvemos el mismo Código insertado
            $con->close();
            return 'ok';
        } else {
            $con->close();
            return 'error';
        }
    }

    public function actualizar($Codigo, $Pais)
    {
        $con = new ClaseConectar();
        $con = $con->ProcedimientoConectar();

        $Codigo = mysqli_real_escape_string($con, $Codigo);
        $Pais   = mysqli_real_escape_string($con, $Pais);

        $cadena = "UPDATE `Paises` SET `Pais`='$Pais' WHERE `Codigo`='$Codigo'";
        $datos = mysqli_query($con, $cadena);

        $con->close();
        return 'ok';
    }

    public function eliminar($Codigo)
    {
        $con = new ClaseConectar();
        $con = $con->ProcedimientoConectar();

        $Codigo = mysqli_real_escape_string($con, $Codigo);

        $cadena = "DELETE FROM `Paises` WHERE `Codigo`='$Codigo'";
        $datos = mysqli_query($con, $cadena);

        $con->close();
        return 'ok';
    }
}
