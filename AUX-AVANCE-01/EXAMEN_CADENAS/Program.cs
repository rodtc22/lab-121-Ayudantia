using System;

namespace EXAMEN_CADENAS
{
	class Program
	{
		public static void Main(string[] args)
		{
			//===============creando los arrays===============
			string [,] p = new string[2,4];
			string [,] a = new string[5,4];
			
			//===============leyendo los arrays===============
//			Console.WriteLine("Ingresa matriz P: ");
//			for(int i = 0 ;i < 2 ;i++){
//				for (int j = 0; j < 4; j++) {
//					p[i,j] = Console.ReadLine();
//				}
//			}
			
//			Console.WriteLine("Ingresa matriz A: ");
//			for(int i = 0 ;i < 5 ;i++){
//				for (int j = 0; j < 4; j++) {
//					a[i,j] = Console.ReadLine();
//				}
//			}
			
			//===============INCISO A===============
//			Determinar la cantidad de hijos y el monto promedio
//			de asistencia por cada hijo de la pareja x e y
			
//			string x,y;
//			x = Console.ReadLine();
//			y = Console.ReadLine();
//			
//			//buscando la columna en la que esta la pareja
//			for(int j = 0 ;j < 4; j++){
//				string f = p[0,j]; //father
//				string m = p[1,j]; //mother
//				
//				if((f.Equals(x) && m.Equals(y)) || (m.Equals(x) && f.Equals(y))){
//					string hijos = a[0,j];
//					int monto = int.Parse(a[1,j]);
//					
//					//obteniendo nro de hijos
//					int nrohijos = 0;
//					for(int i = 0 ;i < hijos.Length ;i++){
//						char c = hijos[i];
//						if(c == ','){
//							nrohijos++;
//						}
//					}
//					if(hijos.Length > 0){
//						nrohijos++;
//					}
//					
//					//monto promedio
//					double montoprom = monto/nrohijos;
//					Console.WriteLine(nrohijos+" , "+montoprom);
//					
//				}
//			}
			
			//===============INCISO B===============
			//ordenar por nombre de madre
//			for(int i= 0 ;i < 4 ; i++){
//				for(int j= 0 ;j < 4 ;j++){
//					string m1 = p[1,i];
//					string m2 = p[1,j];
//					if(m1.CompareTo(m2)<0){
//						string aux = p[1,i];
//						p[1,i] = p[1,j];
//						p[1,j] = aux;
//						
//						aux = p[0,i];
//						p[0,i] = p[0,j];
//						p[0,j] = aux;
//					}
//				}
//			}
//
//			Console.WriteLine("Mostrar matriz: ");
//			for(int i= 0 ;i < 2 ;i++){
//				for(int j= 0 ;j < 4 ;j++){
//					Console.Write(p[i,j]+" ");
//				}
//				Console.WriteLine();
//			}
//			
//			Console.ReadKey(true);
		}
	}
}



