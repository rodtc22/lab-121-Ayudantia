/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/20/2022
 * Time: 2:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tienda
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class VentanaInicio : Form
	{
		ArchivoTienda arch;
		
		public VentanaInicio()
		{
			InitializeComponent();
			labelFecha.Text = "Fecha: " + DateTime.Now.ToString();
			arch = new ArchivoTienda("maxitienda.txt");
		}
			
		
		void ButtonInicioClick(object sender, EventArgs e)
		{
			VentanaInicial inic = new VentanaInicial(arch);
			inic.FormBorderStyle = FormBorderStyle.None;
			inic.AutoScroll = true;
			inic.TopLevel = false;
			inic.Dock = DockStyle.Fill;
			
			panelContenedor.Controls.Clear();
			panelContenedor.Controls.Add(inic);
			inic.Show();
		}
		
		void ButtonInformacionClick(object sender, EventArgs e)
		{
				
			VentanaInformacion inic = new VentanaInformacion(arch);
			inic.FormBorderStyle = FormBorderStyle.None;
			inic.AutoScroll = true;
			inic.TopLevel = false;
			inic.Dock = DockStyle.Fill;
			
			panelContenedor.Controls.Clear();
			panelContenedor.Controls.Add(inic);
			inic.Show();		
		}
		
		void ButtonAgregaEmpleadosClick(object sender, EventArgs e)
		{
			VentanaAgregar inic = new VentanaAgregar(arch);
			inic.FormBorderStyle = FormBorderStyle.None;
			inic.AutoScroll = true;
			inic.TopLevel = false;
			inic.Dock = DockStyle.Fill;
			
			panelContenedor.Controls.Clear();
			panelContenedor.Controls.Add(inic);
			inic.Show();
		}
		
		void ButtonEmpleadosClick(object sender, EventArgs e)
		{
			VentanaEmpleados inic = new VentanaEmpleados(arch);
			inic.FormBorderStyle = FormBorderStyle.None;
			inic.AutoScroll = true;
			inic.TopLevel = false;
			inic.Dock = DockStyle.Fill;
			
			panelContenedor.Controls.Clear();
			panelContenedor.Controls.Add(inic);
			inic.Show();	
		}
	}
}
