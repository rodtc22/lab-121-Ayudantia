
using System;

namespace interfaz2
{
	public class Auto
	{
		private string color,placa,modelo;
		private int ci, nrocelular;
		private string fallo;
		private bool reparado;
		
		public Auto()
		{
			color = "azul";
			placa = "1234-ABC";
			modelo = "vagoneta";
			
			ci = 111111;
			nrocelular = 76543210;
			
			fallo = "fallo en el motor";
			reparado = false; //0:no esta reparado aun,   1:esta reparado
		}
		
		public string mostrar(){
			string s = "";
			s += "Color: "+color+"\n";
			s += "Placa: "+placa+"\n";
			s += "Modelo: "+modelo+"\n";
			s += "Carnet: "+ci+"\n";
			s += "NroCelular: "+nrocelular+"\n";
			s += "Fallo: "+fallo+"\n";
			s += "Estado: ";
			if(reparado == true){
				s += "Reparado"+"\n";
			}else{
				s += "No Reparado"+"\n";
			}
			return s;
		}
		
		public string mostrar2(){
			string s = "";
			s = color + " "+ placa + " "+modelo + " "+ci +" " + nrocelular + " "+ fallo + " "+reparado+"\n";
			return s;
		}
		
		public string Color {
			get { return color; }
			set { color = value; }
		}

		public string Placa {
			get { return placa; }
			set { placa = value; }
		}

		public string Modelo {
			get { return modelo; }
			set { modelo = value; }
		}

		public int Ci {
			get { return ci; }
			set { ci = value; }
		}

		public int Nrocelular {
			get { return nrocelular; }
			set { nrocelular = value; }
		}

		public string Fallo {
			get { return fallo; }
			set { fallo = value; }
		}

		public bool Reparado {
			get { return reparado; }
			set { reparado = value; }
		}
	}
}
