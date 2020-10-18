<?php
class enlacesPaginas
{
    public static function enlacesPaginasModel($enlacesModel)
    {
        if ($enlacesModel == "rut" || $enlacesModel == "nombre" || $enlacesModel == "saludo") {
            $module = "views/" . $enlacesModel . ".php";
        } else if ($enlacesModel == "index") {
            $module = "views/inicio.php";
        } else {
            $module = "views/inicio.php";
        }
        return $module;
    }
}
class request
{
    public static function Rut()
    {
        $data = array("rut" => $_POST['rut']);
        $api = curl_init("http://localhost:4000/rut");
        curl_setopt($api, CURLOPT_RETURNTRANSFER, true);
        curl_setopt($api, CURLOPT_CUSTOMREQUEST, "POST");
        curl_setopt($api, CURLOPT_POSTFIELDS, http_build_query($data));
        $resp = curl_exec($api);
        curl_close($api);
        if (!$resp) {
            return false;
        } else {
            return $resp;
        }
    }
    public static function Saludo()
    {
        $data = array(
            "nombres" => $_POST["nombres"],
            "paterno" => $_POST["ap"],
            "materno" => $_POST["am"],
            "sexo" => $_POST["sexo"]
        );
        $api = curl_init("http://localhost:4000/nombre");
        curl_setopt($api, CURLOPT_RETURNTRANSFER, true);
        curl_setopt($api, CURLOPT_CUSTOMREQUEST, "POST");
        curl_setopt($api, CURLOPT_POSTFIELDS, http_build_query($data));
        $resp = curl_exec($api);
        curl_close($api);
        if (!$resp) {
            return false;
        } else {
            return $resp;
        }
    }
}
