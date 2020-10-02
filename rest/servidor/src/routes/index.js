const express = require("express");
const router = express.Router();
const {
    rutCliente
} = require('../services/rut');
const {
    saludoCliente
} = require('../services/nombre');

router.post('/rut', rutCliente);
router.post('/nombre', saludoCliente);

module.exports = router;