namespace TPIntegradorParte2
{
    partial class FrmColaImpresion
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
            btnEnviar = new Button();
            btnImprimir = new Button();
            lstDocumentos = new ListBox();
            txtDocumento = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(12, 51);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Agregar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(118, 51);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lstDocumentos
            // 
            lstDocumentos.FormattingEnabled = true;
            lstDocumentos.ItemHeight = 15;
            lstDocumentos.Location = new Point(17, 90);
            lstDocumentos.Name = "lstDocumentos";
            lstDocumentos.Size = new Size(451, 349);
            lstDocumentos.TabIndex = 3;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(93, 19);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 23);
            txtDocumento.TabIndex = 4;
            // 
            // FrmColaImpresion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 450);
            Controls.Add(txtDocumento);
            Controls.Add(lstDocumentos);
            Controls.Add(btnImprimir);
            Controls.Add(btnEnviar);
            Controls.Add(label1);
            Name = "FrmColaImpresion";
            Text = "FrmColaImpresion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEnviar;
        private Button btnImprimir;
        private ListBox lstDocumentos;
        private TextBox txtDocumento;
    }
}