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
	/// <summary>
	/// Description of Graduado.
	/// </summary>
	public class Graduado : Persona
	{
		private string carrera;
		private string nivel;
		private string modalidad;
		private Evaluacion eval;
		
		public Graduado() : base()
		{
			carrera = "informatica";
			nivel = "pregrado";
			modalidad = "tesis";
			eval = new Evaluacion();
		}
		
		public Graduado(string nom,string car, string niv, string mod,int not) : base(nom){
			carrera = car;
			nivel = niv;
			modalidad = mod;
			eval = new Evaluacion(not);
		}
		
		public void mostrar(){
			Console.WriteLine("MOSTRANDO GRADUADO");
			base.mostrar();
			Console.Write(" Carrera: "+carrera+" nivel: "+nivel+" modalidad: "+modalidad+" ");
			eval.mostrar();
		}
		
		public string Carrera {
			get { return carrera; }
			set { carrera = value; }
		}

		public string Nivel {
			get { return nivel; }
			set { nivel = value; }
		}

		public string Modalidad {
			get { return modalidad; }
			set { modalidad = value; }
		}

		public Evaluacion Eval {
			get { return eval; }
			set { eval = value; }
		}
	}
}
