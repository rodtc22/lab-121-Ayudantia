/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/20/2022
 * Time: 7:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tienda
{
	partial class VentanaInformacion
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonok = new System.Windows.Forms.Button();
			this.textBoxContacto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxDireccion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxEmpleados = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.labelNroEmpleados = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPaterno = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxMaterno = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxNacimiento = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxCarnet = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxDireccionGerente = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.panel1.Controls.Add(this.textBoxNacimiento);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.textBoxCarnet);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.textBoxDireccionGerente);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.textBoxMaterno);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.textBoxPaterno);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.textBoxNombre);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.buttonok);
			this.panel1.Controls.Add(this.textBoxContacto);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.textBoxDireccion);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBoxEmpleados);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.labelNroEmpleados);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold);
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(591, 503);
			this.panel1.TabIndex = 0;
			// 
			// buttonok
			// 
			this.buttonok.Location = new System.Drawing.Point(485, 457);
			this.buttonok.Name = "buttonok";
			this.buttonok.Size = new System.Drawing.Size(75, 32);
			this.buttonok.TabIndex = 10;
			this.buttonok.Text = "ok";
			this.buttonok.UseVisualStyleBackColor = true;
			this.buttonok.Click += new System.EventHandler(this.ButtonokClick);
			// 
			// textBoxContacto
			// 
			this.textBoxContacto.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxContacto.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxContacto.Location = new System.Drawing.Point(106, 461);
			this.textBoxContacto.Multiline = true;
			this.textBoxContacto.Name = "textBoxContacto";
			this.textBoxContacto.Size = new System.Drawing.Size(289, 33);
			this.textBoxContacto.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 472);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(144, 22);
			this.label6.TabIndex = 8;
			this.label6.Text = "Contacto:";
			// 
			// textBoxDireccion
			// 
			this.textBoxDireccion.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxDireccion.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxDireccion.Location = new System.Drawing.Point(106, 415);
			this.textBoxDireccion.Multiline = true;
			this.textBoxDireccion.Name = "textBoxDireccion";
			this.textBoxDireccion.Size = new System.Drawing.Size(289, 33);
			this.textBoxDireccion.TabIndex = 7;
			this.textBoxDireccion.TextChanged += new System.EventHandler(this.TextBoxDireccionTextChanged);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 426);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 22);
			this.label5.TabIndex = 6;
			this.label5.Text = "Direccion:";
			// 
			// textBoxEmpleados
			// 
			this.textBoxEmpleados.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxEmpleados.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxEmpleados.Location = new System.Drawing.Point(106, 268);
			this.textBoxEmpleados.Multiline = true;
			this.textBoxEmpleados.Name = "textBoxEmpleados";
			this.textBoxEmpleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxEmpleados.Size = new System.Drawing.Size(361, 134);
			this.textBoxEmpleados.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 271);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 34);
			this.label4.TabIndex = 4;
			this.label4.Text = "Empleados:";
			// 
			// labelNroEmpleados
			// 
			this.labelNroEmpleados.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNroEmpleados.Location = new System.Drawing.Point(3, 238);
			this.labelNroEmpleados.Name = "labelNroEmpleados";
			this.labelNroEmpleados.Size = new System.Drawing.Size(282, 27);
			this.labelNroEmpleados.TabIndex = 3;
			this.labelNroEmpleados.Text = "Numero de Empleados: ";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 34);
			this.label2.TabIndex = 1;
			this.label2.Text = "Gerente:";
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(591, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "INFORMACION";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxNombre.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombre.Location = new System.Drawing.Point(123, 76);
			this.textBoxNombre.Multiline = true;
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(175, 32);
			this.textBoxNombre.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(33, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 34);
			this.label3.TabIndex = 11;
			this.label3.Text = "Nombre";
			// 
			// textBoxPaterno
			// 
			this.textBoxPaterno.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxPaterno.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPaterno.Location = new System.Drawing.Point(123, 114);
			this.textBoxPaterno.Multiline = true;
			this.textBoxPaterno.Name = "textBoxPaterno";
			this.textBoxPaterno.Size = new System.Drawing.Size(175, 32);
			this.textBoxPaterno.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(33, 117);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 34);
			this.label7.TabIndex = 13;
			this.label7.Text = "Paterno";
			// 
			// textBoxMaterno
			// 
			this.textBoxMaterno.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxMaterno.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMaterno.Location = new System.Drawing.Point(123, 154);
			this.textBoxMaterno.Multiline = true;
			this.textBoxMaterno.Name = "textBoxMaterno";
			this.textBoxMaterno.Size = new System.Drawing.Size(175, 32);
			this.textBoxMaterno.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(33, 157);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(144, 34);
			this.label8.TabIndex = 15;
			this.label8.Text = "Materno";
			// 
			// textBoxNacimiento
			// 
			this.textBoxNacimiento.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxNacimiento.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNacimiento.Location = new System.Drawing.Point(404, 154);
			this.textBoxNacimiento.Multiline = true;
			this.textBoxNacimiento.Name = "textBoxNacimiento";
			this.textBoxNacimiento.Size = new System.Drawing.Size(175, 32);
			this.textBoxNacimiento.TabIndex = 22;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(304, 154);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(144, 34);
			this.label9.TabIndex = 21;
			this.label9.Text = "Nacimiento";
			// 
			// textBoxCarnet
			// 
			this.textBoxCarnet.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxCarnet.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCarnet.Location = new System.Drawing.Point(404, 114);
			this.textBoxCarnet.Multiline = true;
			this.textBoxCarnet.Name = "textBoxCarnet";
			this.textBoxCarnet.Size = new System.Drawing.Size(175, 32);
			this.textBoxCarnet.TabIndex = 20;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(337, 114);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(144, 34);
			this.label10.TabIndex = 19;
			this.label10.Text = "Carnet";
			// 
			// textBoxDireccionGerente
			// 
			this.textBoxDireccionGerente.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxDireccionGerente.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxDireccionGerente.Location = new System.Drawing.Point(404, 76);
			this.textBoxDireccionGerente.Multiline = true;
			this.textBoxDireccionGerente.Name = "textBoxDireccionGerente";
			this.textBoxDireccionGerente.Size = new System.Drawing.Size(175, 32);
			this.textBoxDireccionGerente.TabIndex = 18;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(323, 77);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(144, 34);
			this.label11.TabIndex = 17;
			this.label11.Text = "Direccion";
			// 
			// VentanaInformacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 503);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaInformacion";
			this.Text = "VentanaInformacion";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxDireccionGerente;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxCarnet;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxNacimiento;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxPaterno;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxMaterno;
		private System.Windows.Forms.Button buttonok;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelNroEmpleados;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxEmpleados;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxDireccion;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxContacto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
