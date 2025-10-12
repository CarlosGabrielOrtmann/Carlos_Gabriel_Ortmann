namespace TPIntegradorParte2
{
    partial class FrmCallCenter
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
            label1 = new Label();
            txtLlamada = new TextBox();
            btnAgregar = new Button();
            btnAtender = new Button();
            lstLlamadas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Llamada Entrante";
            // 
            // txtLlamada
            // 
            txtLlamada.Location = new Point(117, 12);
            txtLlamada.Name = "txtLlamada";
            txtLlamada.Size = new Size(100, 23);
            txtLlamada.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 44);
            btnAgregar.Name = "btnEnviar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(142, 44);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(75, 23);
            btnAtender.TabIndex = 3;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // lstLlamadas
            // 
            lstLlamadas.FormattingEnabled = true;
            lstLlamadas.ItemHeight = 15;
            lstLlamadas.Location = new Point(12, 83);
            lstLlamadas.Name = "lstLlamadas";
            lstLlamadas.Size = new Size(205, 184);
            lstLlamadas.TabIndex = 4;
            // 
            // FrmCallCenter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 292);
            Controls.Add(lstLlamadas);
            Controls.Add(btnAtender);
            Controls.Add(btnAgregar);
            Controls.Add(txtLlamada);
            Controls.Add(label1);
            Name = "FrmCallCenter";
            Text = "FrmCallCenter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLlamada;
        private Button btnAgregar;
        private Button btnAtender;
        private ListBox lstLlamadas;
    }
}