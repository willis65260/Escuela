import pyodbc
from tkinter import *

direccion_servidor='DESKTOP-DNTT8D6/SQLEXPRESS'
nombre_bd='UAER_UNAM'
nombre_usuario='DESKTOP-DNTT8D6/Lalo'
contraseña=' '

try:
    conexion=pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+direccion_servidor+';DATABASE='+nombre_bd+';UID='+nombre_usuario+';PWD='+contraseña)
    
    

    root=Tk()
    def myClick():
        myLabel=Label(root, text="Look i clicked a Button!!")
        myLabel.pack();

    myButton = Button(root, text="Click Me!", command=myClick)
    myButton.pack()

    root.mainloop()
except Exception as e:
    print("Error garrafal: ",e)