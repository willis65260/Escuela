package Analizador;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.net.URL;
public class Analizador extends JFrame {
	JPanel Menu,botones,nombre;
	JTextPane Contenido;
	JFileChooser  explo;
	JButton guardar,cerrar,abrir,analizar;
	JLabel name;
	URL ruta;
	public Analizador() {
		super("Analizador");
		setSize(800,600);
		Dimension pantalla = Toolkit.getDefaultToolkit().getScreenSize();
	      int height = pantalla.height;
	      int width = pantalla.width;
	      setLocationRelativeTo(null);
	      //Componentes 
	      Menu =new JPanel();
	      botones=new JPanel();
	      nombre=new JPanel();
	      name= new JLabel();
	      name.setText("Nombre archivo XD.tpb");
	      add(Menu, BorderLayout.NORTH);
	      Menu.setLayout(new GridLayout(2,1));
	      botones.setLayout(null);
	     botones.setBounds(0, 0, 500, 50);
	      nombre.setLayout(new FlowLayout());
	      guardar=new JButton();
	      cerrar=new JButton("Cerrar");
	      abrir=new JButton("Abrir");
	      analizar=new JButton("Analizar");
	      ruta = getClass().getResource("/Analizador/img/guardar.png");
	      guardar.setIcon(new ImageIcon(ruta));
	      guardar.setBounds(0, 0, 100, 50);
	   //   guardar.setSize(50, 100);
//	      guardar.setOpaque(false);
	      
	      botones.add(abrir);
	      botones.add(guardar);
	      botones.add(cerrar);
	      botones.add(analizar);
	      nombre.add(name);
	      Menu.add(botones);
	      Menu.add(nombre);
	      //Componentes
	      
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setVisible(true);
	}
	public static void main(String[] args) {
		new Analizador();

	}
	
	

}
