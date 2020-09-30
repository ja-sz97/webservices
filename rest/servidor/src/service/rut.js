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