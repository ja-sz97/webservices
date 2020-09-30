const express = require('express')

// rutas
// const routes = require('./src/routes')

const app = express()
app.use(express.urlencoded({
    extended: false
}));

// routes(app)

// port
const port = process.env.port || 4000

app.listen(port, () => {
    console.log(`Running on port: ${port}`)
})