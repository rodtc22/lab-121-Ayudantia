/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/20/2022
 * Time: 7:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tienda
{
	/// <summary>
	/// Description of VentanaAgregar.
	/// </summary>
	public partial class VentanaAgregar : Form
	{
		
		Tienda tienda;
		public VentanaAgregar()
		{
			InitializeComponent();
		}
		
		public VentanaAgregar(Tienda t)
		{
			tienda = t;
			InitializeComponent();
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void ButtonAgregarClick(object sender, EventArgs e)
		{
//			string x = textBoxNombre.Text;		
//			int ci = int.Parse(textBoxCarnet.Text);
			//...
			Empleado emp = new Empleado();
			tienda.adiEmpleado(emp);
		}
	}
}
