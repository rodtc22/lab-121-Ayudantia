/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 3/25/2022
 * Time: 6:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
		/*
		 Unarios : ++,--,true,false
		 Binarios: +,-,*,/,%, ==, !=
		 LOS OPERADORES SIEMPRE RETORNAN ALGO
		*/
using System;

namespace SOBRECARGA
{
	class Program
	{
		public static void Main(string[] args)
		{
//			a)
			Pasteleria pas1 = new Pasteleria();
			
			int nro = 3;
			string [] prod = 	{"","pizza","cafe","maruchan"};
			int [] cost = 		{0,75,10,6};
			Pasteleria pas2 = new Pasteleria("abc",500500,nro,prod,cost);
			
//			b)
			Persona pe1 = new Persona();
			Persona pe2 = new Persona("carlos",456,20);
			Persona pe3 = new Persona("mario",5);
			
//			c) Sobrecargar el operador ++ para leer una pasteleria
			pas1++;
			
//			d) Sobrecargar el metodo mostrar() de la pasteleria de 3 formas distintas	
			pas1.mostrar();
			pas1.mostrar(""); //nomPasteleria + repartidores
			int x = 18;
			pas1.mostrar(x); //quienes son los repartidores con una edad de almenos X
			
			
//			e) sobrecarga el operador ++ para mostrar una Persona
			pe1++;
			
//			f) Sobrecarga una funcion de 2 formas para poder modificar el ci de una persona
			pe1.modificarCi(1);
			pe1.modificarCi();
			
//			g)  Sobrecarga un operador y haz otra funcion, para añadir una Persona p 
//			como repartidor a una pasteleria
			pas1 = pas1 + pe2;
			
//			h) Sobrecarga el operador True para verificar si una pasteleria tiene servicio de delivery
			
			if(pas2){
				Console.WriteLine("Si, tiene delivery");
			}else{
				Console.WriteLine("No tiene delivery");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}