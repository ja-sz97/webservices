const formatRut = (rut) => {
    let getRut = ''
    try {
        for (let i = 0; i < rut.length; i++) {
            if (rut[i] != '.' && rut[i] != '-') {
                getRut += rut[i]
            }
        }
    } catch (e) {
        console.log(`error: ${e}`)
    }
    console.log(`rut: ${getRut}`)
    return getRut
}


const validaDV = (rut) => {
    let secuencia = [2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7],
        invertirRut = '',
        multiAux = 0;
    let digitosRut = formatRut(rut)

    //invertimos el digitoRut
    for (let i = digitosRut.length - 2; i >= 0; i--) {
        invertirRut = invertirRut + digitosRut[i];
    }
    // algoritmo para obtener el digito verificador
    for (let i = 0; i <= invertirRut.length - 1; i++) {
        multiAux = multiAux + (Number(invertirRut[i] * secuencia[i]));
    }
    let division = (Math.trunc(multiAux / 11)) * 11;
    let rest = multiAux - division;

    let dv = 11 - rest;
    if (dv == 11)
        dv = 0;
    else if (dv == 10)
        dv = "k";

    console.log(`digito verificador: ${dv}`);
    return dv
}

const rutCliente = (req, res) => {
    try {
        let {
            rut
        } = req.body
        let dv = validaDV(rut)
        if (rut[rut.length - 1] == dv) {
            console.log(`El digito es valido`)
            res.json({
                message: 'V',
                data: `${dv}`
            })
        } else {
            console.log(`El digito es invalido`)
            res.json({
                message: 'I',
                dv: `${dv}`
            })
        }
    } catch (e) {
        console.log(`Error: ${e}`)
        res.json({
            message: "I",
            data: `Error: ${e}`
        })
    }
}

module.exports = {
    rutCliente
}