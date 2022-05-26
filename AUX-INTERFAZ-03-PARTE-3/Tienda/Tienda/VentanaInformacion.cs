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
		ArchivoTienda arch;
		
		public VentanaInformacion()
		{
			InitializeComponent();
		}
		
		public VentanaInformacion(ArchivoTienda t)
		{
			InitializeComponent();
			arch = t;
			mostrarDatos();
		}
		
		public void mostrarDatos(){
			
			Tienda tienda = arch.dameTienda();
			
			textBoxNombreGerente.Text = tienda.Ger.Nombre;
			textBoxPaternoGerente.Text = tienda.Ger.Paterno;
			textBoxMaternoGerente.Text = tienda.Ger.Materno;
			textBoxCarnetGerente.Text = tienda.Ger.Ci.ToString();
			textBoxDireccionGerente.Text = tienda.Ger.Direccion;
			textBoxNacimientoGerente.Text = tienda.Ger.Fechanac;
			
			labelNroEmpleados.Text = "Numero de empleados: "+tienda.NroEmp.ToString();
			textBoxEmpleados.Text = tienda.getEmpleados();
			textBoxDireccion.Text = tienda.DireccionTienda;
			textBoxContacto.Text = tienda.ContactoTienda.ToString();
		}
		
		void ButtonokClick(object sender, EventArgs e)
		{
			Tienda tienda = arch.dameTienda();
			
			tienda.Ger.Nombre = textBoxNombreGerente.Text;
			tienda.Ger.Paterno = textBoxPaternoGerente.Text;
			tienda.Ger.Materno = textBoxMaternoGerente.Text;
			tienda.Ger.Ci = int.Parse(textBoxCarnetGerente.Text);
			tienda.Ger.Direccion = textBoxDireccionGerente.Text;
			tienda.Ger.Fechanac = textBoxNacimientoGerente.Text;
			tienda.DireccionTienda = textBoxDireccion.Text;
			tienda.ContactoTienda = int.Parse(textBoxContacto.Text);
			
			arch.modificarTienda(tienda);
			MessageBox.Show("Modificacion exitosa");

		}
	}
}
