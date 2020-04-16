package Analizador;
import java.util.*;

public class HolaMundo {
	public static void main(String[] args) {
		Random rnd=new Random();
		int usos=1512;
		float total=0;
		do {
			int random=rnd.nextInt(100);
			if(random<75) {
//				usos--;
			}else {
				usos--;
			}
			total++;
			
		}while(usos>0);
		double cofres=(total/(64*54));
		System.out.println(total);
		System.out.println("Un cofre puede guardar: "+(cofres*(64*54))+" items\nlo que quiere decir que un pico de U3 consigue "+cofres+" cofres bobles llenos");
	}
	
}
