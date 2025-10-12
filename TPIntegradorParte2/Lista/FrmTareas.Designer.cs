namespace TPIntegradorParte2
{
    partial class FrmTareas
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
            txtTarea = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            lstTareas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Nueva Tarea";
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(89, 20);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(100, 23);
            txtTarea.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 58);
            btnAgregar.Name = "btnEnviar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(146, 58);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(14, 87);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(209, 184);
            lstTareas.TabIndex = 4;
            // 
            // FrmTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 278);
            Controls.Add(lstTareas);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTarea);
            Controls.Add(label1);
            Name = "FrmTareas";
            Text = "FrmTareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTarea;
        private Button btnAgregar;
        private Button btnEliminar;
        private ListBox lstTareas;
    }
}