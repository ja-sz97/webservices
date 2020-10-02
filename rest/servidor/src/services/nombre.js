const formatCapitalize = (name) => {
    return name.charAt(0).toUpperCase() + name.slice(1);
};

const formatLastName = (lastName) => {
    let minuscula = lastName.toLowerCase();
    let capitalize = formatCapitalize(minuscula);
    return capitalize;
};

const formatName = (name) => {
    let separar = name.split(" ");
    let primero = formatLastName(separar[0]);
    let segundo = formatLastName(separar[1]);
    let nombres = `${primero} ${segundo}`;
    console.log(nombres);
    return nombres;
};

const getSaludo = (nombres, paterno, materno, sexo) => {
    let nombre = formatName(nombres),
        aPaterno = formatLastName(paterno),
        aMaterno = formatLastName(materno);
    if (sexo === "M" || sexo === "m") return `Hola Sr. ${nombre} ${aPaterno} ${aMaterno}`;
    else if (sexo === "F" || sexo === "f") return `Hola Sra. ${nombre} ${aPaterno} ${aMaterno}`;
};

const saludoCliente = (req, res) => {
    try {
        let {
            nombres,
            paterno,
            materno,
            sexo
        } = req.body;
        let saludo = getSaludo(nombres, paterno, materno, sexo);
        res.json({
            message: "V",
            data: saludo,
        });
    } catch (e) {
        console.log(`Error: ${e}`)
        res.json({
            message: "I",
            data: `Error: ${e}`
        })
    }
};

module.exports = {
    saludoCliente
};