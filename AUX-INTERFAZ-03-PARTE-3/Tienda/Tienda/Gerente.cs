/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/20/2022
 * Time: 3:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Tienda
{
	/// <summary>
	/// Description of Gerente.
	/// </summary>
	public class Gerente : Persona
	{
		private string direccion;
		
		
		
		public	Gerente(string nom,string pat, string mat, int c, string nac,string dir) :
				base(nom,pat,mat,c,nac)
		{
			direccion = dir;
		}
		
		public Gerente() : base(){
			direccion = "av. juan pablo II";
		}
		
		public override string ToString()
		{	
			string mostrar = string.Format("[Gerente Direccion={0} ", direccion);
			mostrar += base.ToString();
			return mostrar;
		}
		
		public string Direccion {
			get { return direccion; }
			set { direccion = value; }
		}	
		
		public void escritura(BinaryWriter escritor){
			base.escritura(escritor);
			escritor.Write(direccion);
		}
		
		public void lectura(BinaryReader lector){
			base.lectura(lector);
			direccion = lector.ReadString();
		}
	}
}
