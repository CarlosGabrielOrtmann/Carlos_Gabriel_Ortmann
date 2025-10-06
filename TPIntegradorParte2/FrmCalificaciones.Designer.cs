namespace TPIntegradorParte2
{
    partial class FrmCalificaciones
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
            txtNota = new TextBox();
            lstNotas = new ListBox();
            lblPromedio = new Label();
            btnAgregar = new Button();
            btnEliminarMenor = new Button();
            btnEliminarMayor = new Button();
            btnPromedio = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Nueva calificación";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(132, 17);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(100, 23);
            txtNota.TabIndex = 1;
            // 
            // lstNotas
            // 
            lstNotas.FormattingEnabled = true;
            lstNotas.ItemHeight = 15;
            lstNotas.Location = new Point(22, 108);
            lstNotas.Name = "lstNotas";
            lstNotas.Size = new Size(386, 184);
            lstNotas.TabIndex = 2;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(316, 20);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(0, 15);
            lblPromedio.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(127, 50);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMenor
            // 
            btnEliminarMenor.Location = new Point(22, 79);
            btnEliminarMenor.Name = "btnEliminarMenor";
            btnEliminarMenor.Size = new Size(99, 23);
            btnEliminarMenor.TabIndex = 5;
            btnEliminarMenor.Text = "Eliminar Menor";
            btnEliminarMenor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMayor
            // 
            btnEliminarMayor.Location = new Point(22, 50);
            btnEliminarMayor.Name = "btnEliminarMayor";
            btnEliminarMayor.Size = new Size(99, 23);
            btnEliminarMayor.TabIndex = 6;
            btnEliminarMayor.Text = "Eliminar Mayor";
            btnEliminarMayor.UseVisualStyleBackColor = true;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(127, 79);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(75, 23);
            btnPromedio.TabIndex = 7;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 20);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 8;
            label2.Text = "Promedio:";
            // 
            // FrmCalificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 303);
            Controls.Add(label2);
            Controls.Add(btnPromedio);
            Controls.Add(btnEliminarMayor);
            Controls.Add(btnEliminarMenor);
            Controls.Add(btnAgregar);
            Controls.Add(lblPromedio);
            Controls.Add(lstNotas);
            Controls.Add(txtNota);
            Controls.Add(label1);
            Name = "FrmCalificaciones";
            Text = "FrmCalificaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNota;
        private ListBox lstNotas;
        private Label lblPromedio;
        private Button btnAgregar;
        private Button btnEliminarMenor;
        private Button btnEliminarMayor;
        private Button btnPromedio;
        private Label label2;
    }
}