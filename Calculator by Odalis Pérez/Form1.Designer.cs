namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new System.Windows.Forms.TextBox();
            btnUno = new System.Windows.Forms.Button();
            btnDos = new System.Windows.Forms.Button();
            btnTres = new System.Windows.Forms.Button();
            btnSeis = new System.Windows.Forms.Button();
            btnCinco = new System.Windows.Forms.Button();
            btnCuatro = new System.Windows.Forms.Button();
            btnQuitar = new System.Windows.Forms.Button();
            btnBorrarTodo = new System.Windows.Forms.Button();
            btnBorrar = new System.Windows.Forms.Button();
            btnNueve = new System.Windows.Forms.Button();
            btnOcho = new System.Windows.Forms.Button();
            btnSiete = new System.Windows.Forms.Button();
            btnCuadrado = new System.Windows.Forms.Button();
            btnRaizCuadrada = new System.Windows.Forms.Button();
            btnMultiplicar = new System.Windows.Forms.Button();
            btnDividir = new System.Windows.Forms.Button();
            btnRestar = new System.Windows.Forms.Button();
            btnSumar = new System.Windows.Forms.Button();
            btnResultado = new System.Windows.Forms.Button();
            btnPunto = new System.Windows.Forms.Button();
            btnCero = new System.Windows.Forms.Button();
            btnSigno = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtResultado.Location = new System.Drawing.Point(15, 17);
            txtResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtResultado.MaxLength = 21;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new System.Drawing.Size(361, 59);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            btnUno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUno.Location = new System.Drawing.Point(15, 332);
            btnUno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUno.Name = "btnUno";
            btnUno.Size = new System.Drawing.Size(59, 60);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDos.Location = new System.Drawing.Point(80, 332);
            btnDos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDos.Name = "btnDos";
            btnDos.Size = new System.Drawing.Size(59, 60);
            btnDos.TabIndex = 2;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTres.Location = new System.Drawing.Point(145, 332);
            btnTres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTres.Name = "btnTres";
            btnTres.Size = new System.Drawing.Size(59, 60);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSeis.Location = new System.Drawing.Point(145, 253);
            btnSeis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new System.Drawing.Size(59, 60);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCinco.Location = new System.Drawing.Point(80, 253);
            btnCinco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new System.Drawing.Size(59, 60);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCuatro.Location = new System.Drawing.Point(15, 253);
            btnCuatro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new System.Drawing.Size(59, 60);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += agregarNumero;
            // 
            // btnQuitar
            // 
            btnQuitar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnQuitar.Location = new System.Drawing.Point(146, 95);
            btnQuitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new System.Drawing.Size(59, 60);
            btnQuitar.TabIndex = 12;
            btnQuitar.Text = "<-";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBorrarTodo.Location = new System.Drawing.Point(80, 95);
            btnBorrarTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new System.Drawing.Size(59, 60);
            btnBorrarTodo.TabIndex = 11;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBorrar.Location = new System.Drawing.Point(15, 95);
            btnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new System.Drawing.Size(59, 60);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnNueve
            // 
            btnNueve.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNueve.Location = new System.Drawing.Point(145, 175);
            btnNueve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new System.Drawing.Size(59, 60);
            btnNueve.TabIndex = 9;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOcho.Location = new System.Drawing.Point(80, 175);
            btnOcho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new System.Drawing.Size(59, 60);
            btnOcho.TabIndex = 8;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSiete.Location = new System.Drawing.Point(15, 175);
            btnSiete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new System.Drawing.Size(59, 60);
            btnSiete.TabIndex = 7;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += agregarNumero;
            // 
            // btnCuadrado
            // 
            btnCuadrado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCuadrado.Location = new System.Drawing.Point(317, 95);
            btnCuadrado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new System.Drawing.Size(59, 60);
            btnCuadrado.TabIndex = 14;
            btnCuadrado.Tag = "²";
            btnCuadrado.Text = "x²";
            btnCuadrado.UseVisualStyleBackColor = true;
            btnCuadrado.Click += clickOperador;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRaizCuadrada.Location = new System.Drawing.Point(250, 95);
            btnRaizCuadrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new System.Drawing.Size(59, 60);
            btnRaizCuadrada.TabIndex = 13;
            btnRaizCuadrada.Tag = "√";
            btnRaizCuadrada.Text = "√";
            btnRaizCuadrada.UseVisualStyleBackColor = true;
            btnRaizCuadrada.Click += clickOperador;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMultiplicar.Location = new System.Drawing.Point(317, 175);
            btnMultiplicar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new System.Drawing.Size(59, 60);
            btnMultiplicar.TabIndex = 16;
            btnMultiplicar.Tag = "X";
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += clickOperador;
            // 
            // btnDividir
            // 
            btnDividir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDividir.Location = new System.Drawing.Point(250, 175);
            btnDividir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new System.Drawing.Size(59, 60);
            btnDividir.TabIndex = 15;
            btnDividir.Tag = "∕";
            btnDividir.Text = "∕";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += clickOperador;
            // 
            // btnRestar
            // 
            btnRestar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRestar.Location = new System.Drawing.Point(317, 253);
            btnRestar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new System.Drawing.Size(59, 60);
            btnRestar.TabIndex = 18;
            btnRestar.Tag = "−";
            btnRestar.Text = "−";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += clickOperador;
            // 
            // btnSumar
            // 
            btnSumar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSumar.Location = new System.Drawing.Point(250, 253);
            btnSumar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new System.Drawing.Size(59, 60);
            btnSumar.TabIndex = 17;
            btnSumar.Tag = "+";
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += clickOperador;
            // 
            // btnResultado
            // 
            btnResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnResultado.Location = new System.Drawing.Point(250, 332);
            btnResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new System.Drawing.Size(126, 60);
            btnResultado.TabIndex = 19;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPunto.Location = new System.Drawing.Point(145, 413);
            btnPunto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new System.Drawing.Size(59, 60);
            btnPunto.TabIndex = 22;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnCero
            // 
            btnCero.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCero.Location = new System.Drawing.Point(80, 413);
            btnCero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCero.Name = "btnCero";
            btnCero.Size = new System.Drawing.Size(59, 60);
            btnCero.TabIndex = 21;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += agregarNumero;
            // 
            // btnSigno
            // 
            btnSigno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSigno.Location = new System.Drawing.Point(15, 413);
            btnSigno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new System.Drawing.Size(59, 60);
            btnSigno.TabIndex = 20;
            btnSigno.Text = "+/-";
            btnSigno.UseVisualStyleBackColor = true;
            btnSigno.Click += btnSigno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(390, 487);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnSigno);
            Controls.Add(btnResultado);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnCuadrado);
            Controls.Add(btnRaizCuadrada);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnBorrar);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Calculator by Odalis Pérez";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnSigno;
    }
}
