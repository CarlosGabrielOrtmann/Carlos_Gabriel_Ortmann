namespace TPIntegradorParte2
{
    partial class FrmPlaylist
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
            txtCancion = new TextBox();
            btnAgregar = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnEliminar = new Button();
            lstCanciones = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Canción";
            // 
            // txtCancion
            // 
            txtCancion.Location = new Point(82, 21);
            txtCancion.Name = "txtCancion";
            txtCancion.Size = new Size(100, 23);
            txtCancion.TabIndex = 1;
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
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(93, 64);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(174, 64);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 4;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(255, 64);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstCanciones
            // 
            lstCanciones.FormattingEnabled = true;
            lstCanciones.ItemHeight = 15;
            lstCanciones.Location = new Point(12, 108);
            lstCanciones.Name = "lstCanciones";
            lstCanciones.Size = new Size(359, 139);
            lstCanciones.TabIndex = 6;
            // 
            // FrmPlaylist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 255);
            Controls.Add(lstCanciones);
            Controls.Add(btnEliminar);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAgregar);
            Controls.Add(txtCancion);
            Controls.Add(label1);
            Name = "FrmPlaylist";
            Text = "FrmPlaylist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCancion;
        private Button btnAgregar;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnEliminar;
        private ListBox lstCanciones;
    }
}