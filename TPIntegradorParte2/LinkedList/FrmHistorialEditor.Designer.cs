namespace TPIntegradorParte2
{
    partial class FrmHistorialEditor
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
            txtAccion = new TextBox();
            lstHistorial = new ListBox();
            btnAgregarAccion = new Button();
            btnDeshacer = new Button();
            btnRehacer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Acción";
            // 
            // txtAccion
            // 
            txtAccion.Location = new Point(71, 15);
            txtAccion.Name = "txtAccion";
            txtAccion.Size = new Size(100, 23);
            txtAccion.TabIndex = 1;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(12, 119);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(256, 214);
            lstHistorial.TabIndex = 2;
            // 
            // btnAgregarAccion
            // 
            btnAgregarAccion.Location = new Point(12, 68);
            btnAgregarAccion.Name = "btnAgregarAccion";
            btnAgregarAccion.Size = new Size(98, 23);
            btnAgregarAccion.TabIndex = 3;
            btnAgregarAccion.Text = "Agregar Acción";
            btnAgregarAccion.UseVisualStyleBackColor = true;
            btnAgregarAccion.Click += btnAgregarAccion_Click;
            // 
            // btnDeshacer
            // 
            btnDeshacer.Location = new Point(116, 68);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(75, 23);
            btnDeshacer.TabIndex = 4;
            btnDeshacer.Text = "Deshacer";
            btnDeshacer.UseVisualStyleBackColor = true;
            btnDeshacer.Click += btnDeshacer_Click;
            // 
            // btnRehacer
            // 
            btnRehacer.Location = new Point(197, 68);
            btnRehacer.Name = "btnRehacer";
            btnRehacer.Size = new Size(75, 23);
            btnRehacer.TabIndex = 5;
            btnRehacer.Text = "Rehacer";
            btnRehacer.UseVisualStyleBackColor = true;
            btnRehacer.Click += btnRehacer_Click;
            // 
            // FrmHistorialEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 345);
            Controls.Add(btnRehacer);
            Controls.Add(btnDeshacer);
            Controls.Add(btnAgregarAccion);
            Controls.Add(lstHistorial);
            Controls.Add(txtAccion);
            Controls.Add(label1);
            Name = "FrmHistorialEditor";
            Text = "FrmHistorialEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAccion;
        private ListBox lstHistorial;
        private Button btnAgregarAccion;
        private Button btnDeshacer;
        private Button btnRehacer;
    }
}