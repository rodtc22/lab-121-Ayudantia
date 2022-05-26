
using System;
using System.IO;


namespace Tienda
{

	public class ArchivoTienda
	{
		private string ruta;
		
		public ArchivoTienda(string r)
		{
			ruta = r;
		}
		
		public void crear(){
			File.Delete(ruta);
			adiTienda(new Tienda());
		}
		
		public void adiTienda(Tienda t){
			Stream arch = File.Open(ruta,FileMode.Append);
			BinaryWriter escritor = new BinaryWriter(arch);
			
			try{
				t.escritura(escritor);
			}catch(Exception){
			}finally{
				arch.Close();
			}
		}
		
		public Tienda getTienda(){
			Stream arch = File.Open(ruta,FileMode.OpenOrCreate);
			BinaryReader lector = new BinaryReader(arch);
				
			Tienda t = new Tienda();
			try{
				t.lectura(lector);
			}catch(Exception){
			}finally{
				arch.Close();
			}
			return t;
		}
		
		public void modificar(Tienda t){
			File.Delete(ruta);
			adiTienda(t);
//			Stream arch = File.Open(ruta,FileMode.OpenOrCreate);
//			BinaryReader lector = new BinaryReader(arch);
//			
//			Stream nuevo = File.Open("nuevo.txt", FileMode.Append);
//			BinaryWriter escritor = new BinaryWriter(nuevo);
//			
//			try{
//				t.escritura(escritor);					
//			}catch(Exception){}
//			finally{
//				arch.Close();
//				nuevo.Close();	
//				File.Replace("nuevo.txt",ruta,ruta+".back");
//			}
		}
		
		public string Ruta {
			get { return ruta; }
			set { ruta = value; }
		}
	}
}
