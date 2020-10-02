<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
    <title>Redes</title>
</head>
<body>
    <h1>Trabajo Redes</h1>


    <?php
        include "nav.php";
    ?>


    <section>
      <?php
        $mvc = new Controller();
        $mvc -> enlacesPaginasController();
      ?>
    </section>

    <section>
      <?php
        $mvc = new enlacesPaginas();
        $mvc -> Rut();
      ?>
    </section>

</body>
</html>