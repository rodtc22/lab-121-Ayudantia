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
			this.textBoxContacto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxDireccion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxEmpleados = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.labelNroEmpleados = new System.Windows.Forms.Label();
			this.textBoxGerente = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.panel1.Controls.Add(this.textBoxContacto);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.textBoxDireccion);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBoxEmpleados);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.labelNroEmpleados);
			this.panel1.Controls.Add(this.textBoxGerente);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold);
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(536, 440);
			this.panel1.TabIndex = 0;
			// 
			// textBoxContacto
			// 
			this.textBoxContacto.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxContacto.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxContacto.Location = new System.Drawing.Point(116, 379);
			this.textBoxContacto.Multiline = true;
			this.textBoxContacto.Name = "textBoxContacto";
			this.textBoxContacto.Size = new System.Drawing.Size(278, 33);
			this.textBoxContacto.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 379);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(144, 22);
			this.label6.TabIndex = 8;
			this.label6.Text = "Contacto:";
			// 
			// textBoxDireccion
			// 
			this.textBoxDireccion.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxDireccion.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxDireccion.Location = new System.Drawing.Point(116, 340);
			this.textBoxDireccion.Multiline = true;
			this.textBoxDireccion.Name = "textBoxDireccion";
			this.textBoxDireccion.Size = new System.Drawing.Size(361, 33);
			this.textBoxDireccion.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 340);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 22);
			this.label5.TabIndex = 6;
			this.label5.Text = "Direccion:";
			// 
			// textBoxEmpleados
			// 
			this.textBoxEmpleados.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxEmpleados.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxEmpleados.Location = new System.Drawing.Point(116, 194);
			this.textBoxEmpleados.Multiline = true;
			this.textBoxEmpleados.Name = "textBoxEmpleados";
			this.textBoxEmpleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxEmpleados.Size = new System.Drawing.Size(361, 134);
			this.textBoxEmpleados.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 194);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 34);
			this.label4.TabIndex = 4;
			this.label4.Text = "Empleados:";
			// 
			// labelNroEmpleados
			// 
			this.labelNroEmpleados.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNroEmpleados.Location = new System.Drawing.Point(12, 164);
			this.labelNroEmpleados.Name = "labelNroEmpleados";
			this.labelNroEmpleados.Size = new System.Drawing.Size(282, 27);
			this.labelNroEmpleados.TabIndex = 3;
			this.labelNroEmpleados.Text = "Numero de Empleados: ";
			// 
			// textBoxGerente
			// 
			this.textBoxGerente.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxGerente.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxGerente.Location = new System.Drawing.Point(116, 50);
			this.textBoxGerente.Multiline = true;
			this.textBoxGerente.Name = "textBoxGerente";
			this.textBoxGerente.Size = new System.Drawing.Size(361, 100);
			this.textBoxGerente.TabIndex = 2;
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
			this.label1.Size = new System.Drawing.Size(536, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "INFORMACION";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// VentanaInformacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 440);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaInformacion";
			this.Text = "VentanaInformacion";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxGerente;
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
