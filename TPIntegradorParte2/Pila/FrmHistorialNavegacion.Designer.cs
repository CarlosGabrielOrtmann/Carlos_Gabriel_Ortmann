namespace TPIntegradorParte2
{
    partial class FrmHistorialNavegacion
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
            btnVisitar = new Button();
            btnAtras = new Button();
            lstHistorial = new ListBox();
            label1 = new Label();
            txtUrl = new TextBox();
            SuspendLayout();
            // 
            // btnVisitar
            // 
            btnVisitar.Location = new Point(12, 56);
            btnVisitar.Name = "btnVisitar";
            btnVisitar.Size = new Size(75, 23);
            btnVisitar.TabIndex = 0;
            btnVisitar.Text = "Visitar";
            btnVisitar.UseVisualStyleBackColor = true;
            btnVisitar.Click += btnVisitar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(109, 56);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(12, 85);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(467, 199);
            lstHistorial.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Nuevo URL";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(84, 18);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(100, 23);
            txtUrl.TabIndex = 4;
            // 
            // FrmHistorialNavegacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 309);
            Controls.Add(txtUrl);
            Controls.Add(label1);
            Controls.Add(lstHistorial);
            Controls.Add(btnAtras);
            Controls.Add(btnVisitar);
            Name = "FrmHistorialNavegacion";
            Text = "FrmHistorialNavegacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVisitar;
        private Button btnAtras;
        private ListBox lstHistorial;
        private Label label1;
        private TextBox txtUrl;
    }
}