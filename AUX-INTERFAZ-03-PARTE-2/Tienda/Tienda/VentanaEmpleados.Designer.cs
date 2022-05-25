/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 5/25/2022
 * Time: 10:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tienda
{
	partial class VentanaEmpleados
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEmpleados));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonEliminar = new System.Windows.Forms.Button();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.buttonEditar = new System.Windows.Forms.Button();
			this.panelContenido = new System.Windows.Forms.Panel();
			this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labelNroEmpleados = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panelContenido.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(130)))), ((int)(((byte)(46)))));
			this.panel1.Controls.Add(this.buttonEliminar);
			this.panel1.Controls.Add(this.buttonGuardar);
			this.panel1.Controls.Add(this.buttonEditar);
			this.panel1.Controls.Add(this.panelContenido);
			this.panel1.Controls.Add(this.labelNroEmpleados);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold);
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(678, 533);
			this.panel1.TabIndex = 1;
			// 
			// buttonEliminar
			// 
			this.buttonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.BackgroundImage")));
			this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEliminar.Location = new System.Drawing.Point(12, 8);
			this.buttonEliminar.Name = "buttonEliminar";
			this.buttonEliminar.Size = new System.Drawing.Size(35, 35);
			this.buttonEliminar.TabIndex = 7;
			this.buttonEliminar.UseVisualStyleBackColor = true;
			this.buttonEliminar.Click += new System.EventHandler(this.ButtonEliminarClick);
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
			this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGuardar.Location = new System.Drawing.Point(633, 55);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(35, 35);
			this.buttonGuardar.TabIndex = 6;
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardarClick);
			// 
			// buttonEditar
			// 
			this.buttonEditar.BackColor = System.Drawing.Color.Red;
			this.buttonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditar.BackgroundImage")));
			this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditar.Location = new System.Drawing.Point(592, 55);
			this.buttonEditar.Name = "buttonEditar";
			this.buttonEditar.Size = new System.Drawing.Size(35, 35);
			this.buttonEditar.TabIndex = 5;
			this.buttonEditar.UseVisualStyleBackColor = false;
			this.buttonEditar.Click += new System.EventHandler(this.ButtonEditarClick);
			// 
			// panelContenido
			// 
			this.panelContenido.Controls.Add(this.dataGridViewEmpleados);
			this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenido.Font = new System.Drawing.Font("Ink Free", 12.25F, System.Drawing.FontStyle.Bold);
			this.panelContenido.Location = new System.Drawing.Point(0, 96);
			this.panelContenido.Name = "panelContenido";
			this.panelContenido.Size = new System.Drawing.Size(678, 437);
			this.panelContenido.TabIndex = 4;
			// 
			// dataGridViewEmpleados
			// 
			this.dataGridViewEmpleados.AllowUserToAddRows = false;
			this.dataGridViewEmpleados.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.SandyBrown;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
			this.dataGridViewEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Nombre,
									this.Paterno,
									this.Materno,
									this.Carnet,
									this.Sueldo,
									this.Celular,
									this.Nacimiento,
									this.Contrato});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Ink Free", 12.25F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(63)))), ((int)(((byte)(26)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewEmpleados.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
			this.dataGridViewEmpleados.ReadOnly = true;
			this.dataGridViewEmpleados.Size = new System.Drawing.Size(678, 437);
			this.dataGridViewEmpleados.TabIndex = 0;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 97;
			// 
			// Paterno
			// 
			this.Paterno.HeaderText = "Paterno";
			this.Paterno.Name = "Paterno";
			this.Paterno.ReadOnly = true;
			this.Paterno.Width = 98;
			// 
			// Materno
			// 
			this.Materno.HeaderText = "Materno";
			this.Materno.Name = "Materno";
			this.Materno.ReadOnly = true;
			this.Materno.Width = 103;
			// 
			// Carnet
			// 
			this.Carnet.HeaderText = "Carnet";
			this.Carnet.Name = "Carnet";
			this.Carnet.ReadOnly = true;
			this.Carnet.Width = 90;
			// 
			// Sueldo
			// 
			this.Sueldo.HeaderText = "Sueldo";
			this.Sueldo.Name = "Sueldo";
			this.Sueldo.ReadOnly = true;
			this.Sueldo.Width = 84;
			// 
			// Celular
			// 
			this.Celular.HeaderText = "Celular";
			this.Celular.Name = "Celular";
			this.Celular.ReadOnly = true;
			this.Celular.Width = 89;
			// 
			// Nacimiento
			// 
			this.Nacimiento.HeaderText = "Nacimiento";
			this.Nacimiento.Name = "Nacimiento";
			this.Nacimiento.ReadOnly = true;
			this.Nacimiento.Width = 124;
			// 
			// Contrato
			// 
			this.Contrato.HeaderText = "Contrato";
			this.Contrato.Name = "Contrato";
			this.Contrato.ReadOnly = true;
			this.Contrato.Width = 106;
			// 
			// labelNroEmpleados
			// 
			this.labelNroEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelNroEmpleados.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNroEmpleados.Location = new System.Drawing.Point(0, 50);
			this.labelNroEmpleados.Name = "labelNroEmpleados";
			this.labelNroEmpleados.Size = new System.Drawing.Size(678, 46);
			this.labelNroEmpleados.TabIndex = 3;
			this.labelNroEmpleados.Text = "Numero de Empleados: ";
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(678, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "LISTA DE EMPLEADOS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// VentanaEmpleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 533);
			this.Controls.Add(this.panel1);
			this.Name = "VentanaEmpleados";
			this.Text = "VentanaEmpleados";
			this.panel1.ResumeLayout(false);
			this.panelContenido.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonEditar;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Button buttonEliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Contrato;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
		private System.Windows.Forms.DataGridViewTextBoxColumn Materno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridView dataGridViewEmpleados;
		private System.Windows.Forms.Panel panelContenido;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelNroEmpleados;
		private System.Windows.Forms.Panel panel1;
	}
}
