<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/estilos.css">
    <script src="https://kit.fontawesome.com/b097035380.js" crossorigin="anonymous"></script>
    <title>Web Service</title>
</head>

<body>
    <?php
    include "header.php";
    ?>
    <section>
      <?php
      $mvc = new Controller();
      $mvc->enlacesPaginasController();
      ?>
    </section>
    <?php
    include "footer.php";
    ?>
    <script src="js/jquery-3.5.1.slim.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>

</html>