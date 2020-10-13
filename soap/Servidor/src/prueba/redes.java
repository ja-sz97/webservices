package prueba;

public class redes {

	public static void main(String[] args) {
		String Rut = "20237913-3";		
		System.out.println(validarut(Rut));
	}
	
	public static String validarut (String Rut) {
		int rutlength = Rut.length();
		for(int i = 0; i<rutlength; ++i) {
			int aux = 0;
			char character = Rut.charAt(i);
			int ascii = (int) character;
			if (rutlength!=10) {
				return "El rut ingresado no es valido";
			}
			
			else if(i<8 || i == 9) {
				for (int a=48; a<=57; ++a) {
					if(ascii == a) {
						++aux;}

					else if (aux == 0 && a == 57 && ascii == 107 && i != 9) {
						return "El rut ingresado no es valido";}
					else if (aux == 0 && a == 57 && ascii == 107 && i == 9) {
						++aux;}
			}
				if(aux == 0) {
					return "El rut ingresado no es valido";
				}
				}
			
			else if (i == 8 && ascii != 45) {
				
				return "El rut ingresado no es valido";
			}
		}
		return validadigito(Rut);
	}
	
	public static String validadigito (String Rut) {
		char[] invertido = new char[8];
		int aux = 2;
		int suma = 0;
		int a = 7;
		for (int i=0; i<8 ; ++i) {
			char normal = Rut.charAt(i);
			invertido[a] = normal;
			a -= 1;
		}
		
		for (int b=0; b<invertido.length; b++ ) {
			suma += Character.getNumericValue(invertido[b]) * aux;
			
			if(aux == 7) {
				aux = 1;
			}
			aux ++;
		}
		int resto = suma % 11;
		int digito = 11 - resto;
		if (digito != Character.getNumericValue(Rut.charAt(9)) && digito !=10 && digito !=11) {
			return "El rut ingresado no es valido";
		}
	
		if(digito == 11 && (int)Rut.charAt(9) != 48 ) {
			return "El rut ingresado no es valido";
		}
		
		if(digito == 10 && (int)Rut.charAt(9) != 107) {
			return "El rut ingresado no es valido";
		}
		
		return "Rut valido";
	}

}
