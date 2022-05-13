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
	public class SalonActo
	{
		private string nombre;
		private int nrocolaciones;
		private ColacionGrado [] c = new ColacionGrado[30];
		
		public SalonActo()
		{
			nombre = "atrio UMSA";
			nrocolaciones = 2;
			c[1] = new ColacionGrado();
			c[2] = new ColacionGrado();
		}
		
		public SalonActo(string nom, int nro){
			nombre = nom;
			nrocolaciones = nro;
			for(int i= 1 ;i <= nrocolaciones;i++){
				c[i] = new ColacionGrado("0"+i+"/01/2022");
			}
		}
		
		public void mostrar(){
			Console.WriteLine("*****************MOSTRANDO SALON DE ACTOS **************");
			Console.WriteLine("nombre: "+nombre+" nrocolaciones: "+nrocolaciones);
			for(int i= 1; i<=nrocolaciones ;i++){
				c[i].mostrar();
			}
		}
		
		public void adiGraduadoTitulo(int pos, Graduado g, TituloGrado t){
			c[pos].adiGraduado(g);
			c[pos].adiTituloGrado(t);
		}
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}

		public int Nrocolaciones {
			get { return nrocolaciones; }
			set { nrocolaciones = value; }
		}

		public ColacionGrado[] C {
			get { return c; }
			set { c = value; }
		}
		
		//-------------------------------------------------------------------
		
		public void muestraGraduadosPor(string x){
			for(int i = 1;i <= nrocolaciones ;i++){
				c[i].muestraGraduadosPor(x);
			}
		}
		
		public void mostrarK(int k){
			int nrograd = 0;
			Graduado [] ord = new Graduado[100];
			
			for(int i = 1 ;i<= nrocolaciones ;i++){
				//colaciones
				for(int j = 1; j <= c[i].Nrograduados ; j++){
					//graduado j, colacion i,
					nrograd++;
					ord[nrograd] = c[i].getGraduado(j);
				}
			}
			
			//ordenamos por burbuja
			for(int i = 1;i <= nrograd ;i++){
				for(int j = 1; j <= nrograd ;j++){
					if(ord[i].Eval.Nota > ord[j].Eval.Nota){
						Graduado tmp = ord[i];
						ord[i] = ord[j];
						ord[j] = tmp;
					}
				}
			}
			
			for(int i= 1;i <= k ;i++)
				ord[i].mostrar();
		}
		
		
		public void moverGraduado(string nom, string f){
			//1ro busco a cristian
			bool sw = true;
			
			Graduado g1 = new Graduado();
			TituloGrado t1 = new TituloGrado();
			for(int i =1 ;i <= nrocolaciones && sw;i++){
				int pos = c[i].buscarGraduado(nom);
				if(pos != -1){
					g1 = c[i].getGraduado(pos);
					t1 = c[i].getTitulo(pos);
					//lo elimino
					c[i].elimina(pos);
					sw = false;
				}
			}
			
			sw = true;
			//
			for(int i =1 ;i <= nrocolaciones && sw;i++){
				if(c[i].Fecha.Equals(f)){
					c[i].adiGraduado(g1);
					c[i].adiTituloGrado(t1);
					sw = false;
				}
			}
		}
	}
}
