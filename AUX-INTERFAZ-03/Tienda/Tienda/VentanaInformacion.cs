/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/20/2022
 * Time: 7:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tienda
{
	/// <summary>
	/// Description of VentanaInformacion.
	/// </summary>
	public partial class VentanaInformacion : Form
	{
		Tienda tienda;
		
		public VentanaInformacion()
		{
			InitializeComponent();
		}
		
		public VentanaInformacion(Tienda t)
		{
			InitializeComponent();
			tienda = t;
			mostrarDatos();
		}
		
		public void mostrarDatos(){
			textBoxGerente.Text = tienda.Ger.ToString();
			labelNroEmpleados.Text = "Numero de empleados: "+tienda.NroEmp.ToString();
			textBoxEmpleados.Text = tienda.getEmpleados();
			textBoxDireccion.Text = tienda.DireccionTienda;
			textBoxContacto.Text = tienda.ContactoTienda.ToString();
		}
	}
}
