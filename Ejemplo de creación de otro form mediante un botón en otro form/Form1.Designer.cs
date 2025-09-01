namespace Ejemplo_de_creación_de_otro_form_mediante_un_botón_en_otro_form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAbrir = new Button();
            txtMensaje = new TextBox();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(221, 92);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(139, 39);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(51, 101);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(100, 23);
            txtMensaje.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMensaje);
            Controls.Add(btnAbrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrir;
        private TextBox txtMensaje;
    }
}
