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
            textBoxDatos = new TextBox();
            labelDatos = new Label();
            btnEliminar = new Button();
            btnCopiar = new Button();
            btnVerPropiedades = new Button();
            txtPropiedades = new TextBox();
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
            // textBoxDatos
            // 
            textBoxDatos.Location = new Point(12, 35);
            textBoxDatos.Multiline = true;
            textBoxDatos.Name = "textBoxDatos";
            textBoxDatos.Size = new Size(776, 380);
            textBoxDatos.TabIndex = 1;
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
            // txtPropiedades
            // 
            txtPropiedades.Location = new Point(825, 35);
            txtPropiedades.Multiline = true;
            txtPropiedades.Name = "txtPropiedades";
            txtPropiedades.Size = new Size(380, 380);
            txtPropiedades.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 621);
            Controls.Add(txtPropiedades);
            Controls.Add(btnVerPropiedades);
            Controls.Add(btnCopiar);
            Controls.Add(btnEliminar);
            Controls.Add(BtnMoverArchivo);
            Controls.Add(BtnCrearArchivo);
            Controls.Add(textBoxDatos);
            Controls.Add(labelDatos);
            Name = "Form1";
            Text = "Archivos Secuenciales";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCrearArchivo;
        private Button BtnMoverArchivo;
        private TextBox textBoxDatos;
        private Label labelDatos;
        private Button btnEliminar;
        private Button btnCopiar;
        private Button btnVerPropiedades;
        private TextBox txtPropiedades;
    }
}
