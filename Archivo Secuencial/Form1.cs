using System.IO;

namespace Archivo_Secuencial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CrearArchivo()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxDatos.Text))
                {
                    MessageBox.Show("Por favor, escriba algo antes de crear el archivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv|Archivos de datos (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
                saveFileDialog1.Title = "Guardar archivo";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveFileDialog1.FileName;

                    if (File.Exists(rutaArchivo))
                    {
                        DialogResult resultado = MessageBox.Show("El archivo ya existe. ¿Desea reemplazarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.No)
                        {
                            return;
                        }
                    }

                    File.WriteAllText(rutaArchivo, textBoxDatos.Text);
                    MessageBox.Show("Archivo creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxDatos.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MoverArchivo()
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv|Archivos de datos (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
                openFileDialog1.Title = "Seleccionar archivo a mover";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string rutaOrigen = openFileDialog1.FileName;

                    FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                    folderBrowserDialog1.Description = "Seleccione la carpeta de destino";
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string carpetaDestino = folderBrowserDialog1.SelectedPath;
                        string nombreArchivo = Path.GetFileName(rutaOrigen);
                        string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                        if (File.Exists(rutaDestino))
                        {
                            DialogResult resultado = MessageBox.Show("El archivo ya existe en la carpeta de destino. ¿Desea reemplazarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (resultado == DialogResult.No)
                            {
                                return;
                            }
                            File.Delete(rutaDestino);
                        }

                        File.Move(rutaOrigen, rutaDestino);
                        MessageBox.Show("Archivo movido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mover el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void BtnCrearArchivo_click(object sender, EventArgs e)
        {
            CrearArchivo();
        }

        private void BtnMoverArchivo_Click(object sender, EventArgs e)
        {
            MoverArchivo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool flowControl = Eliminar();
            if (!flowControl)
            {
                return;
            }
        }

        private static bool Eliminar()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filepath = ofd.FileName;
                DialogResult resultado = MessageBox.Show(" ¿Desea eliminarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return false;
                }

                File.Delete(filepath);
            }

            return true;
        }


        private void CopiarArchivo()
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv|Archivos de datos (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
                openFileDialog1.Title = "Seleccionar archivo a copiar";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string rutaOrigen = openFileDialog1.FileName;

                    FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                    folderBrowserDialog1.Description = "Seleccione la carpeta de destino";
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string carpetaDestino = folderBrowserDialog1.SelectedPath;
                        string nombreArchivo = Path.GetFileName(rutaOrigen);
                        string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                        if (File.Exists(rutaDestino))
                        {
                            DialogResult resultado = MessageBox.Show("El archivo ya existe en la carpeta de destino. ¿Desea reemplazarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (resultado == DialogResult.No)
                            {
                                return;
                            }
                            File.Delete(rutaDestino);
                        }

                        File.Copy(rutaOrigen, rutaDestino);
                        MessageBox.Show("Archivo copiado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mover el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            CopiarArchivo();

        }

        private void btnVerPropiedades_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv|Archivos de datos (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
            openFileDialog1.Title = "Seleccionar archivo ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaOrigen = openFileDialog1.FileName;
                
                FileInfo info = new FileInfo(rutaOrigen);
                
               txtPropiedades.Text = info.Length + " bytes " + Environment.NewLine;
               txtPropiedades.Text += " Nombre " + info.Name +Environment.NewLine ;
               txtPropiedades.Text += " fecha de creacion " + info.CreationTime.ToString() + Environment.NewLine;
               txtPropiedades.Text += " extension " + info.Extension + Environment.NewLine;
               txtPropiedades.Text += " Ultimo acceso " + info.LastAccessTime.ToString() + Environment.NewLine;
               txtPropiedades.Text += " Ultima modificacion " + info.LastWriteTime + Environment.NewLine;

            }
        }
    }
}
