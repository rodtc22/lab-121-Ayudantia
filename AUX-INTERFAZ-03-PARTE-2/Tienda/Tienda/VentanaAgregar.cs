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
			Empleado emp = new Empleado();
			
			int mal = esvalido();
			
			if(mal == 1){
				MessageBox.Show("El nombre, no cumple con el formato","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			if(mal == 2){
				MessageBox.Show("El apellido paterno, no cumple con el formato","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			if(mal == 3){
				MessageBox.Show("El apellido materno, no cumple con el formato","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			if(mal == 5){
				MessageBox.Show("El carnet, no cumple con el formato","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			if(mal == 4){
				MessageBox.Show("El sueldo, no cumple con el formato","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			if(mal == 6){
				MessageBox.Show("El celular, no cumple con el formato","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
			if(mal == 0){ //es todo ok
				emp.Nombre = textBoxNombre.Text;
				emp.Paterno = textBoxPaterno.Text;
				emp.Materno = textBoxMaterno.Text;
				emp.Sueldo = double.Parse(textBoxSueldo.Text);
				emp.Ci = int.Parse(textBoxCarnet.Text);
				emp.Nrocelular = int.Parse(textBoxCelular.Text);
				
				
				
//				emp.Fechanac = textBoxFechaNacimiento.Text;
//				emp.FechaContrato = textBoxFechaContrato.Text;
				string fn = monthCalendarFechaNacimiento.SelectionRange.Start.Day+"/"+monthCalendarFechaNacimiento.SelectionRange.Start.Month+"/"+monthCalendarFechaNacimiento.SelectionRange.Start.Year;
				string fc = monthCalendarFechaContrato.SelectionRange.Start.Day+"/"+monthCalendarFechaContrato.SelectionRange.Start.Month+"/"+monthCalendarFechaContrato.SelectionRange.Start.Year;
				
				emp.Fechanac = fn;
				emp.FechaContrato = fc;
				tienda.adiEmpleado(emp);
				
				limpiarTextBox();
			}
		}
		
		bool espalabra(string s){
			bool sw = true;
			if(s.Length == 0){
				sw = false;
			}
			for(int i = 0 ;i < s.Length ; i++){
				if(!char.IsLetter(s[i])){
					sw = false;
				}
			}
			return sw;
		}
		
		bool esnumero(string s){
			bool sw = true;
			if(s.Length == 0){
				sw = false;
			}
			for(int i = 0 ;i < s.Length ; i++){
				if(!char.IsDigit(s[i])){ //0-9
					sw = false;
				}
			}
			return sw;
		}
		
		int esvalido(){
			string a = textBoxNombre.Text;
			string b = textBoxPaterno.Text;
			string c = textBoxMaterno.Text;
			string x = (textBoxSueldo.Text);
			string y = (textBoxCarnet.Text);
			string z = (textBoxCelular.Text);
			
			if(!espalabra(a)){
			   return 1;	
			}
			if(!espalabra(b)){
			   return 2;	
			}
			if(!espalabra(c)){
			   return 3;	
			}
			if(!esnumero(x)){
			   return 4;	
			}
			if(!esnumero(y)){
			   return 5;	
			}
			if(!esnumero(z)){
			   return 6;	
			}
			
			return 0; // me indica que todo esta bien
		}
		
		void limpiarTextBox(){
			textBoxNombre.Text = "";
			textBoxPaterno.Text = "";
			textBoxMaterno.Text = "";
			(textBoxSueldo.Text) = "";
			(textBoxCarnet.Text) = "";
			(textBoxCelular.Text) = "";
			
			
		}
	}
}
