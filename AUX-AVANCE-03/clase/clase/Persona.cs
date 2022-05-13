/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 5/12/2022
 * Time: 6:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		private string nombre;
		
		public Persona()
		{
			nombre = "rodrigo";
		}
		
		public Persona(string n){
			nombre = n;
		}
		
		public void mostrar(){
			Console.Write("nombre:" + nombre);
		}
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
	}
}
