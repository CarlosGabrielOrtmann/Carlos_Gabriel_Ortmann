namespace TPIntegradorParte2
{
    partial class FrmColaProcesos
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
            btnEjecutar = new Button();
            label1 = new Label();
            txtProceso = new TextBox();
            lstProcesos = new ListBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 52);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(157, 52);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 1;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre Del Proceso";
            // 
            // txtProceso
            // 
            txtProceso.Location = new Point(132, 15);
            txtProceso.Name = "txtProceso";
            txtProceso.Size = new Size(100, 23);
            txtProceso.TabIndex = 3;
            // 
            // lstProcesos
            // 
            lstProcesos.FormattingEnabled = true;
            lstProcesos.ItemHeight = 15;
            lstProcesos.Location = new Point(8, 81);
            lstProcesos.Name = "lstProcesos";
            lstProcesos.Size = new Size(256, 229);
            lstProcesos.TabIndex = 4;
            // 
            // FrmColaProcesos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 320);
            Controls.Add(lstProcesos);
            Controls.Add(txtProceso);
            Controls.Add(label1);
            Controls.Add(btnEjecutar);
            Controls.Add(btnAgregar);
            Name = "FrmColaProcesos";
            Text = "FrmColaProcesos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEjecutar;
        private Label label1;
        private TextBox txtProceso;
        private ListBox lstProcesos;
    }
}