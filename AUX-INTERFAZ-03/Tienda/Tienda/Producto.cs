/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/20/2022
 * Time: 3:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tienda
{
	/// <summary>
	/// Description of Producto.
	/// </summary>
	public class Producto
	{
		private string nombre;
		private double costo;
		
		public Producto(string nom,double cos)
		{
			nombre = nom;
			costo = cos;
		}
		
		public Producto(){
			nombre = "Laptop-hp";
			costo = 5555.80;
		}
		
		public override string ToString()
		{
			return string.Format("[Producto Nombre={0}, Costo={1}]", nombre, costo);
		}
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}

		public double Costo {
			get { return costo; }
			set { costo = value; }
		}
	}
}
