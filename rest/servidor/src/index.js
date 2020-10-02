const express = require("express");

// inicializo express
const app = express();
app.use(
  express.urlencoded({
    extended: false,
  })
);

// lectura de json
app.use(express.json());
app.use(require("./routes/index"));

// configuracion del puerto
const port = process.env.port || 4000;

app.listen(port, () => {
  console.log(`Running on port: ${port}`);
});