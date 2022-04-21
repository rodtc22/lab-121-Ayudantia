/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/20/2022
 * Time: 2:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tienda
{
	/// <summary>
	/// Description of Tienda.
	/// </summary>
	public class Tienda
	{
		private Gerente ger;
		private static int nroEmp;
		private static Empleado [] emp = new Empleado[50];
		private string direccionTienda; //tambien puede tener correo, pagina de face, y otros
		private int contactoTienda;
		
		public Tienda()
		{
			ger = new Gerente("Rodrigo","Ticona","Coronel",12345,"06/09/1999","Victor Gutierrez");
			nroEmp = 1;
			emp[1] = new Empleado("carlos","ape","mate",11111,"10/10/2000",2500,666666,"19/04/2022");
			
			direccionTienda = "Prado";
			contactoTienda = 777777; 
		}
		
		public Tienda(Gerente g, string dir, int con){
			ger = g;
			nroEmp = 0;
			direccionTienda = dir;
			contactoTienda = con;
		}
		
		public override string ToString()
		{
			string mostrar = string.Format("[Tienda:\nGer={0}\n" +
			                     "NroEmp={1}\n " +
			                     "Empleados:\n ",
			                    ger, nroEmp, emp);
			for(int i= 1 ;i <=nroEmp ;i++){
				mostrar += emp[i];
				mostrar += "\n\r";
			}
			
			mostrar += string.Format("DireccionTienda={0}\n " +
			                     "ContactoTienda={1}\n]",
			                      direccionTienda, contactoTienda);
			return mostrar;
		}
		
		public string getEmpleados(){
			String mostrar = "";
			for(int i= 1 ;i <=nroEmp ;i++){
				mostrar += emp[i];
				mostrar += "\n\r";
			}
			return mostrar;
		}
 	
		
		public void adiEmpleado(Empleado e){
			nroEmp++;
			emp[nroEmp] = e;
		}
		
		public Gerente Ger {
			get { return ger; }
			set { ger = value; }
		}

		public int NroEmp {
			get { return nroEmp; }
			set { nroEmp = value; }
		}

		public Empleado[] Emp {
			get { return emp; }
			set { emp = value; }
		}

		public string DireccionTienda {
			get { return direccionTienda; }
			set { direccionTienda = value; }
		}

		public int ContactoTienda {
			get { return contactoTienda; }
			set { contactoTienda = value; }
		}
	}
}
