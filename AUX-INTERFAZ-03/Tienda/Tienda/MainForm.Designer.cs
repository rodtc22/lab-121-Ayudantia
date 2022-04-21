/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/20/2022
 * Time: 2:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tienda
{
	partial class VentanaInicio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInicio));
			this.panelArriba = new System.Windows.Forms.Panel();
			this.labelFecha = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel16 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.panel17 = new System.Windows.Forms.Panel();
			this.panel18 = new System.Windows.Forms.Panel();
			this.panel13 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.panel14 = new System.Windows.Forms.Panel();
			this.panel15 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.buttonAgregaEmpleados = new System.Windows.Forms.Button();
			this.panel11 = new System.Windows.Forms.Panel();
			this.panel12 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.buttonInformacion = new System.Windows.Forms.Button();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.buttonInicio = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.panelArriba.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel16.SuspendLayout();
			this.panel13.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelArriba
			// 
			this.panelArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
			this.panelArriba.Controls.Add(this.labelFecha);
			this.panelArriba.Controls.Add(this.label1);
			this.panelArriba.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelArriba.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelArriba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(189)))), ((int)(((byte)(165)))));
			this.panelArriba.Location = new System.Drawing.Point(0, 0);
			this.panelArriba.Name = "panelArriba";
			this.panelArriba.Size = new System.Drawing.Size(695, 73);
			this.panelArriba.TabIndex = 0;
			// 
			// labelFecha
			// 
			this.labelFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelFecha.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFecha.Location = new System.Drawing.Point(458, 15);
			this.labelFecha.Name = "labelFecha";
			this.labelFecha.Size = new System.Drawing.Size(225, 44);
			this.labelFecha.TabIndex = 1;
			this.labelFecha.Text = "Fecha:";
			this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(225, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bievenido Admin";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.panel2.Controls.Add(this.panel16);
			this.panel2.Controls.Add(this.panel13);
			this.panel2.Controls.Add(this.panel10);
			this.panel2.Controls.Add(this.panel7);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 73);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 421);
			this.panel2.TabIndex = 1;
			// 
			// panel16
			// 
			this.panel16.BackColor = System.Drawing.Color.Lime;
			this.panel16.Controls.Add(this.button4);
			this.panel16.Controls.Add(this.panel17);
			this.panel16.Controls.Add(this.panel18);
			this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel16.Location = new System.Drawing.Point(0, 233);
			this.panel16.Name = "panel16";
			this.panel16.Size = new System.Drawing.Size(200, 44);
			this.panel16.TabIndex = 5;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(189)))), ((int)(((byte)(165)))));
			this.button4.Location = new System.Drawing.Point(14, 0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(184, 44);
			this.button4.TabIndex = 2;
			this.button4.Text = "5";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// panel17
			// 
			this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel17.Location = new System.Drawing.Point(198, 0);
			this.panel17.Name = "panel17";
			this.panel17.Size = new System.Drawing.Size(2, 44);
			this.panel17.TabIndex = 1;
			// 
			// panel18
			// 
			this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel18.Location = new System.Drawing.Point(0, 0);
			this.panel18.Name = "panel18";
			this.panel18.Size = new System.Drawing.Size(14, 44);
			this.panel18.TabIndex = 0;
			// 
			// panel13
			// 
			this.panel13.BackColor = System.Drawing.Color.Lime;
			this.panel13.Controls.Add(this.button3);
			this.panel13.Controls.Add(this.panel14);
			this.panel13.Controls.Add(this.panel15);
			this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel13.Location = new System.Drawing.Point(0, 189);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(200, 44);
			this.panel13.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(189)))), ((int)(((byte)(165)))));
			this.button3.Location = new System.Drawing.Point(14, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(184, 44);
			this.button3.TabIndex = 2;
			this.button3.Text = "4";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// panel14
			// 
			this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel14.Location = new System.Drawing.Point(198, 0);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(2, 44);
			this.panel14.TabIndex = 1;
			// 
			// panel15
			// 
			this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel15.Location = new System.Drawing.Point(0, 0);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(14, 44);
			this.panel15.TabIndex = 0;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.Lime;
			this.panel10.Controls.Add(this.buttonAgregaEmpleados);
			this.panel10.Controls.Add(this.panel11);
			this.panel10.Controls.Add(this.panel12);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel10.Location = new System.Drawing.Point(0, 145);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(200, 44);
			this.panel10.TabIndex = 3;
			// 
			// buttonAgregaEmpleados
			// 
			this.buttonAgregaEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.buttonAgregaEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAgregaEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.buttonAgregaEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.buttonAgregaEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAgregaEmpleados.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAgregaEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(189)))), ((int)(((byte)(165)))));
			this.buttonAgregaEmpleados.Location = new System.Drawing.Point(14, 0);
			this.buttonAgregaEmpleados.Name = "buttonAgregaEmpleados";
			this.buttonAgregaEmpleados.Size = new System.Drawing.Size(184, 44);
			this.buttonAgregaEmpleados.TabIndex = 2;
			this.buttonAgregaEmpleados.Text = "Agrega Empleado";
			this.buttonAgregaEmpleados.UseVisualStyleBackColor = false;
			this.buttonAgregaEmpleados.Click += new System.EventHandler(this.ButtonAgregaEmpleadosClick);
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel11.Location = new System.Drawing.Point(198, 0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(2, 44);
			this.panel11.TabIndex = 1;
			// 
			// panel12
			// 
			this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel12.Location = new System.Drawing.Point(0, 0);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(14, 44);
			this.panel12.TabIndex = 0;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Lime;
			this.panel7.Controls.Add(this.buttonInformacion);
			this.panel7.Controls.Add(this.panel8);
			this.panel7.Controls.Add(this.panel9);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 101);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(200, 44);
			this.panel7.TabIndex = 2;
			// 
			// buttonInformacion
			// 
			this.buttonInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.buttonInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonInformacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.buttonInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.buttonInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonInformacion.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(189)))), ((int)(((byte)(165)))));
			this.buttonInformacion.Location = new System.Drawing.Point(14, 0);
			this.buttonInformacion.Name = "buttonInformacion";
			this.buttonInformacion.Size = new System.Drawing.Size(184, 44);
			this.buttonInformacion.TabIndex = 2;
			this.buttonInformacion.Text = "Informacion";
			this.buttonInformacion.UseVisualStyleBackColor = false;
			this.buttonInformacion.Click += new System.EventHandler(this.ButtonInformacionClick);
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel8.Location = new System.Drawing.Point(198, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(2, 44);
			this.panel8.TabIndex = 1;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(14, 44);
			this.panel9.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Lime;
			this.panel4.Controls.Add(this.buttonInicio);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 57);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(200, 44);
			this.panel4.TabIndex = 1;
			// 
			// buttonInicio
			// 
			this.buttonInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.buttonInicio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.buttonInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonInicio.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(189)))), ((int)(((byte)(165)))));
			this.buttonInicio.Location = new System.Drawing.Point(14, 0);
			this.buttonInicio.Name = "buttonInicio";
			this.buttonInicio.Size = new System.Drawing.Size(184, 44);
			this.buttonInicio.TabIndex = 2;
			this.buttonInicio.Text = "Inicio";
			this.buttonInicio.UseVisualStyleBackColor = false;
			this.buttonInicio.Click += new System.EventHandler(this.ButtonInicioClick);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel6.Location = new System.Drawing.Point(198, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(2, 44);
			this.panel6.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(14, 44);
			this.panel5.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 57);
			this.panel1.TabIndex = 0;
			// 
			// panelContenedor
			// 
			this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenedor.Location = new System.Drawing.Point(200, 73);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(495, 421);
			this.panelContenedor.TabIndex = 2;
			// 
			// VentanaInicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(695, 494);
			this.Controls.Add(this.panelContenedor);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panelArriba);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "VentanaInicio";
			this.Text = "Tienda";
			this.panelArriba.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel16.ResumeLayout(false);
			this.panel13.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button buttonInformacion;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Button buttonAgregaEmpleados;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel13;
		private System.Windows.Forms.Panel panel18;
		private System.Windows.Forms.Panel panel17;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel16;
		private System.Windows.Forms.Button buttonInicio;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label labelFecha;
		private System.Windows.Forms.Panel panelContenedor;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelArriba;
	}
}
