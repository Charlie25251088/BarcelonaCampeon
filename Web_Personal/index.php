<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <title>Web Personal - Juan Carlos</title>
    <link rel="stylesheet" href="estilos.css">
</head>

<body>

    <div class="contenedor">
        <h1>Mi Web Personal</h1>

        <section class="info">
            <h2>Información Personal</h2>
            <p><strong>Nombre:</strong> Juan Carlos Cevallos Rea</p>
            <p><strong>Teléfono:</strong> 0968903989</p>
            <p><strong>Correo:</strong> charlie2525@outlook.es</p>
            <p><strong>Carrera:</strong> Ingeniería de Software</p>
            <p><strong>Semestre:</strong> Sexto semestre</p>
        </section>

        <section class="calculadora">
            <h2>Calculadora Básica</h2>

            <form method="post">
                <input type="number" name="num1" placeholder="Número 1" required>
                <input type="number" name="num2" placeholder="Número 2" required>

                <select name="operacion">
                    <option value="sumar">Sumar</option>
                    <option value="restar">Restar</option>
                    <option value="multiplicar">Multiplicar</option>
                    <option value="dividir">Dividir</option>
                </select>

                <button type="submit">Calcular</button>
            </form>

            <?php
            if ($_SERVER["REQUEST_METHOD"] == "POST") {
                $num1 = $_POST["num1"];
                $num2 = $_POST["num2"];
                $operacion = $_POST["operacion"];
                $resultado = 0;

                if ($operacion == "sumar") {
                    $resultado = $num1 + $num2;
                } elseif ($operacion == "restar") {
                    $resultado = $num1 - $num2;
                } elseif ($operacion == "multiplicar") {
                    $resultado = $num1 * $num2;
                } elseif ($operacion == "dividir") {
                    if ($num2 != 0) {
                        $resultado = $num1 / $num2;
                    } else {
                        echo "<p class='error'>No se puede dividir entre cero</p>";
                    }
                }

                echo "<p class='resultado'>Resultado: $resultado</p>";
            }
            ?>
        </section>
    </div>

</body>

</html>