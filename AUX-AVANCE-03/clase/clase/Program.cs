/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 5/12/2022
 * Time: 6:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase
{
	class Program
	{
		public static void Main(string[] args)
		{	
			Graduado g1 = new Graduado();
			TituloGrado t1 =new TituloGrado();
			
			Graduado g2 = new Graduado("cristian","ingenieria","pregrado","examen de grado",100);
			TituloGrado t2 =new TituloGrado("licenciado inge", "cristian", "24/01/2022","rector");
			
			Graduado g3 = new Graduado("lourdes","auditoria","postgrado","tesis",95);
			TituloGrado t3 =new TituloGrado("licenciado autidoria","lourdes","14/02/2022","decano");
			
			
			// inciso A)
			Console.WriteLine("==================================INCISO A==================================");
			SalonActo s = new SalonActo("AtrioAzul", 3);
			s.adiGraduadoTitulo(1,g1,t1);
			s.adiGraduadoTitulo(2,g2,t2);
			s.adiGraduadoTitulo(2,g3,t3);
			s.mostrar();
			
			
			// inciso B)
			Console.WriteLine("==================================INCISO B==================================");
			string x = "tesis";
			s.muestraGraduadosPor(x);
			
			// inciso C)
			Console.WriteLine("==================================INCISO C==================================");
			int k = 1;
			s.mostrarK(k);
			
			//inciso D)
			Console.WriteLine("==================================INCISO D==================================");
			s.moverGraduado("cristian","03/01/2022");
			s.mostrar();
			Console.ReadKey(true);
		}
	}
}