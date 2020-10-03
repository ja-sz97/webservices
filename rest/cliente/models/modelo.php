<?php
    class enlacesPaginas{
        public function enlacesPaginasModel($enlacesModel){
            if($enlacesModel == "rut" || $enlacesModel == "nombre"){
                $module = "views/".$enlacesModel.".php";
            }
            else if($enlacesModel == "index"){
                $module = "views/inicio.php";
            }
            else{
                $module = "views/inicio.php";

            }
            return $module;
        }


        public function Rut(){

            if(isset($_POST['rut'])){
                $data = array("rut" => $_POST['rut']);
                // echo $data;
                $api = curl_init("http://localhost:4000/rut");
                curl_setopt($api, CURLOPT_RETURNTRANSFER, true);
                curl_setopt($api, CURLOPT_CUSTOMREQUEST, "POST");
                curl_setopt($api, CURLOPT_POSTFIELDS,http_build_query($data));
                $resp = curl_exec($api);
                curl_close($api);
                if(!$resp) {
                    return false;
                }else{
                     return $resp;
                  }
            }
        }
    }

?>