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
	/// Description of ColacionGrado.
	/// </summary>
	public class ColacionGrado
	{
		private string fecha;
		private int nrograduados;
		private Graduado [] g = new Graduado[30];
		private TituloGrado [] t = new TituloGrado [30];
		
		public ColacionGrado()
		{
			fecha = "01/01/2022";
			nrograduados = 0;
		}
		
		public ColacionGrado(string fe)
		{
			fecha = fe;
			nrograduados = 0;
		}
		
		public void mostrar(){
			Console.WriteLine("----MOSTRANDO COLACION DE GRADO----");
			Console.WriteLine("fecha: "+fecha+" nrograduados: "+nrograduados);
			for(int i = 1;i <=nrograduados ;i++){
				g[i].mostrar();
				t[i].mostrar();
			}
		}
		
		public void adiGraduado(Graduado g1){
			nrograduados++;
			g[nrograduados] = g1; 
		}
		
		public void adiTituloGrado(TituloGrado t1){
			t[nrograduados] = t1;
		}
		
		public string Fecha {
			get { return fecha; }
			set { fecha = value; }
		}

		public int Nrograduados {
			get { return nrograduados; }
			set { nrograduados = value; }
		}

		public Graduado[] G {
			get { return g; }
			set { g = value; }
		}

		public TituloGrado[] T {
			get { return t; }
			set { t = value; }
		}
		
		//------------------------------------------------------
		public void muestraGraduadosPor(string x){
			for(int i = 1;i <= nrograduados ;i++){
				if(g[i].Modalidad.Equals(x)){
					g[i].mostrar();
					
				}
			}
		}
		
		public Graduado getGraduado(int pos){
			return g[pos];
		}
		
		public TituloGrado getTitulo(int pos){
			return t[pos];
		}
		
		public int buscarGraduado(string x){
			for(int i = 1;i <= nrograduados ;i++){
				if(g[i].Nombre.Equals(x)){
					return i;
				}
			}
			return -1;
		}
		
		public void elimina(int pos){
			for(int i = pos ;i < nrograduados ;i++){
				g[i] = g[i+1];
				t[i] = t[i+1];
			}
			nrograduados--;
		}
	}
}
