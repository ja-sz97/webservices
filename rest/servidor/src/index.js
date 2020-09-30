const express = require("express");

// rutas
// const routes = require('./routes/index')

const app = express();
app.use(
  express.urlencoded({
    extended: false,
  })
);

app.use(express.json());
app.use(require("./routes/index"));
// routes(app)

// port
const port = process.env.port || 4000;

app.listen(port, () => {
  console.log(`Running on port: ${port}`);
});
