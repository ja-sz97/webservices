// funcion para poner el texto en capitalize (primera letra en mayuscula)
const formatCapitalize = (name) => {
    return name.charAt(0).toUpperCase() + name.slice(1);
};
// funcion que retorna el texto en el formato pedido
const formatLastName = (lastName) => {
    return formatCapitalize(lastName.toLowerCase());
};
// funcion que separa y realiza el formato al texto
const formatName = (name) => {
    // indexOf() -> -1 si no encuentra el identificador
    if (name.indexOf(' ') != -1) {
        let separar = name.split(" ");
        let primero = formatLastName(separar[0]);
        let segundo = formatLastName(separar[1]);
        return `${primero} ${segundo}`;
    } else {
        return formatLastName(name)
    }
};
// funcion que obtiene el saludo a partir del sexo ingresado
const getSaludo = (nombres, paterno, materno, sexo) => {
    let nombre = formatName(nombres),
        aPaterno = formatLastName(paterno),
        aMaterno = formatLastName(materno);
    if (sexo === "M" || sexo === "m")
        return `Hola Sr. ${nombre} ${aPaterno} ${aMaterno}`;
    else if (sexo === "F" || sexo === "f")
        return `Hola Sra. ${nombre} ${aPaterno} ${aMaterno}`;
};

const saludoCliente = (req, res) => {
    let { nombres, paterno, materno, sexo } = req.body;
    try {
        let saludo = getSaludo(nombres, paterno, materno, sexo);
        res.json({
            message: "V", //valido
            data: saludo,
        });
    } catch (e) {
        console.log(`Error: ${e}`)
        res.json({
            message: "I", //invalido
            data: `Error: ${e}`
        })
    }
};

module.exports = {
    saludoCliente
};