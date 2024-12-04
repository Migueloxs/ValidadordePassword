namespace ValidadorDeContraseñasUI
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEslogan = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbEstado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerEslogan = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(12, 72);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(200, 29);
            this.txtContraseña.TabIndex = 0;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.LightBlue;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(218, 72);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(200, 30);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar Contraseña";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Black;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResultado.Location = new System.Drawing.Point(12, 110);
            this.lblResultado.MaximumSize = new System.Drawing.Size(200, 50);
            this.lblResultado.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(200, 50);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "label1";
            this.lblResultado.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.pbEstado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.btnValidar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 249);
            this.panel1.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Image = global::ValidadorDeContraseñasUI.Properties.Resources.X;
            this.btnSalir.Location = new System.Drawing.Point(12, 203);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEslogan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 20);
            this.panel2.TabIndex = 7;
            // 
            // lblEslogan
            // 
            this.lblEslogan.AutoSize = true;
            this.lblEslogan.BackColor = System.Drawing.Color.Black;
            this.lblEslogan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEslogan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEslogan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEslogan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEslogan.Location = new System.Drawing.Point(0, 0);
            this.lblEslogan.Name = "lblEslogan";
            this.lblEslogan.Size = new System.Drawing.Size(697, 21);
            this.lblEslogan.TabIndex = 5;
            this.lblEslogan.Text = " P r o t e g e  l o  q u e  m á s  i m p o r t a  e n  t u  v i d a : ¡ e m p i e" +
    " z a  c o n  t u  c o n t r a s e ñ a !";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.CadetBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(87, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 24);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Validador de Contraseñas.";
            // 
            // pbEstado
            // 
            this.pbEstado.Image = global::ValidadorDeContraseñasUI.Properties.Resources.password1_900px;
            this.pbEstado.Location = new System.Drawing.Point(448, 0);
            this.pbEstado.Name = "pbEstado";
            this.pbEstado.Size = new System.Drawing.Size(281, 247);
            this.pbEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEstado.TabIndex = 4;
            this.pbEstado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ValidadorDeContraseñasUI.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timerEslogan
            // 
            this.timerEslogan.Interval = 500;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(913, 450);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEslogan;
        private System.Windows.Forms.Timer timerEslogan;
        private System.Windows.Forms.PictureBox pbEstado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
    }
}
