package UnidadII;
import java.io.*;
import java.lang.Object;
import java.util.regex.*;

public class AnalizarNumeroFlotante {
	public static void main(String[] args) {
//		System.out.println("Hola");
		AnalizarNumeroFlotante ANF=new AnalizarNumeroFlotante();
		
	}
	public AnalizarNumeroFlotante() {

		String Enteros="(0|(-??[1-9][0-9]*))";
		String Decimales="(0|([0-9]*[1-9]))";
		String Decimales2="([0-9]*[1-9])";
//		String Exponenciales="("+Decimales+"E?e?"+Enteros+")";
		String Exponenciales="("+Decimales2+"[eE]?"+Enteros+")";
//		Pattern p = Pattern.compile("[1-9]?[0-9]*.[0-9][1-9]+[[eE]?[-+]?]");
		Pattern p=Pattern.compile(Enteros+"[.]("+Decimales+"|"+Exponenciales+")");
		Matcher m = p.matcher("0.0E-3");
		boolean b = m.matches();
		
		System.out.println(b);
		
	}
	
	public String LeerCadena() {
		String cad="";
		InputStreamReader isr=new InputStreamReader(System.in);
		BufferedReader br=new BufferedReader(isr);
		
		System.out.println("Ingrese Cadena para validar");
		try {
			cad = br.readLine();
		}catch(IOException e) {
			System.out.println("Un error de lectura");
		}
		return cad;
		
	}
	
}
