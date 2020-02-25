package Analizador;

import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.net.URL;
import javax.swing.*;
import javax.swing.filechooser.FileNameExtensionFilter;
import java.awt.*;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
public class AnalizadorFinal {

	private JFrame frame;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AnalizadorFinal window = new AnalizadorFinal();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public AnalizadorFinal() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	
	File aux;
	JEditorPane editorPane;
	
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 620, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		//JEditorPane 
		 editorPane = new JEditorPane();
		 JScrollPane sp1 = new JScrollPane( editorPane,JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
		 JLabel lblnombrearchivo = new JLabel("        New labelhkbkvkvvhvhvhvhvkhvkhvhkvh");
	      frame.getContentPane().add(sp1, BorderLayout.CENTER);
		JToolBar Menu = new JToolBar();
		frame.getContentPane().add(Menu, BorderLayout.NORTH);
		URL ruta;
		JButton btnAbrir = new JButton();
		btnAbrir.setVerticalAlignment(SwingConstants.TOP);
		btnAbrir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				JFileChooser fileChooser = new JFileChooser();
				FileNameExtensionFilter filter = new FileNameExtensionFilter("solo txt y doc", "txt", "doc");
				fileChooser.setFileFilter(filter);
				int seleccion = fileChooser.showOpenDialog(editorPane);
				if (seleccion == JFileChooser.APPROVE_OPTION)
				{
				   File fichero = fileChooser.getSelectedFile();
				   aux=fichero;
				   // Aquí es para abrir y leer el fichero.
				   try
	                {
	                    String nombre = fichero.getName();
	                    String path = fichero.getAbsolutePath();
	                    String contenido = getArchivo( path );
	                    
	                    //nombre del archivo en laetiqueta de nombre que esta en el jmenu
	                    lblnombrearchivo.setText("                "+ nombre );
	 
	                    //En el editorpane  colocamos su contenido
	                    editorPane.setText( contenido );
	 
	                }catch( Exception exp){}
				}
				
			}
		});
		Menu.add(btnAbrir);
		 ruta = getClass().getResource("/Analizador/img/abrir.png");
	      btnAbrir.setIcon(new ImageIcon(ruta));
		JButton btnCerrar = new JButton();
		btnCerrar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				//Quito el nombre del archivo
				lblnombrearchivo.setText("");
				//dejo en blanco el editorpane
				 editorPane.setText("");
				 aux=null;
			}
		});
		
		
		btnCerrar.setVerticalAlignment(SwingConstants.TOP);
		Menu.add(btnCerrar);
		 ruta = getClass().getResource("/Analizador/img/cerrar.png");
	      btnCerrar.setIcon(new ImageIcon(ruta));
	      
	      
		JButton btnGuardar = new JButton();
		btnGuardar.setVerticalAlignment(SwingConstants.TOP);
		Menu.add(btnGuardar);
		 ruta = getClass().getResource("/Analizador/img/guardar.png");
	      btnGuardar.setIcon(new ImageIcon(ruta));
		btnGuardar.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				guardarArchivo();
			}
		});
	      
	      
		JButton btnAnalizar = new JButton();
		btnAnalizar.setVerticalAlignment(SwingConstants.TOP);
		Menu.add(btnAnalizar);
		 ruta = getClass().getResource("/Analizador/img/analizar.png");
	      btnAnalizar.setIcon(new ImageIcon(ruta));
	      
	      
	      Menu.add(lblnombrearchivo);
	      
	     
	}

	//Leer el archivo mamalon
	public String getArchivo( String ruta ){
        FileReader fr = null;
        BufferedReader br = null;
        //Cadena de texto donde se guardara el contenido del archivo
        String contenido = "";
        try
        {
            //ruta puede ser de tipo String o tipo File
            fr = new FileReader( ruta );
            br = new BufferedReader( fr );
 
            String linea;
            //Obtenemos el contenido del archivo linea por linea
            while( ( linea = br.readLine() ) != null ){ 
                contenido += linea + "\n";
            }
 
        }catch( Exception e ){  }
        //finally se utiliza para que si todo ocurre correctamente o si ocurre 
        //algun error se cierre el archivo que anteriormente abrimos
        finally
        {
            try{
                br.close();
            }catch( Exception ex ){}
        }
        return contenido;
    }
	
	public void guardarArchivoComo(){
		if(aux!=null) {
			try {
				FileWriter fichero=new FileWriter(aux);
				PrintWriter pw= new PrintWriter(fichero);
				editorPane.getText();
				pw.print(editorPane.getText());
				pw.close();
			} catch (FileNotFoundException e) {
				e.printStackTrace();
			}catch (IOException err) {
				err.printStackTrace();
			}
			
		}
		
	}
	public void guardarArchivo() {
		JFileChooser fileChooser = new JFileChooser();
//		FileNameExtensionFilter filter = new FileNameExtensionFilter("solo txt y doc", "txt", "doc");
//		fileChooser.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
		int seleccion = fileChooser.showOpenDialog(editorPane);
		if (seleccion == JFileChooser.APPROVE_OPTION)
		{
			if(aux!=null) {
				try {
					File archivo= new File(fileChooser.getSelectedFile()+".txt");
					FileWriter fichero=new FileWriter(archivo);
					PrintWriter pw= new PrintWriter(fichero);
					editorPane.getText();
					pw.print(editorPane.getText());
					pw.close();
					
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				}catch (IOException err) {
					err.printStackTrace();
				}
				
			}
		}
	}
}
