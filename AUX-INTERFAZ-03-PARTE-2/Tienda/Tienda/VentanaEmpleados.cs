/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 5/25/2022
 * Time: 10:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tienda
{
	/// <summary>
	/// Description of VentanaEmpleados.
	/// </summary>
	public partial class VentanaEmpleados : Form
	{
		Tienda tienda;
		public VentanaEmpleados()
		{
			InitializeComponent();
		}
		
		public VentanaEmpleados(Tienda t)
		{
			InitializeComponent();
			tienda = t;
			mostrarDatos();
		}
		
		public void mostrarDatos(){
			labelNroEmpleados.Text = "Numero de empleados: " + tienda.NroEmp;
			
			string [] fila = new string [8];
			
			for(int i = 1; i <= tienda.NroEmp; i++){
				fila[0] = tienda.Emp[i].Nombre;
				fila[1] = tienda.Emp[i].Paterno;
				fila[2] = tienda.Emp[i].Materno;
				fila[3] = tienda.Emp[i].Ci.ToString();
				fila[4] = tienda.Emp[i].Sueldo.ToString();
				fila[5] = tienda.Emp[i].Nrocelular.ToString();
				fila[6] = tienda.Emp[i].Fechanac;
				fila[7] = tienda.Emp[i].FechaContrato;
			
				dataGridViewEmpleados.Rows.Add(fila);
			}
		}
		

		
		void ButtonEditarClick(object sender, EventArgs e)
		{
			if(buttonEditar.BackColor == Color.Red){ //antes no se podia editar
				buttonEditar.BackColor = Color.Green;
				dataGridViewEmpleados.ReadOnly = false;
			}else{
				buttonEditar.BackColor = Color.Red;
				dataGridViewEmpleados.ReadOnly = true;
			}
		}
		
		void ButtonGuardarClick(object sender, EventArgs e)
		{
			moverDeDataGridViewATienda();
		}
		
		void moverDeDataGridViewATienda(){
			int n = tienda.NroEmp;
			tienda.NroEmp = 0; //Eliminando a todos los empleados
			
			
			for(int i = 0 ;i < n; i++){
				Empleado emp = new Empleado();
				emp.Nombre 			= dataGridViewEmpleados.Rows[i].Cells[0].Value.ToString();
				emp.Paterno 		= dataGridViewEmpleados.Rows[i].Cells[1].Value.ToString();
				emp.Materno 		= dataGridViewEmpleados.Rows[i].Cells[2].Value.ToString();
				emp.Ci 				= int.Parse(dataGridViewEmpleados.Rows[i].Cells[3].Value.ToString());
				emp.Sueldo 			= double.Parse(dataGridViewEmpleados.Rows[i].Cells[4].Value.ToString());
				emp.Nrocelular 		= int.Parse(dataGridViewEmpleados.Rows[i].Cells[5].Value.ToString());
				emp.Fechanac 		= dataGridViewEmpleados.Rows[i].Cells[6].Value.ToString();
				emp.FechaContrato 	= dataGridViewEmpleados.Rows[i].Cells[7].Value.ToString();
				
				tienda.adiEmpleado(emp);
			}
		}
		
		void ButtonEliminarClick(object sender, EventArgs e)
		{
			if(tienda.NroEmp > 0){
				dataGridViewEmpleados.Rows.Remove(dataGridViewEmpleados.CurrentRow);
				tienda.NroEmp--;
				labelNroEmpleados.Text = "Numero de empleados: "+tienda.NroEmp;
				moverDeDataGridViewATienda();
			}
		}
	}
}
