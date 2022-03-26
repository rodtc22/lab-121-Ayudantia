/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 3/25/2022
 * Time: 6:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SOBRECARGA
{
	
	public class Persona
	{
		private string nombre;
		private int ci,edad;
		
		public Persona()
		{
			nombre = "rodrigo";
			ci = 123;
			edad = 100;
		}
		
		public Persona(string nom, int c, int e){
			nombre = nom;
			ci = c;
			edad = e;
		}
		
		public Persona(string nom, int e){
			nombre = nom;
			ci = -1;
			edad = e;
		}
		
		public void mostrar(){
			Console.WriteLine("Persona=[nombre:{0} ci:{1} edad:{2}]",nombre,ci,edad);
		}
		
		public static Persona operator ++ (Persona p){
			Console.WriteLine("Persona=[nombre:{0} ci:{1} edad:{2}]",p.nombre,p.ci,p.edad);
			return p;
		}
		
		public void modificarCi (int newci){
			ci = newci;
		}
		
//		public void modificarCi (int newci, string fant) {
//			ci = newci;
//		}
		
		public void modificarCi (){
			Console.Write("intro ci: ");
			ci = int.Parse(Console.ReadLine());
		}
		
		public string getNombre() {return nombre;}
		public int getCi() {return ci;}
		public int getEdad() {return edad;}
	}
}
