/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 25/02/2022
 * Time: 19:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace INTERFAZ1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			labelPantalla.Text = labelPantalla.Text + "1";
		}
		
		void Button0Click(object sender, EventArgs e)
		{
			labelPantalla.Text = labelPantalla.Text + "0";
		}
		
		void ButtonLimpiarClick(object sender, EventArgs e)
		{
			labelPantalla.Text = "";
		}
		
		void ButtonAtrasClick(object sender, EventArgs e)
		{
			labelPantalla.Text = eliminaUltimo(labelPantalla.Text);
		}
		
		string eliminaUltimo(string s){
			string t= "";
			for(int i=  0 ;i < s.Length-1 ;i++)
				t = t + s[i];
			return t;
		}
	}
}
