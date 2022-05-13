
using System;

namespace clase
{
	/// <summary>
	/// Description of Evaluacion.
	/// </summary>
	public class Evaluacion
	{
		private int nota;
		
		public Evaluacion()
		{
			nota = 85;
		}
		
		public Evaluacion(int x){
			nota = x;
		}
		
		public void mostrar(){
			Console.WriteLine("nota: "+nota);
		}
		
		public void setNota(int x){ nota = x;}
		
		public int Nota {
			get { return nota; }
			set { nota = value; }
		}
	}
}
