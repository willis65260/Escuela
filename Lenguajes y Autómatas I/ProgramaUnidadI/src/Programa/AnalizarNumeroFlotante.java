package Programa;
import java.io.*;
import java.lang.Object;
import java.util.regex.*;

public class AnalizarNumeroFlotante {
	public static void main(String[] args) {
//		System.out.println("Hola");
		AnalizarNumeroFlotante ANF=new AnalizarNumeroFlotante();
		
	}
	public AnalizarNumeroFlotante() {
		
		String Enteros="(0|([-]?[1-9][0-9]*))";
		String Decimales="(([0-9]*[1-9]))";
		String Decimales2="([0-9]*[1-9])";
//		String Exponenciales="("+Decimales+"E?e?"+Enteros+")";
		String Exponenciales="("+Decimales2+"[eE]?[+-]"+Enteros+")";
//		Pattern p = Pattern.compile("[1-9]?[0-9]*.[0-9][1-9]+[[eE]?[-+]?]");
		Pattern p=Pattern.compile("(-0[.](("+Decimales+")|("+Exponenciales+")))|("+Enteros+"[.])([0]|"+Decimales+"|"+Exponenciales+")");
		
		Matcher m = p.matcher(".0");
		boolean b = m.matches();
//		double x=-325.0e-5;
//		System.out.println(x);
		if(m.matches())
			System.out.println("Si es Flotante");
		else
			System.out.println("No es Flotante");
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
