namespace Archivo_Secuencial
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
        ///  the contents of this method by the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCrearArchivo = new Button();
            BtnMoverArchivo = new Button();
            labelDatos = new Label();
            btnEliminar = new Button();
            btnCopiar = new Button();
            btnVerPropiedades = new Button();
            dgvDatos = new DataGridView();
            dgvPropiedades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).BeginInit();
            SuspendLayout();
            // 
            // BtnCrearArchivo
            // 
            BtnCrearArchivo.Location = new Point(650, 421);
            BtnCrearArchivo.Name = "BtnCrearArchivo";
            BtnCrearArchivo.Size = new Size(138, 29);
            BtnCrearArchivo.TabIndex = 2;
            BtnCrearArchivo.Text = "Crear Archivo";
            BtnCrearArchivo.UseVisualStyleBackColor = true;
            BtnCrearArchivo.Click += BtnCrearArchivo_click;
            // 
            // BtnMoverArchivo
            // 
            BtnMoverArchivo.Location = new Point(489, 421);
            BtnMoverArchivo.Name = "BtnMoverArchivo";
            BtnMoverArchivo.Size = new Size(155, 29);
            BtnMoverArchivo.TabIndex = 3;
            BtnMoverArchivo.Text = "Mover Archivo";
            BtnMoverArchivo.UseVisualStyleBackColor = true;
            BtnMoverArchivo.Click += BtnMoverArchivo_Click;
            // 
            // labelDatos
            // 
            labelDatos.AutoSize = true;
            labelDatos.Location = new Point(12, 12);
            labelDatos.Name = "labelDatos";
            labelDatos.Size = new Size(123, 20);
            labelDatos.TabIndex = 0;
            labelDatos.Text = "Escriba los datos:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(337, 421);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(146, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(185, 421);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(146, 29);
            btnCopiar.TabIndex = 5;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnVerPropiedades
            // 
            btnVerPropiedades.Location = new Point(33, 421);
            btnVerPropiedades.Name = "btnVerPropiedades";
            btnVerPropiedades.Size = new Size(146, 29);
            btnVerPropiedades.TabIndex = 6;
            btnVerPropiedades.Text = "ver propiedades";
            btnVerPropiedades.UseVisualStyleBackColor = true;
            btnVerPropiedades.Click += btnVerPropiedades_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(12, 35);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(868, 380);
            dgvDatos.TabIndex = 8;
            // 
            // dgvPropiedades
            // 
            dgvPropiedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropiedades.Location = new Point(930, 35);
            dgvPropiedades.Name = "dgvPropiedades";
            dgvPropiedades.RowHeadersWidth = 51;
            dgvPropiedades.Size = new Size(484, 380);
            dgvPropiedades.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1726, 724);
            Controls.Add(dgvPropiedades);
            Controls.Add(dgvDatos);
            Controls.Add(btnVerPropiedades);
            Controls.Add(btnCopiar);
            Controls.Add(btnEliminar);
            Controls.Add(BtnMoverArchivo);
            Controls.Add(BtnCrearArchivo);
            Controls.Add(labelDatos);
            Name = "Form1";
            Text = "Archivos Secuenciales";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCrearArchivo;
        private Button BtnMoverArchivo;
        private Label labelDatos;
        private Button btnEliminar;
        private Button btnCopiar;
        private Button btnVerPropiedades;
        private DataGridView dgvDatos;
        private DataGridView dgvPropiedades;
    }
}
