namespace WinFormsApp2
{
    partial class frmEjercicio01
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
            lblTituloEjercicio = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            btnAceptar = new Button();
            btnSalir = new Button();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblSalida = new Label();
            SuspendLayout();
            // 
            // lblTituloEjercicio
            // 
            lblTituloEjercicio.AutoSize = true;
            lblTituloEjercicio.Location = new Point(12, 9);
            lblTituloEjercicio.Name = "lblTituloEjercicio";
            lblTituloEjercicio.Size = new Size(60, 15);
            lblTituloEjercicio.TabIndex = 0;
            lblTituloEjercicio.Text = "Ejercicio 1";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(12, 62);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(161, 146);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(272, 146);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(72, 58);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(72, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Location = new Point(242, 224);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(38, 15);
            lblSalida.TabIndex = 7;
            lblSalida.Text = "label1";
            // 
            // frmEjercicio01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSalida);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(btnSalir);
            Controls.Add(btnAceptar);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTituloEjercicio);
            Name = "frmEjercicio01";
            Text = "Ejercicio 1 - Escritorio 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloEjercicio;
        private Label lblNombre;
        private Label lblApellido;
        private Button btnAceptar;
        private Button btnSalir;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblSalida;
    }
}
