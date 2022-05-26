/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/20/2022
 * Time: 2:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;


namespace Tienda
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado : Persona
	{
		private double sueldo;
		private int nrocelular;
		private string fechaContrato;
		
		
		
		public	Empleado(string nom,string pat, string mat, int c, string nac,double sue, int cel, string con):
				base(nom,pat,mat,c,nac)
		{
			sueldo = sue;
			nrocelular = cel;
			fechaContrato = con;
		}
		
		public	Empleado() : base(){
			sueldo = nrocelular = -1;
			fechaContrato = "00/00/0001";
		}
		
		public override string ToString()
		{
			string mostrar = string.Format("[Empleado Sueldo={0}, Nrocelular={1}, FechaContrato={2} ", sueldo, nrocelular, fechaContrato);
			mostrar += base.ToString();
			return mostrar;
		}
		
		
		public double Sueldo {
			get { return sueldo; }
			set { sueldo = value; }
		}

		public int Nrocelular {
			get { return nrocelular; }
			set { nrocelular = value; }
		}

		public string FechaContrato {
			get { return fechaContrato; }
			set { fechaContrato = value; }
		}
 
		
		public void escritura(BinaryWriter escritor){
			base.escritura(escritor);
			escritor.Write(sueldo);
			escritor.Write(nrocelular);
			escritor.Write(fechaContrato);
		}
		
		public void lectura(BinaryReader lector){
			base.lectura(lector);
			sueldo = lector.ReadDouble();
			nrocelular = lector.ReadInt32();
			fechaContrato = lector.ReadString();
		}
	}
}
