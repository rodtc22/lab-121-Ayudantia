/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/20/2022
 * Time: 7:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tienda
{
	partial class VentanaAgregar
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
			this.monthCalendarFechaContrato = new System.Windows.Forms.MonthCalendar();
			this.monthCalendarFechaNacimiento = new System.Windows.Forms.MonthCalendar();
			this.buttonAgregar = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxCelular = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxSueldo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxCarnet = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxMaterno = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPaterno = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.panel1.Controls.Add(this.monthCalendarFechaContrato);
			this.panel1.Controls.Add(this.monthCalendarFechaNacimiento);
			this.panel1.Controls.Add(this.buttonAgregar);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.textBoxCelular);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.textBoxSueldo);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBoxCarnet);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBoxMaterno);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBoxPaterno);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBoxNombre);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold);
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(578, 455);
			this.panel1.TabIndex = 1;
			// 
			// monthCalendarFechaContrato
			// 
			this.monthCalendarFechaContrato.Location = new System.Drawing.Point(311, 275);
			this.monthCalendarFechaContrato.Name = "monthCalendarFechaContrato";
			this.monthCalendarFechaContrato.TabIndex = 28;
			// 
			// monthCalendarFechaNacimiento
			// 
			this.monthCalendarFechaNacimiento.Location = new System.Drawing.Point(311, 76);
			this.monthCalendarFechaNacimiento.Name = "monthCalendarFechaNacimiento";
			this.monthCalendarFechaNacimiento.TabIndex = 27;
			// 
			// buttonAgregar
			// 
			this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAgregar.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold);
			this.buttonAgregar.ForeColor = System.Drawing.Color.Black;
			this.buttonAgregar.Location = new System.Drawing.Point(436, 9);
			this.buttonAgregar.Name = "buttonAgregar";
			this.buttonAgregar.Size = new System.Drawing.Size(97, 32);
			this.buttonAgregar.TabIndex = 26;
			this.buttonAgregar.Text = "Agregar";
			this.buttonAgregar.UseVisualStyleBackColor = false;
			this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregarClick);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(311, 247);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(155, 30);
			this.label9.TabIndex = 24;
			this.label9.Text = "Fecha Contrato";
			// 
			// textBoxCelular
			// 
			this.textBoxCelular.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxCelular.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCelular.Location = new System.Drawing.Point(12, 387);
			this.textBoxCelular.Multiline = true;
			this.textBoxCelular.Name = "textBoxCelular";
			this.textBoxCelular.Size = new System.Drawing.Size(237, 33);
			this.textBoxCelular.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 362);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(144, 22);
			this.label8.TabIndex = 22;
			this.label8.Text = "Celular:";
			// 
			// textBoxSueldo
			// 
			this.textBoxSueldo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxSueldo.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSueldo.Location = new System.Drawing.Point(12, 323);
			this.textBoxSueldo.Multiline = true;
			this.textBoxSueldo.Name = "textBoxSueldo";
			this.textBoxSueldo.Size = new System.Drawing.Size(237, 33);
			this.textBoxSueldo.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 298);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 22);
			this.label7.TabIndex = 20;
			this.label7.Text = "Sueldo:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(311, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(178, 33);
			this.label5.TabIndex = 18;
			this.label5.Text = "Fecha Nacimiento";
			// 
			// textBoxCarnet
			// 
			this.textBoxCarnet.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxCarnet.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCarnet.Location = new System.Drawing.Point(12, 262);
			this.textBoxCarnet.Multiline = true;
			this.textBoxCarnet.Name = "textBoxCarnet";
			this.textBoxCarnet.Size = new System.Drawing.Size(237, 33);
			this.textBoxCarnet.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 237);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 22);
			this.label4.TabIndex = 16;
			this.label4.Text = "Carnet:";
			// 
			// textBoxMaterno
			// 
			this.textBoxMaterno.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxMaterno.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMaterno.Location = new System.Drawing.Point(12, 198);
			this.textBoxMaterno.Multiline = true;
			this.textBoxMaterno.Name = "textBoxMaterno";
			this.textBoxMaterno.Size = new System.Drawing.Size(237, 33);
			this.textBoxMaterno.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 22);
			this.label3.TabIndex = 14;
			this.label3.Text = "Materno:";
			// 
			// textBoxPaterno
			// 
			this.textBoxPaterno.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxPaterno.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPaterno.Location = new System.Drawing.Point(12, 137);
			this.textBoxPaterno.Multiline = true;
			this.textBoxPaterno.Name = "textBoxPaterno";
			this.textBoxPaterno.Size = new System.Drawing.Size(237, 33);
			this.textBoxPaterno.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 22);
			this.label2.TabIndex = 12;
			this.label2.Text = "Paterno:";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxNombre.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombre.Location = new System.Drawing.Point(12, 76);
			this.textBoxNombre.Multiline = true;
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(237, 33);
			this.textBoxNombre.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(144, 22);
			this.label6.TabIndex = 10;
			this.label6.Text = "Nombre:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(41, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(322, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "AGREGAR EMPLEADO";
			// 
			// VentanaAgregar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 455);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaAgregar";
			this.Text = "VentanaAgregar";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.MonthCalendar monthCalendarFechaNacimiento;
		private System.Windows.Forms.MonthCalendar monthCalendarFechaContrato;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCarnet;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxSueldo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxCelular;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button buttonAgregar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPaterno;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxMaterno;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
