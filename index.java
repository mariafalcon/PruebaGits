public class Prueba3 {

String nombre = "Maria";

Scanner tec = new Scanner(System.in);

Coche c = new Coche();
}


public class Coche {


 String matricula;
}

public class Coche extends IVehiculo{


 String matricula;
String dni;s

}
public interface IVehiculo {
	
	String texto();
	void arrancar();
	void echarGasolina();
}