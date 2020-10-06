// funcion para quitar los "." y "-" del rut ingresado
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
    // if (getRut[getRut.length - 1] == "k" || getRut[getRut.length - 1])
    return getRut
}
// algoritmo para obtener el digito verificador
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
const validaNumeros = (rut) =>{
    let rutSinDv = rut.slice(0,-1)
    console.log (rutSinDv)
    if (!isNaN(rutSinDv)){
        return true
    }
    else{
        return false
    }
}
const validaK = (rut) =>{
    let soloDv = rut[rut.length-1]
    console.log ("Dv: " + soloDv)
    if (soloDv == "k" || soloDv == "K" || !isNaN(soloDv)){
        return true
    }
    else{
        return false
    }
}
const validaFormato = (rut) =>{
    let format = formatRut(rut)
    try{
        if ((format.length == 8 || format.length == 9) && validaNumeros(format) && validaK (format)){
            return true
        }
        else{
            return false
        }

    }catch (e){
        console.log(`error: ${e}`)
    }
}
// funcion que responderá (en json) la peticion del cliente
const rutCliente = (req, res) => {
    let { rut } = req.body
    try {
        let validacion=validaFormato(rut)
        if (validacion == true){
            let dv = validaDV(rut)
            if (rut[rut.length - 1] == dv) {
                console.log(`El digito es valido`)
                res.json({
                    message: 'V',
                    dv: `${dv}`
                })
            } else {
                console.log(`El digito es invalido`)
                res.json({
                    message: 'I',
                    dv: `${dv}`
                })
            }
        }
        else{
            console.log(`El formato es invalido`)
            res.json({
                message: 'IN',
                data: "Formato invalido"
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