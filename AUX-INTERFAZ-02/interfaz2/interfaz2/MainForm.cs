using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace interfaz2
{
	
	public partial class MainForm : Form
	{
		int nroAutos = 0;
		Auto [] auto = new Auto [100];
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void ButtonGuardarClick(object sender, EventArgs e)
		{
			nroAutos++;
			auto[nroAutos] = new Auto();
			auto[nroAutos].Modelo = textBoxModelo.Text;
			auto[nroAutos].Ci = int.Parse(textBoxCarnet.Text);
			auto[nroAutos].Nrocelular= int.Parse(textBoxCelular.Text);
			auto[nroAutos].Color= textBoxColor.Text;
			auto[nroAutos].Fallo= textBoxFallo.Text;
			auto[nroAutos].Placa= textBoxPlaca.Text;
			auto[nroAutos].Reparado = false;
		}
		
		
		
		
		
		void ButtonLimpiarClick(object sender, EventArgs e)
		{
			textBoxModelo.Text = "";
			textBoxCarnet.Text = "";
			textBoxCelular.Text = "";
			textBoxColor.Text = "";
			textBoxFallo.Text = "";
			textBoxPlaca.Text = "";
		}
		
		void ButtonMostrarClick(object sender, EventArgs e)
		{
			groupBox1.Text = "LISTA DE AUTOS:\n";
			for(int i= 1;i <= nroAutos ;i++){
				groupBox1.Text += auto[i].mostrar2();
			}
		}
	}
}
