namespace Ejercicio_video_de_windows_form___Clase_3
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupSeguro = new System.Windows.Forms.GroupBox();
            this.rbTotal = new System.Windows.Forms.RadioButton();
            this.rbTerceros = new System.Windows.Forms.RadioButton();
            this.rbBasico = new System.Windows.Forms.RadioButton();
            this.groupEquipo = new System.Windows.Forms.GroupBox();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.chkAire = new System.Windows.Forms.CheckBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.lstResumen = new System.Windows.Forms.ListBox();
            this.groupSeguro.SuspendLayout();
            this.groupEquipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 15);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre completo:";
            // 
            // groupSeguro
            // 
            this.groupSeguro.Controls.Add(this.rbTotal);
            this.groupSeguro.Controls.Add(this.rbTerceros);
            this.groupSeguro.Controls.Add(this.rbBasico);
            this.groupSeguro.Location = new System.Drawing.Point(20, 55);
            this.groupSeguro.Name = "groupSeguro";
            this.groupSeguro.Size = new System.Drawing.Size(200, 120);
            this.groupSeguro.TabIndex = 2;
            this.groupSeguro.TabStop = false;
            this.groupSeguro.Text = "Seguro";
            // 
            // rbTotal
            // 
            this.rbTotal.AutoSize = true;
            this.rbTotal.Location = new System.Drawing.Point(20, 85);
            this.rbTotal.Name = "rbTotal";
            this.rbTotal.Size = new System.Drawing.Size(52, 19);
            this.rbTotal.TabIndex = 3;
            this.rbTotal.TabStop = true;
            this.rbTotal.Text = "Total";
            this.rbTotal.UseVisualStyleBackColor = true;
            // 
            // rbTerceros
            // 
            this.rbTerceros.AutoSize = true;
            this.rbTerceros.Location = new System.Drawing.Point(20, 60);
            this.rbTerceros.Name = "rbTerceros";
            this.rbTerceros.Size = new System.Drawing.Size(77, 19);
            this.rbTerceros.TabIndex = 2;
            this.rbTerceros.TabStop = true;
            this.rbTerceros.Text = "A Terceros";
            this.rbTerceros.UseVisualStyleBackColor = true;
            // 
            // rbBasico
            // 
            this.rbBasico.AutoSize = true;
            this.rbBasico.Checked = true;
            this.rbBasico.Location = new System.Drawing.Point(20, 35);
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.Size = new System.Drawing.Size(60, 19);
            this.rbBasico.TabIndex = 1;
            this.rbBasico.TabStop = true;
            this.rbBasico.Text = "Básico";
            this.rbBasico.UseVisualStyleBackColor = true;
            // 
            // groupEquipo
            // 
            this.groupEquipo.Controls.Add(this.chkAudio);
            this.groupEquipo.Controls.Add(this.chkAire);
            this.groupEquipo.Location = new System.Drawing.Point(240, 55);
            this.groupEquipo.Name = "groupEquipo";
            this.groupEquipo.Size = new System.Drawing.Size(200, 120);
            this.groupEquipo.TabIndex = 3;
            this.groupEquipo.TabStop = false;
            this.groupEquipo.Text = "Equipamiento";
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.Location = new System.Drawing.Point(20, 70);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(106, 19);
            this.chkAudio.TabIndex = 2;
            this.chkAudio.Text = "Sistema de audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            // 
            // chkAire
            // 
            this.chkAire.AutoSize = true;
            this.chkAire.Location = new System.Drawing.Point(20, 45);
            this.chkAire.Name = "chkAire";
            this.chkAire.Size = new System.Drawing.Size(121, 19);
            this.chkAire.TabIndex = 1;
            this.chkAire.Text = "Aire acondicionado";
            this.chkAire.UseVisualStyleBackColor = true;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(80, 190);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(140, 23);
            this.txtCosto.TabIndex = 4;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(20, 193);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(40, 15);
            this.lblCosto.TabIndex = 5;
            this.lblCosto.Text = "Costo:";
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(240, 188);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(100, 27);
            this.btnCotizar.TabIndex = 6;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // lstResumen
            // 
            this.lstResumen.FormattingEnabled = true;
            this.lstResumen.ItemHeight = 15;
            this.lstResumen.Location = new System.Drawing.Point(20, 230);
            this.lstResumen.Name = "lstResumen";
            this.lstResumen.Size = new System.Drawing.Size(420, 124);
            this.lstResumen.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 381);
            this.Controls.Add(this.lstResumen);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.groupEquipo);
            this.Controls.Add(this.groupSeguro);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Seguros";
            this.groupSeguro.ResumeLayout(false);
            this.groupSeguro.PerformLayout();
            this.groupEquipo.ResumeLayout(false);
            this.groupEquipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupSeguro;
        private System.Windows.Forms.RadioButton rbTotal;
        private System.Windows.Forms.RadioButton rbTerceros;
        private System.Windows.Forms.RadioButton rbBasico;
        private System.Windows.Forms.GroupBox groupEquipo;
        private System.Windows.Forms.CheckBox chkAudio;
        private System.Windows.Forms.CheckBox chkAire;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.ListBox lstResumen;
    }
}

