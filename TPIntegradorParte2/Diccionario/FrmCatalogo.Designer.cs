namespace TPIntegradorParte2
{
    partial class FrmCatalogo
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
            label2 = new Label();
            btnAgregar = new Button();
            btnBuscar = new Button();
            lstProductos = new ListBox();
            txtSku = new TextBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Código SKU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Del Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 73);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(193, 73);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 15;
            lstProductos.Location = new Point(12, 113);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(290, 214);
            lstProductos.TabIndex = 4;
            // 
            // txtSku
            // 
            txtSku.Location = new Point(88, 15);
            txtSku.Name = "txtSku";
            txtSku.Size = new Size(127, 23);
            txtSku.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(127, 23);
            txtNombre.TabIndex = 6;
            // 
            // FrmCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 341);
            Controls.Add(txtNombre);
            Controls.Add(txtSku);
            Controls.Add(lstProductos);
            Controls.Add(btnBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCatalogo";
            Text = "FrmCatalogo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAgregar;
        private Button btnBuscar;
        private ListBox lstProductos;
        private TextBox txtSku;
        private TextBox txtNombre;
    }
}