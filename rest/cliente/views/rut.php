<div class="container mt-5">
	<div class="row d-flex justify-content-center">
		<div class="col-11 col-ms-11 col-lg-4 bg-white rounded border shadow-sm mx-1 mb-3 mb-lg-0">
			<h3 class="text-uppercase font-weight-bold my-4">Rut</h3>
			<hr>
			<p class="text-justify my-2 py-3">En esta sección podrás comprobar si el digito verificador que haz ingresado es <a class="badge badge-success">valido</a> o <a class="badge badge-danger">invalido</a><br><br>Solo debes ingresar el rut que quieras y el algoritmo hará todo.
			</p>
		</div>
		<div class="col-11 col-ms-11 col-lg-7 bg-white rounded border shadow-sm mx-1">
			<div class="row d-flex justify-content-center pt-4">
				<div class="col-8">
					<form method="POST">
						<div class="form-group">
							<label for="rut">Ingrese un rut :</label>
							<input type="text" class="form-control form-control-sm" placeholder="12.345.678-9" name="rut">
						</div>
						<div class="d-flex justify-content-center">
							<button type="submit" class="btn btn-success">Enviar</button>
						</div>
					</form>
					<div class="pt-4">
						<?php
						if ($_POST) {
							$respuesta = new Controller();
							$respuesta->ctrRut();
						}
						?>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
<br><br>