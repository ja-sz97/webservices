<div class="container">
	<div class="row mt-3 d-flex justify-content-center">
		<div class="col-6">
			<form method="POST">
				<div class="form-group">
					<label for="ap">Apellido Paterno</label>
					<input type="text" class="form-control" placeholder="Apellido Paterno" name="ap">
				</div>
				<div class="form-group">
					<label for="am">Apellido Materno</label>
					<input type="text" class="form-control" placeholder="Apellido Materno" name="am">
				</div>
				<div class="form-group">
					<label for="nombres">Nombres</label>
					<input type="text" class="form-control" placeholder="Nombres" name="nombres">
				</div>
				<label>Sexo</label>
					<div class="form-check">
						<label class="form-check-label">
							<input type="radio" name="sexo" id="hombre" class="form-check-input mr-2">Hombre
						</label>
					</div>
					<div class="form-check">
						<label class="form-check-label">
							<input type="radio" name="sexo" id="mujer" class="form-check-input mr-2">Mujer
						</label>
					</div>
				<button class="btn btn-primary" type="submit">Enviar</button>
			</form>
			<div class="pt-4">
				<?php
					if ($_POST) {
						$saludo = new Controller();
						$saludo->ctrSaludo();
					}
				?>
			</div>
		</div>
	</div>
</div>