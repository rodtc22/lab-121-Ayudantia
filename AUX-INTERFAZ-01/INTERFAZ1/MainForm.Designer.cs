/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 25/02/2022
 * Time: 19:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace INTERFAZ1
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelPantalla = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonDivision = new System.Windows.Forms.Button();
			this.buttonMultiplicacion = new System.Windows.Forms.Button();
			this.buttonResta = new System.Windows.Forms.Button();
			this.buttonSuma = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.buttonIgual = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.buttonAtras = new System.Windows.Forms.Button();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.panel1.Controls.Add(this.labelPantalla);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(395, 98);
			this.panel1.TabIndex = 0;
			// 
			// labelPantalla
			// 
			this.labelPantalla.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPantalla.Location = new System.Drawing.Point(0, 0);
			this.labelPantalla.Name = "labelPantalla";
			this.labelPantalla.Size = new System.Drawing.Size(395, 98);
			this.labelPantalla.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.panel2.Controls.Add(this.buttonDivision);
			this.panel2.Controls.Add(this.buttonMultiplicacion);
			this.panel2.Controls.Add(this.buttonResta);
			this.panel2.Controls.Add(this.buttonSuma);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 98);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(395, 85);
			this.panel2.TabIndex = 1;
			// 
			// buttonDivision
			// 
			this.buttonDivision.BackColor = System.Drawing.Color.Transparent;
			this.buttonDivision.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.buttonDivision.FlatAppearance.BorderSize = 0;
			this.buttonDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
			this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDivision.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDivision.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonDivision.Location = new System.Drawing.Point(297, 1);
			this.buttonDivision.Name = "buttonDivision";
			this.buttonDivision.Size = new System.Drawing.Size(93, 81);
			this.buttonDivision.TabIndex = 12;
			this.buttonDivision.Text = "/";
			this.buttonDivision.UseVisualStyleBackColor = false;
			// 
			// buttonMultiplicacion
			// 
			this.buttonMultiplicacion.BackColor = System.Drawing.Color.Transparent;
			this.buttonMultiplicacion.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.buttonMultiplicacion.FlatAppearance.BorderSize = 0;
			this.buttonMultiplicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
			this.buttonMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMultiplicacion.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMultiplicacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonMultiplicacion.Location = new System.Drawing.Point(198, 1);
			this.buttonMultiplicacion.Name = "buttonMultiplicacion";
			this.buttonMultiplicacion.Size = new System.Drawing.Size(93, 81);
			this.buttonMultiplicacion.TabIndex = 11;
			this.buttonMultiplicacion.Text = "x";
			this.buttonMultiplicacion.UseVisualStyleBackColor = false;
			// 
			// buttonResta
			// 
			this.buttonResta.BackColor = System.Drawing.Color.Transparent;
			this.buttonResta.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.buttonResta.FlatAppearance.BorderSize = 0;
			this.buttonResta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
			this.buttonResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonResta.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonResta.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonResta.Location = new System.Drawing.Point(99, 1);
			this.buttonResta.Name = "buttonResta";
			this.buttonResta.Size = new System.Drawing.Size(93, 81);
			this.buttonResta.TabIndex = 10;
			this.buttonResta.Text = "-";
			this.buttonResta.UseVisualStyleBackColor = false;
			// 
			// buttonSuma
			// 
			this.buttonSuma.BackColor = System.Drawing.Color.Transparent;
			this.buttonSuma.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.buttonSuma.FlatAppearance.BorderSize = 0;
			this.buttonSuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
			this.buttonSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSuma.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSuma.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonSuma.Location = new System.Drawing.Point(0, 1);
			this.buttonSuma.Name = "buttonSuma";
			this.buttonSuma.Size = new System.Drawing.Size(93, 81);
			this.buttonSuma.TabIndex = 9;
			this.buttonSuma.Text = "+";
			this.buttonSuma.UseVisualStyleBackColor = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.HotPink;
			this.panel3.Controls.Add(this.buttonIgual);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(292, 183);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(103, 332);
			this.panel3.TabIndex = 2;
			// 
			// buttonIgual
			// 
			this.buttonIgual.BackColor = System.Drawing.Color.Transparent;
			this.buttonIgual.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.buttonIgual.FlatAppearance.BorderSize = 0;
			this.buttonIgual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.buttonIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonIgual.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonIgual.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonIgual.Location = new System.Drawing.Point(6, 6);
			this.buttonIgual.Name = "buttonIgual";
			this.buttonIgual.Size = new System.Drawing.Size(93, 321);
			this.buttonIgual.TabIndex = 13;
			this.buttonIgual.Text = "=";
			this.buttonIgual.UseVisualStyleBackColor = false;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel4.Controls.Add(this.buttonAtras);
			this.panel4.Controls.Add(this.buttonLimpiar);
			this.panel4.Controls.Add(this.button3);
			this.panel4.Controls.Add(this.button0);
			this.panel4.Controls.Add(this.button2);
			this.panel4.Controls.Add(this.button1);
			this.panel4.Controls.Add(this.button6);
			this.panel4.Controls.Add(this.button5);
			this.panel4.Controls.Add(this.button4);
			this.panel4.Controls.Add(this.button9);
			this.panel4.Controls.Add(this.button8);
			this.panel4.Controls.Add(this.button7);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 183);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(292, 332);
			this.panel4.TabIndex = 3;
			// 
			// buttonAtras
			// 
			this.buttonAtras.BackColor = System.Drawing.Color.MidnightBlue;
			this.buttonAtras.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.buttonAtras.FlatAppearance.BorderSize = 0;
			this.buttonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAtras.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAtras.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonAtras.Location = new System.Drawing.Point(3, 249);
			this.buttonAtras.Name = "buttonAtras";
			this.buttonAtras.Size = new System.Drawing.Size(93, 81);
			this.buttonAtras.TabIndex = 10;
			this.buttonAtras.Text = "DEL";
			this.buttonAtras.UseVisualStyleBackColor = false;
			this.buttonAtras.Click += new System.EventHandler(this.ButtonAtrasClick);
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.BackColor = System.Drawing.Color.MidnightBlue;
			this.buttonLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.buttonLimpiar.FlatAppearance.BorderSize = 0;
			this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLimpiar.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonLimpiar.Location = new System.Drawing.Point(197, 249);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(93, 81);
			this.buttonLimpiar.TabIndex = 9;
			this.buttonLimpiar.Text = "CE";
			this.buttonLimpiar.UseVisualStyleBackColor = false;
			this.buttonLimpiar.Click += new System.EventHandler(this.ButtonLimpiarClick);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.MidnightBlue;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button3.Location = new System.Drawing.Point(198, 177);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(93, 81);
			this.button3.TabIndex = 8;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button0
			// 
			this.button0.BackColor = System.Drawing.Color.MidnightBlue;
			this.button0.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.button0.FlatAppearance.BorderSize = 0;
			this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button0.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button0.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button0.Location = new System.Drawing.Point(99, 249);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(93, 81);
			this.button0.TabIndex = 5;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = false;
			this.button0.Click += new System.EventHandler(this.Button0Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.MidnightBlue;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.Location = new System.Drawing.Point(99, 174);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 81);
			this.button2.TabIndex = 7;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.MidnightBlue;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new System.Drawing.Point(0, 174);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 81);
			this.button1.TabIndex = 6;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.MidnightBlue;
			this.button6.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button6.Location = new System.Drawing.Point(198, 90);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(93, 81);
			this.button6.TabIndex = 5;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.MidnightBlue;
			this.button5.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button5.Location = new System.Drawing.Point(99, 87);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(93, 81);
			this.button5.TabIndex = 4;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.MidnightBlue;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button4.Location = new System.Drawing.Point(0, 87);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(93, 81);
			this.button4.TabIndex = 3;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.MidnightBlue;
			this.button9.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button9.Location = new System.Drawing.Point(198, 3);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(93, 81);
			this.button9.TabIndex = 2;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = false;
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.MidnightBlue;
			this.button8.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button8.Location = new System.Drawing.Point(99, 0);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(93, 81);
			this.button8.TabIndex = 1;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = false;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.MidnightBlue;
			this.button7.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button7.Location = new System.Drawing.Point(0, 0);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(93, 81);
			this.button7.TabIndex = 0;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 515);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "CALCULADORA";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonAtras;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.Label labelPantalla;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button buttonIgual;
		private System.Windows.Forms.Button buttonSuma;
		private System.Windows.Forms.Button buttonResta;
		private System.Windows.Forms.Button buttonMultiplicacion;
		private System.Windows.Forms.Button buttonDivision;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
	}
}
