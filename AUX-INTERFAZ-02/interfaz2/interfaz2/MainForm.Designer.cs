/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/16/2022
 * Time: 6:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace interfaz2
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonMostrar = new System.Windows.Forms.Button();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxCelular = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxCarnet = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxFallo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxPlaca = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxColor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxModelo = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Impact", 29F);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(136)))), ((int)(((byte)(186)))));
			this.label1.Location = new System.Drawing.Point(21, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 97);
			this.label1.TabIndex = 0;
			this.label1.Text = "TALLER MECANICO";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(242, -23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(259, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(501, 148);
			this.panel1.TabIndex = 14;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.buttonMostrar);
			this.panel2.Controls.Add(this.buttonLimpiar);
			this.panel2.Controls.Add(this.buttonGuardar);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.textBoxCelular);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.textBoxCarnet);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.textBoxFallo);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBoxPlaca);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.textBoxColor);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBoxModelo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 148);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(501, 487);
			this.panel2.TabIndex = 15;
			// 
			// buttonMostrar
			// 
			this.buttonMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMostrar.BackgroundImage")));
			this.buttonMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonMostrar.Location = new System.Drawing.Point(327, 6);
			this.buttonMostrar.Name = "buttonMostrar";
			this.buttonMostrar.Size = new System.Drawing.Size(50, 50);
			this.buttonMostrar.TabIndex = 29;
			this.buttonMostrar.UseVisualStyleBackColor = true;
			this.buttonMostrar.Click += new System.EventHandler(this.ButtonMostrarClick);
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.BackgroundImage")));
			this.buttonLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonLimpiar.Location = new System.Drawing.Point(383, 6);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(50, 50);
			this.buttonLimpiar.TabIndex = 28;
			this.buttonLimpiar.UseVisualStyleBackColor = true;
			this.buttonLimpiar.Click += new System.EventHandler(this.ButtonLimpiarClick);
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
			this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonGuardar.Location = new System.Drawing.Point(439, 6);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(50, 50);
			this.buttonGuardar.TabIndex = 27;
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardarClick);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
			this.panel3.Controls.Add(this.groupBox1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 264);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(501, 223);
			this.panel3.TabIndex = 26;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(202)))), ((int)(((byte)(208)))));
			this.groupBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(42, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(417, 186);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "SALIDA";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
			this.label6.Location = new System.Drawing.Point(286, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 25;
			this.label6.Text = "Celular";
			// 
			// textBoxCelular
			// 
			this.textBoxCelular.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCelular.Location = new System.Drawing.Point(286, 158);
			this.textBoxCelular.Name = "textBoxCelular";
			this.textBoxCelular.Size = new System.Drawing.Size(203, 31);
			this.textBoxCelular.TabIndex = 24;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
			this.label7.Location = new System.Drawing.Point(286, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 23;
			this.label7.Text = "Carnet";
			// 
			// textBoxCarnet
			// 
			this.textBoxCarnet.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCarnet.Location = new System.Drawing.Point(286, 98);
			this.textBoxCarnet.Name = "textBoxCarnet";
			this.textBoxCarnet.Size = new System.Drawing.Size(203, 31);
			this.textBoxCarnet.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
			this.label4.Location = new System.Drawing.Point(21, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 21;
			this.label4.Text = "Fallo";
			// 
			// textBoxFallo
			// 
			this.textBoxFallo.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxFallo.Location = new System.Drawing.Point(21, 218);
			this.textBoxFallo.Name = "textBoxFallo";
			this.textBoxFallo.Size = new System.Drawing.Size(468, 31);
			this.textBoxFallo.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
			this.label5.Location = new System.Drawing.Point(21, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 19;
			this.label5.Text = "Placa";
			// 
			// textBoxPlaca
			// 
			this.textBoxPlaca.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPlaca.Location = new System.Drawing.Point(21, 158);
			this.textBoxPlaca.Name = "textBoxPlaca";
			this.textBoxPlaca.Size = new System.Drawing.Size(203, 31);
			this.textBoxPlaca.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
			this.label3.Location = new System.Drawing.Point(21, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "Color";
			// 
			// textBoxColor
			// 
			this.textBoxColor.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxColor.Location = new System.Drawing.Point(21, 98);
			this.textBoxColor.Name = "textBoxColor";
			this.textBoxColor.Size = new System.Drawing.Size(203, 31);
			this.textBoxColor.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
			this.label2.Location = new System.Drawing.Point(21, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 15;
			this.label2.Text = "Modelo";
			// 
			// textBoxModelo
			// 
			this.textBoxModelo.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxModelo.Location = new System.Drawing.Point(21, 38);
			this.textBoxModelo.Name = "textBoxModelo";
			this.textBoxModelo.Size = new System.Drawing.Size(203, 31);
			this.textBoxModelo.TabIndex = 14;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(136)))), ((int)(((byte)(186)))));
			this.ClientSize = new System.Drawing.Size(501, 635);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Control de Vehiculos";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.Button buttonMostrar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxCarnet;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxCelular;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxPlaca;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxFallo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxColor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxModelo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
