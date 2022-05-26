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
		
		public VentanaInformacion(ArchivoTienda a)
		{
			InitializeComponent();
			arch = a;
			mostrarDatos();
		}
		
		public void mostrarDatos(){
			Tienda tienda = arch.getTienda();
			
			//esta parte cambia//
			textBoxNombre.Text = tienda.Ger.Nombre;
			textBoxPaterno.Text = tienda.Ger.Paterno;
			textBoxMaterno.Text = tienda.Ger.Materno;
			textBoxCarnet.Text = tienda.Ger.Ci.ToString();
			textBoxDireccionGerente.Text = tienda.Ger.Direccion;
			textBoxNacimiento.Text = tienda.Ger.Fechanac;
					
			//
			
			labelNroEmpleados.Text = "Numero de empleados: "+tienda.NroEmp.ToString();
			textBoxEmpleados.Text = tienda.getEmpleados();
			textBoxDireccion.Text = tienda.DireccionTienda;
			textBoxContacto.Text = tienda.ContactoTienda.ToString();
		}
		
		void TextBoxDireccionTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ButtonokClick(object sender, EventArgs e)
		{
			Tienda tienda = arch.getTienda();
			tienda.Ger.Nombre = textBoxNombre.Text;
			tienda.Ger.Paterno = textBoxPaterno.Text ;
			tienda.Ger.Materno = textBoxMaterno.Text ;
			tienda.Ger.Ci = int.Parse(textBoxCarnet.Text);
			tienda.Ger.Direccion = textBoxDireccionGerente.Text;
			tienda.Ger.Fechanac = textBoxNacimiento.Text ;
			tienda.DireccionTienda = textBoxDireccion.Text;
			tienda.ContactoTienda = int.Parse(textBoxContacto.Text);
			
			arch.modificar(tienda);
		}
	}
}
