// const serviceNombre = require("../service/nombre");
// const serviceRut = require("../service/rut");

// module.exports = (app) => {
//     app.use("/rut", serviceRut);
//     app.use("/nombre", serviceNombre);
// };

var express = require("express");
var router = express.Router();
var {
    prueba
} = require('../services/rut');

// var {
//     responseNombreSexo
// } = require('../services/nombre');

router.post('/rut', prueba);
// router.post('/nombre', responseNombreSexo);


module.exports = router;