<?php
class Controller
{
    public function plantilla()
    {
        include "views/template.php";
    }
    #interaccion del usuario
    public static function enlacesPaginasController()
    {
        if (isset($_GET["action"])){
            $enlacesController = $_GET["action"];}
        else{
            $enlacesController = "index";}

        $respuesta = enlacesPaginas::enlacesPaginasModel($enlacesController);

        include $respuesta;
    }
    public static function ctrRut()
    {
        $res = request::Rut();
        $resJson = json_decode($res, true);
        if ($resJson["message"] == "V") {
            echo '<div class="alert alert-success" role="alert">';
            echo "El dígito verificador (" . $resJson["dv"] . ") ingresado es <strong>valido</strong>";
            echo '</div>';
        }
        else if($resJson["message"] == "IN"){
            echo '<div class="alert alert-danger" role="alert">';
            echo $resJson["data"];
            echo '</div>';
        } 
        else if($resJson["message"] == "I"){
            echo '<div class="alert alert-danger" role="alert">';
            echo "El dígito verificador ingresado es <strong>invalido</strong><br>";
            echo "El dv correcto es: <strong>" . $resJson["dv"] . "</strong>";
            echo '</div>';
        }
    }
    public static function ctrSaludo()
    {
        $res = request::Saludo();
        $resJson = json_decode($res, true);
        if ($resJson["message"] == "V") {
            echo '<div class="alert alert-success" role="alert">';
            echo "<p class='text-center my-0'>" . $resJson["data"] . "</p>";
            echo '</div>';
        } else if ($resJson["message"] == "I") {
            echo '<div class="alert alert-danger" role="alert">';
            echo "<p class='text-center my-0'>" . $resJson["data"] . "</p>";
            echo '</div>';
        }
    }
}
