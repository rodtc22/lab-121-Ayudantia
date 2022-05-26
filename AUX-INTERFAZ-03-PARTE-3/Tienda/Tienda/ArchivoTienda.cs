/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 5/26/2022
 * Time: 10:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;


namespace Tienda
{

	public class ArchivoTienda
	{
		string ruta;
		
		public ArchivoTienda(string r)
		{
			ruta = r;
		}
		
		public void crear(){
			if(File.Exists(ruta)){
				File.Delete(ruta);
			}
		}
		
		public  void adiTienda(Tienda t){
			Stream arch = File.Open(ruta,FileMode.Append);
			BinaryWriter escritor = new BinaryWriter(arch);
			
			try {
				t.escritura(escritor);
			} catch (Exception) {}
			finally{
				arch.Close();
			}
		}
		
		public Tienda dameTienda(){
			Stream arch = File.Open(ruta,FileMode.OpenOrCreate);
			BinaryReader lector= new BinaryReader(arch);
			
			Tienda t = new Tienda();
			try {
				t.lectura(lector);
			} catch (Exception) {}
			finally{
				arch.Close();
			}
			return t;
		}
		
		public void modificarTienda(Tienda t){
			crear();
			adiTienda(t);
//			string ruta2 = "temporal.txt";
//			Stream arch2 = File.Open(ruta2,FileMode.Append);
//			BinaryWriter escritor = new BinaryWriter(arch2);
//			
//			Stream arch = File.Open(ruta,FileMode.OpenOrCreate);
//			BinaryReader lector= new BinaryReader(arch);
//			
//			Tienda t2 = new Tienda();
//			bool sw =true;
//			try {
//				while(true){
//					t2.lectura(lector);
//					if(sw){
//						t2 = t;
//						sw = false;
//					}
//					t2.escritura(escritor);
//				}
//			} catch (Exception) {
//			} finally {
//				arch.Close();
//				arch2.Close();
//				File.Copy(ruta2,ruta,true);
//				File.Delete(ruta2);
//			}
		}
		
		public void adicionaEmpleado(Empleado emp){
			string ruta2 = "temporal.txt";
			Stream arch2 = File.Open(ruta2,FileMode.Append);
			BinaryWriter escritor = new BinaryWriter(arch2);
			
			Stream arch = File.Open(ruta,FileMode.OpenOrCreate);
			BinaryReader lector= new BinaryReader(arch);
			
			Tienda t2 = new Tienda();
			bool sw =true;
			try {
				while(true){
					t2.lectura(lector);
					if(sw){
						t2.adiEmpleado(emp);
						sw = false;
					}
					t2.escritura(escritor);
				}
			} catch (Exception) {
			} finally {
				arch.Close();
				arch2.Close();
				File.Copy(ruta2,ruta,true);
				File.Delete(ruta2);
			}
		}
		
		public string Ruta {
			get { return ruta; }
		}
	}
}
