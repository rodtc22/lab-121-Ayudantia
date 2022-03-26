/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 3/25/2022
 * Time: 6:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SOBRECARGA
{
	public class Pasteleria
	{
		private string nombre;
		private int telefono;
		
		private int nroProductos;
		private string [] productos = new string [50];
		private int [] costo = new int[50];
		
		private int nroRepartidores;
		private string [,] repartidor = new string[50,4];
		
		
		public Pasteleria()
		{
			nombre = "Michelline";
			telefono = 123456;
			nroRepartidores = 2;
			repartidor[1,1]="juan1"; repartidor[1,2]="1";repartidor[1,3]="15";
			repartidor[2,1]="juan2"; repartidor[2,2]="2";repartidor[2,3]="20";
			nroProductos = 1;
			productos[1] = "pastel"; costo[1] = 100;
		}
		
		public Pasteleria(string nom,int telf, int nropro, string [] prod, int [] cost){
			nombre = nom;
			telefono = telf;
			nroProductos = nropro;
			productos = prod;
			costo = cost;
			nroRepartidores = 0;
		}
		
		public void mostrar(){
			Console.WriteLine("\n===========PASTELERIA=========");
			Console.WriteLine("nombre:{0} telf:{1} \nnroProdutos:{2}",nombre,telefono,nroProductos);
			for(int i= 1 ;i<= nroProductos ;i++){
				Console.WriteLine("  nomProd:{0} costo:{1}",productos[i],costo[i]);
			}
			Console.WriteLine("nroRepartidores: {0}",nroRepartidores);
			for(int i= 1 ;i<=nroRepartidores ;i++){
				Console.WriteLine("  nomRep:{0} ciRep:{1} edadRep:{2}",repartidor[i,1],repartidor[i,2],repartidor[i,3]);
			}
		}
		
		
		public static Pasteleria operator ++ (Pasteleria p){
			Console.WriteLine("\nLeyendo pasteleria: ");
			Console.WriteLine("nombre, telf, nroProdutos");
			p.nombre = Console.ReadLine();
			p.telefono = int.Parse(Console.ReadLine());
			
			p.nroProductos = int.Parse(Console.ReadLine());
			for(int i= 1 ;i <= p.nroProductos ;i++){
				Console.WriteLine("nomProd,costProd");
				p.productos[i] = Console.ReadLine();
				p.costo[i] = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine("nroRepartidores: ");
			p.nroRepartidores = int.Parse(Console.ReadLine());
			for(int i = 1; i<= p.nroRepartidores ;i++){
				Console.WriteLine("nomRep,ciRep, edadRep: ");
				p.repartidor[i,1]  = Console.ReadLine();
				p.repartidor[i,2]  = Console.ReadLine();
				p.repartidor[i,3]  = Console.ReadLine();
			}
			
			return p;
		}
		
		
		public void mostrar(string x){
			Console.WriteLine("\nPasteleria: "+nombre);
			Console.WriteLine("Repartidores: ");
			for(int i= 1 ;i<=nroRepartidores ;i++){
				Console.WriteLine("  nomRep:{0} ciRep:{1} edadRep:{2}",repartidor[i,1],repartidor[i,2],repartidor[i,3]);
			}
		}
		
		public void mostrar(int x){
			Console.WriteLine("\n MOSTRAR REPARTIDORES");
			for(int i = 1; i<= nroRepartidores ;i++){
				int edad = int.Parse(repartidor[i,3]);
				if(edad >= x){
					Console.WriteLine("  nomRep:{0} ciRep:{1} edadRep:{2}",repartidor[i,1],repartidor[i,2],repartidor[i,3]);
				}
			}
		}
		
		public static Pasteleria operator + (Pasteleria p, Persona x){
			p.nroRepartidores++;
			p.repartidor[p.nroRepartidores,1] = x.getNombre();
			p.repartidor[p.nroRepartidores,2] = x.getCi().ToString();
			p.repartidor[p.nroRepartidores,3] = x.getEdad().ToString();
			return p;
		}
		
		public static bool operator true (Pasteleria p){
			return p.nroRepartidores > 0;
		}
		
		public static bool operator false (Pasteleria p){
			return p.nroRepartidores == 0;
		}
	}
}
