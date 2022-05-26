﻿/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/20/2022
 * Time: 7:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

using System.Drawing;
using System.Windows.Forms;

namespace Tienda
{
	/// <summary>
	/// Description of VentanaInicial.
	/// </summary>
	public partial class VentanaInicial : Form
	{
		ArchivoTienda arch;
		
		public VentanaInicial()
		{
			InitializeComponent();
		}
		
		public VentanaInicial(ArchivoTienda a)
		{
			InitializeComponent();
			arch = a;
		}
		
		void ButtonCrearTiendaClick(object sender, EventArgs e)
		{
			if(File.Exists(arch.Ruta)){
				if(MessageBox.Show(
					"Esta seguro de crear una nueva tienda, eliminando la tienda anterior?",
					"Alerta",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Exclamation) == DialogResult.OK
				){
					arch.crear();
					
				}
			}else{
				MessageBox.Show("Creado con exito","Agregado",MessageBoxButtons.OK,MessageBoxIcon.Information);
				arch.crear();
			}
		}
	}
}
