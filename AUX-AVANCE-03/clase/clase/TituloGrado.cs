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
	/// Description of TituloGrado.
	/// </summary>
	public class TituloGrado
	{
		private string titulo;
		private string nombreGraduado;
		private string fecha;
		private string autoridadfirmante;
		
		public TituloGrado()
		{
			titulo = "licenciado en info";
			nombreGraduado = "rodrigo";
			fecha = "25/12/2021";
			autoridadfirmante = "rector";
		}
		
		public TituloGrado(string ti, string nom, string fe, string au){
			titulo = ti;
			nombreGraduado =nom;
			fecha = fe;
			autoridadfirmante = au;
		}
		
		public void mostrar(){
			Console.WriteLine("MOSTRANDO TITULO DE GRADO");
			Console.WriteLine("titulo: "+titulo+" nombreGraduado: "+nombreGraduado+" fecha: "+fecha+" autoridadfirmante: "+autoridadfirmante);
		}
		
		public string Titulo {
			get { return titulo; }
			set { titulo = value; }
		}

		public string NombreGraduado {
			get { return nombreGraduado; }
			set { nombreGraduado = value; }
		}

		public string Fecha {
			get { return fecha; }
			set { fecha = value; }
		}

		public string Autoridadfirmante {
			get { return autoridadfirmante; }
			set { autoridadfirmante = value; }
		}
	}
}
