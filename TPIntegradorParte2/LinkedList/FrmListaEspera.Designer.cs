namespace TPIntegradorParte2
{
    partial class FrmListaEspera
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
            txtCliente = new TextBox();
            btnAgregar = new Button();
            btnAtender = new Button();
            btnAbandonar = new Button();
            lstClientes = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(107, 15);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 64);
            btnAgregar.Name = "btnEnviar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(93, 64);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(75, 23);
            btnAtender.TabIndex = 3;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnAbandonar
            // 
            btnAbandonar.Location = new Point(174, 64);
            btnAbandonar.Name = "btnAbandonar";
            btnAbandonar.Size = new Size(113, 23);
            btnAbandonar.TabIndex = 4;
            btnAbandonar.Text = "Abandonar espera";
            btnAbandonar.UseVisualStyleBackColor = true;
            btnAbandonar.Click += btnAbandonar_Click;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(12, 109);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(269, 244);
            lstClientes.TabIndex = 5;
            // 
            // FrmListaEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 369);
            Controls.Add(lstClientes);
            Controls.Add(btnAbandonar);
            Controls.Add(btnAtender);
            Controls.Add(btnAgregar);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Name = "FrmListaEspera";
            Text = "FrmListaEspera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private Button btnAgregar;
        private Button btnAtender;
        private Button btnAbandonar;
        private ListBox lstClientes;
    }
}