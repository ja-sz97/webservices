<div class="container mt-5">
	<div class="row d-flex justify-content-center">
		<div class="col-11 col-ms-11 col-lg-4 bg-white rounded border shadow-sm mx-1 mb-3 mb-lg-0">
			<h3 class="text-uppercase font-weight-bold my-4">Obtener Saludo</h3>
			<hr>
			<p class="text-justify my-2 py-3">En esta sección podrás obtener un <a class="badge badge-primary">saludo</a> personalizado a partir de tus apellidos, tus nombres y tu sexo.<br><br>Solo ingresa tus datos en los campos disponibles y presiona <a class="badge badge-success">enviar</a>.
			</p>
		</div>
		<div class="col-11 col-ms-11 col-lg-7 bg-white rounded border shadow-sm mx-1">
			<div class="row d-flex justify-content-center pt-4">
				<div class="col-10">
					<form method="POST">
						<div class="row">
							<div class="col-6">
								<div class="form-group">
									<label for="">Apellido Paterno</label>
									<input type="text" class="form-control form-control-sm" placeholder="Ingresa tu apellido paterno" name="ap">
								</div>
							</div>
							<div class="col-6">
								<div class="form-group">
									<label for="">Apellido Materno</label>
									<input type="text" class="form-control form-control-sm" placeholder="Ingresa tu apellido paterno" name="am">
								</div>
							</div>
						</div>
						<div class="form-group">
							<label for="">Nombres</label>
							<input type="text" class="form-control form-control-sm" placeholder="Ingresa tus nombres" name="nombres">
						</div>
						<label>Sexo</label>
						<br>
						<div class="form-check form-check-inline">
							<input type="radio" name="sexo" value="M" class="form-check-input mr-2">
							<label class="form-check-label">M</label>
						</div>
						<div class="form-check form-check-inline">
							<input type="radio" name="sexo" value="F" class="form-check-input mr-2">
							<label class="form-check-label">F</label>
						</div>
						<div class="d-flex justify-content-center">
							<button class="btn btn-success" type="submit">Enviar</button>
						</div>
					</form>
					<div class="pt-4">
						<?php
						if ($_POST) {
							if (isset($_POST["sexo"])) {
								$saludo = new Controller();
								$saludo->ctrSaludo();
							} else {
								echo '<div class="alert alert-danger" role="alert">';
								echo "<p class='text-center my-0'>Formato invalido, complete todos los campos</p>";
								echo '</div>';
							}
						}
						?>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
<br><br>