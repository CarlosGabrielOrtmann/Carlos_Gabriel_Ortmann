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
            listBox1 = new ListBox();
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
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(93, 64);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(75, 23);
            btnAtender.TabIndex = 3;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            // 
            // btnAbandonar
            // 
            btnAbandonar.Location = new Point(174, 64);
            btnAbandonar.Name = "btnAbandonar";
            btnAbandonar.Size = new Size(113, 23);
            btnAbandonar.TabIndex = 4;
            btnAbandonar.Text = "Abandonar espera";
            btnAbandonar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(47, 214);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 5;
            // 
            // FrmListaEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
    }
}