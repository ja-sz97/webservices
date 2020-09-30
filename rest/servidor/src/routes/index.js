const serviceNombre = require("../service/nombre");
const serviceRut = require("../service/rut");

module.exports = (app) => {
    app.use("/rut", serviceRut);
    app.use("/nombre", serviceNombre);
};