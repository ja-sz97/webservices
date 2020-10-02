<?php
    class Controller{
        public function plantilla(){
            include "views/template.php";
        }
        #interaccion del usuario
        public function enlacesPaginasController(){

            if(isset($_GET["action"])){
                $enlacesController = $_GET["action"];
            }
            else{
                $enlacesController="index";
            }

            $respuesta = enlacesPaginas::enlacesPaginasModel($enlacesController);

            include $respuesta;
        }
        public function ctrRut(){
            $req = enlacesPaginas::Rut();
            $req_json = json_decode($req, true);
            if($req_json["message"] == "V"){
                echo '<div class="alert alert-success" role="alert">';
                echo "El rut ".$_POST["rut"]." ingresado es valido ";
                echo '</div>';
            }else{
                echo '<div class="alert alert-danger" role="alert">';
                echo "El rut ".$_POST["rut"]." ingresado es invalido wrap";
                echo '</div>';
            }
        }
        
    }

?>