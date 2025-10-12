namespace TPIntegradorParte2
{
    partial class FrmPilaPlatos
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
            btnApilar = new Button();
            btnDesapilar = new Button();
            btnVercima = new Button();
            lstPlatos = new ListBox();
            txtPlato = new TextBox();
            SuspendLayout();
            // 
            // btnApilar
            // 
            btnApilar.Location = new Point(8, 41);
            btnApilar.Name = "btnApilar";
            btnApilar.Size = new Size(75, 23);
            btnApilar.TabIndex = 0;
            btnApilar.Text = "Apilar";
            btnApilar.UseVisualStyleBackColor = true;
            btnApilar.Click += btnApilar_Click;
            // 
            // btnDesapilar
            // 
            btnDesapilar.Location = new Point(89, 41);
            btnDesapilar.Name = "btnDesapilar";
            btnDesapilar.Size = new Size(75, 23);
            btnDesapilar.TabIndex = 1;
            btnDesapilar.Text = "Desapilar";
            btnDesapilar.UseVisualStyleBackColor = true;
            btnDesapilar.Click += btnDesapilar_Click;
            // 
            // btnVercima
            // 
            btnVercima.Location = new Point(170, 41);
            btnVercima.Name = "btnVercima";
            btnVercima.Size = new Size(75, 23);
            btnVercima.TabIndex = 2;
            btnVercima.Text = "Ver Cima";
            btnVercima.UseVisualStyleBackColor = true;
            btnVercima.Click += btnVercima_Click;
            // 
            // lstPlatos
            // 
            lstPlatos.FormattingEnabled = true;
            lstPlatos.ItemHeight = 15;
            lstPlatos.Location = new Point(12, 80);
            lstPlatos.Name = "lstPlatos";
            lstPlatos.Size = new Size(233, 154);
            lstPlatos.TabIndex = 3;
            // 
            // txtPlato
            // 
            txtPlato.Location = new Point(39, 12);
            txtPlato.Name = "txtPlato";
            txtPlato.Size = new Size(169, 23);
            txtPlato.TabIndex = 4;
            // 
            // FrmPilaPlatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 244);
            Controls.Add(txtPlato);
            Controls.Add(lstPlatos);
            Controls.Add(btnVercima);
            Controls.Add(btnDesapilar);
            Controls.Add(btnApilar);
            Name = "FrmPilaPlatos";
            Text = "FrmPilaPlatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnApilar;
        private Button btnDesapilar;
        private Button btnVercima;
        private ListBox lstPlatos;
        private TextBox txtPlato;
    }
}