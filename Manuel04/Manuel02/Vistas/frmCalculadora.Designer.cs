using System;

namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnCero;
            System.Windows.Forms.Button btn1;
            System.Windows.Forms.Button btn4;
            System.Windows.Forms.Button btn7;
            System.Windows.Forms.Button btnMas;
            System.Windows.Forms.Button btn2;
            System.Windows.Forms.Button btn5;
            System.Windows.Forms.Button btn8;
            System.Windows.Forms.Button btnMenos;
            System.Windows.Forms.Button btnEntre;
            System.Windows.Forms.Button btnLimpiar;
            System.Windows.Forms.Button btnBorrar;
            System.Windows.Forms.Button btnIgual;
            System.Windows.Forms.Button btnPor;
            System.Windows.Forms.Button btn9;
            System.Windows.Forms.Button btn6;
            System.Windows.Forms.Button btn3;
            System.Windows.Forms.Button btnPunto;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            btnCero = new System.Windows.Forms.Button();
            btn1 = new System.Windows.Forms.Button();
            btn4 = new System.Windows.Forms.Button();
            btn7 = new System.Windows.Forms.Button();
            btnMas = new System.Windows.Forms.Button();
            btn2 = new System.Windows.Forms.Button();
            btn5 = new System.Windows.Forms.Button();
            btn8 = new System.Windows.Forms.Button();
            btnMenos = new System.Windows.Forms.Button();
            btnEntre = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnBorrar = new System.Windows.Forms.Button();
            btnIgual = new System.Windows.Forms.Button();
            btnPor = new System.Windows.Forms.Button();
            btn9 = new System.Windows.Forms.Button();
            btn6 = new System.Windows.Forms.Button();
            btn3 = new System.Windows.Forms.Button();
            btnPunto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Casio FX-129100";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCero
            // 
            btnCero.BackColor = System.Drawing.Color.SeaGreen;
            btnCero.Font = new System.Drawing.Font("Verdana", 15.75F);
            btnCero.ForeColor = System.Drawing.Color.White;
            btnCero.Location = new System.Drawing.Point(116, 379);
            btnCero.Name = "btnCero";
            btnCero.Size = new System.Drawing.Size(112, 46);
            btnCero.TabIndex = 1;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = false;
            btnCero.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn1
            // 
            btn1.BackColor = System.Drawing.Color.SeaGreen;
            btn1.Font = new System.Drawing.Font("Verdana", 15.75F);
            btn1.ForeColor = System.Drawing.Color.White;
            btn1.Location = new System.Drawing.Point(116, 327);
            btn1.Name = "btn1";
            btn1.Size = new System.Drawing.Size(53, 46);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            btn4.BackColor = System.Drawing.Color.SeaGreen;
            btn4.Font = new System.Drawing.Font("Verdana", 15.75F);
            btn4.ForeColor = System.Drawing.Color.White;
            btn4.Location = new System.Drawing.Point(116, 275);
            btn4.Name = "btn4";
            btn4.Size = new System.Drawing.Size(53, 46);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            btn7.BackColor = System.Drawing.Color.SeaGreen;
            btn7.Font = new System.Drawing.Font("Verdana", 15.75F);
            btn7.ForeColor = System.Drawing.Color.White;
            btn7.Location = new System.Drawing.Point(116, 222);
            btn7.Name = "btn7";
            btn7.Size = new System.Drawing.Size(53, 46);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnMas
            // 
            btnMas.BackColor = System.Drawing.Color.SeaGreen;
            btnMas.Font = new System.Drawing.Font("Verdana", 15.75F);
            btnMas.ForeColor = System.Drawing.Color.White;
            btnMas.Location = new System.Drawing.Point(116, 171);
            btnMas.Name = "btnMas";
            btnMas.Size = new System.Drawing.Size(53, 46);
            btnMas.TabIndex = 1;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = false;
            btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btn2
            // 
            btn2.BackColor = System.Drawing.Color.SeaGreen;
            btn2.Font = new System.Drawing.Font("Verdana", 15.75F);
            btn2.ForeColor = System.Drawing.Color.White;
            btn2.Location = new System.Drawing.Point(175, 327);
            btn2.Name = "btn2";
            btn2.Size = new System.Drawing.Size(53, 46);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            btn5.BackColor = System.Drawing.Color.SeaGreen;
            btn5.Font = new System.Drawing.Font("Verdana", 15.75F);
            btn5.ForeColor = System.Drawing.Color.White;
            btn5.Location = new System.Drawing.Point(175, 275);
            btn5.Name = "btn5";
            btn5.Size = new System.Drawing.Size(53, 46);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            btn8.BackColor = System.Drawing.Color.SeaGreen;
            btn8.Font = new System.Drawing.Font("Verdana", 15.75F);
            btn8.ForeColor = System.Drawing.Color.White;
            btn8.Location = new System.Drawing.Point(175, 222);
            btn8.Name = "btn8";
            btn8.Size = new System.Drawing.Size(53, 46);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnMenos
            // 
            btnMenos.BackColor = System.Drawing.Color.SeaGreen;
            btnMenos.Font = new System.Drawing.Font("Verdana", 15.75F);
            btnMenos.ForeColor = System.Drawing.Color.White;
            btnMenos.Location = new System.Drawing.Point(175, 171);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new System.Drawing.Size(53, 46);
            btnMenos.TabIndex = 1;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnEntre
            // 
            btnEntre.BackColor = System.Drawing.Color.SeaGreen;
            btnEntre.Font = new System.Drawing.Font("Verdana", 15.75F);
            btnEntre.ForeColor = System.Drawing.Color.White;
            btnEntre.Location = new System.Drawing.Point(293, 172);
            btnEntre.Name = "btnEntre";
            btnEntre.Size = new System.Drawing.Size(53, 46);
            btnEntre.TabIndex = 1;
            btnEntre.Text = "\t÷";
            btnEntre.UseVisualStyleBackColor = false;
            btnEntre.Click += new System.EventHandler(this.btnEntre_Click);
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.Color.SeaGreen;
            btnLimpiar.Font = new System.Drawing.Font("Verdana", 14.25F);
            btnLimpiar.ForeColor = System.Drawing.Color.White;
            btnLimpiar.Location = new System.Drawing.Point(293, 224);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(53, 46);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "CE";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = System.Drawing.Color.SeaGreen;
            btnBorrar.Font = new System.Drawing.Font("Verdana", 15.75F);
            btnBorrar.ForeColor = System.Drawing.Color.White;
            btnBorrar.Location = new System.Drawing.Point(293, 276);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new System.Drawing.Size(53, 46);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "←";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnIgual
            // 
            btnIgual.BackColor = System.Drawing.Color.SeaGreen;
            btnIgual.Font = new System.Drawing.Font("Verdana", 15.75F);
            btnIgual.ForeColor = System.Drawing.Color.White;
            btnIgual.Location = new System.Drawing.Point(293, 328);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new System.Drawing.Size(53, 98);
            btnIgual.TabIndex = 1;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnPor
            // 
            btnPor.BackColor = System.Drawing.Color.SeaGreen;
            btnPor.Font = new System.Drawing.Font("Verdana", 15.75F);
            btnPor.ForeColor = System.Drawing.Color.White;
            btnPor.Location = new System.Drawing.Point(234, 172);
            btnPor.Name = "btnPor";
            btnPor.Size = new System.Drawing.Size(53, 46);
            btnPor.TabIndex = 1;
            btnPor.Text = "x";
            btnPor.UseVisualStyleBackColor = false;
            btnPor.Click += new System.EventHandler(this.btnPor_Click);
            // 
            // btn9
            // 
            btn9.BackColor = System.Drawing.Color.SeaGreen;
            btn9.Font = new System.Drawing.Font("Verdana", 15.75F);
            btn9.ForeColor = System.Drawing.Color.White;
            btn9.Location = new System.Drawing.Point(234, 223);
            btn9.Name = "btn9";
            btn9.Size = new System.Drawing.Size(53, 46);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            btn6.BackColor = System.Drawing.Color.SeaGreen;
            btn6.Font = new System.Drawing.Font("Verdana", 15.75F);
            btn6.ForeColor = System.Drawing.Color.White;
            btn6.Location = new System.Drawing.Point(234, 276);
            btn6.Name = "btn6";
            btn6.Size = new System.Drawing.Size(53, 46);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            btn3.BackColor = System.Drawing.Color.SeaGreen;
            btn3.Font = new System.Drawing.Font("Verdana", 15.75F);
            btn3.ForeColor = System.Drawing.Color.White;
            btn3.Location = new System.Drawing.Point(234, 328);
            btn3.Name = "btn3";
            btn3.Size = new System.Drawing.Size(53, 46);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnPunto
            // 
            btnPunto.BackColor = System.Drawing.Color.SeaGreen;
            btnPunto.Font = new System.Drawing.Font("Verdana", 15.75F);
            btnPunto.ForeColor = System.Drawing.Color.White;
            btnPunto.Location = new System.Drawing.Point(234, 380);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new System.Drawing.Size(53, 46);
            btnPunto.TabIndex = 1;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = false;
            btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDatos.Location = new System.Drawing.Point(116, 125);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(230, 31);
            this.txtDatos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(btnIgual);
            this.panel1.Controls.Add(this.txtDatos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(btnPunto);
            this.panel1.Controls.Add(btnCero);
            this.panel1.Controls.Add(btn3);
            this.panel1.Controls.Add(btn1);
            this.panel1.Controls.Add(btn6);
            this.panel1.Controls.Add(btn4);
            this.panel1.Controls.Add(btn9);
            this.panel1.Controls.Add(btn7);
            this.panel1.Controls.Add(btnPor);
            this.panel1.Controls.Add(btnMas);
            this.panel1.Controls.Add(btn2);
            this.panel1.Controls.Add(btnBorrar);
            this.panel1.Controls.Add(btn5);
            this.panel1.Controls.Add(btnLimpiar);
            this.panel1.Controls.Add(btn8);
            this.panel1.Controls.Add(btnEntre);
            this.panel1.Controls.Add(btnMenos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 511);
            this.panel1.TabIndex = 2;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1059, 511);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        //botonCero
        private void button1_Click(object sender, EventArgs e)
        {
            txtDatos.Text = txtDatos.Text + "0";
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Panel panel1;
    }
}

