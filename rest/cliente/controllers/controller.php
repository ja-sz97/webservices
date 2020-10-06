<?php
class Controller
{
    public function plantilla()
    {
        include "views/template.php";
    }
    #interaccion del usuario
    public function enlacesPaginasController()
    {
        if (isset($_GET["action"]))
            $enlacesController = $_GET["action"];
        else
            $enlacesController = "index";

        $respuesta = enlacesPaginas::enlacesPaginasModel($enlacesController);

        include $respuesta;
    }
    public function ctrRut()
    {
        $res = request::Rut();
        $resJson = json_decode($res, true);
        if ($resJson["message"] == "V") {
            echo '<div class="alert alert-success" role="alert">';
            echo "El dígito verificador (" . $resJson["dv"] . ") ingresado es <strong>valido</strong>";
            echo '</div>';
        } else {
            echo '<div class="alert alert-danger" role="alert">';
            echo "El dígito verificador ingresado es <strong>invalido</strong><br>";
            echo "El dv correcto es: <strong>" . $resJson["dv"] . "</strong>";
            echo '</div>';
        }
    }
    public function ctrSaludo()
    {
        $res = request::Saludo();
        $resJson = json_decode ($res, true);
        if ($resJson["message"] == "V" ){
            echo '<div class="alert alert-success" role="alert">';
            echo "(" . $resJson["data"] . ")";
            echo '</div>';
        } else{
            echo '<div class="alert alert-danger" role="alert">';
            echo "<strong>Error</strong><br>";
            echo '</div>';
        }
    }
}
