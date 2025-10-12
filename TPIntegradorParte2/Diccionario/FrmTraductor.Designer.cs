namespace TPIntegradorParte2
{
    partial class FrmTraductor
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
            btnAgregar = new Button();
            btnTraducir = new Button();
            label1 = new Label();
            label2 = new Label();
            lstTraducciones = new ListBox();
            txtIngles = new TextBox();
            txtEspañol = new TextBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 69);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += this.btnAgregar_Click;
            // 
            // btnTraducir
            // 
            btnTraducir.Location = new Point(142, 69);
            btnTraducir.Name = "btnTraducir";
            btnTraducir.Size = new Size(75, 23);
            btnTraducir.TabIndex = 1;
            btnTraducir.Text = "Traducir";
            btnTraducir.UseVisualStyleBackColor = true;
            btnTraducir.Click += this.btnTraducir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Inglés";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Español";
            // 
            // lstTraducciones
            // 
            lstTraducciones.FormattingEnabled = true;
            lstTraducciones.ItemHeight = 15;
            lstTraducciones.Location = new Point(12, 98);
            lstTraducciones.Name = "lstTraducciones";
            lstTraducciones.Size = new Size(339, 199);
            lstTraducciones.TabIndex = 4;
            // 
            // txtIngles
            // 
            txtIngles.Location = new Point(56, 9);
            txtIngles.Name = "txtIngles";
            txtIngles.Size = new Size(161, 23);
            txtIngles.TabIndex = 5;
            // 
            // txtEspañol
            // 
            txtEspañol.Location = new Point(64, 40);
            txtEspañol.Name = "txtEspañol";
            txtEspañol.Size = new Size(153, 23);
            txtEspañol.TabIndex = 6;
            // 
            // FrmTraductor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 306);
            Controls.Add(txtEspañol);
            Controls.Add(txtIngles);
            Controls.Add(lstTraducciones);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTraducir);
            Controls.Add(btnAgregar);
            Name = "FrmTraductor";
            Text = "FrmTraductor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnTraducir;
        private Label label1;
        private Label label2;
        private ListBox lstTraducciones;
        private TextBox txtIngles;
        private TextBox txtEspañol;
    }
}