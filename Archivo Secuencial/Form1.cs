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
            ConfigurarDataGridViews();
        }

        private void ConfigurarDataGridViews()
        {
            // Configurar dgvDatos
            dgvDatos.AllowUserToAddRows = true;
            dgvDatos.AllowUserToDeleteRows = true;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            if (dgvDatos.Columns.Count == 0)
            {
                dgvDatos.Columns.Add("Datos", "Datos");
            }

            // Configurar dgvPropiedades
            dgvPropiedades.AllowUserToAddRows = false;
            dgvPropiedades.AllowUserToDeleteRows = false;
            dgvPropiedades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            if (dgvPropiedades.Columns.Count == 0)
            {
                dgvPropiedades.Columns.Add("Propiedad", "Propiedad");
                dgvPropiedades.Columns.Add("Valor", "Valor");
            }
        }

        private void CrearArchivo()
        {
            try
            {
                if (dgvDatos.Rows.Count == 0 || string.IsNullOrWhiteSpace(dgvDatos.Rows[0].Cells[0].Value?.ToString()))
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

                    string contenido = ObtenerContenidoDesdeDataGridView();
                    File.WriteAllText(rutaArchivo, contenido);
                    MessageBox.Show("Archivo creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDatos.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerContenidoDesdeDataGridView()
        {
            string contenido = "";
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                if (!row.IsNewRow)
                {
                    contenido += row.Cells[0].Value?.ToString() + Environment.NewLine;
                }
            }
            return contenido;
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
                DialogResult resultado = MessageBox.Show("¿Desea eliminarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show($"Error al copiar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                dgvPropiedades.Rows.Clear();
                dgvPropiedades.Rows.Add("Tamaño", info.Length + " bytes");
                dgvPropiedades.Rows.Add("Nombre", info.Name);
                dgvPropiedades.Rows.Add("Fecha de creación", info.CreationTime.ToString());
                dgvPropiedades.Rows.Add("Extensión", info.Extension);
                dgvPropiedades.Rows.Add("Último acceso", info.LastAccessTime.ToString());
                dgvPropiedades.Rows.Add("Última modificación", info.LastWriteTime.ToString());
                dgvPropiedades.Rows.Add("Atributos", info.Attributes.ToString());
                dgvPropiedades.Rows.Add("Ubicación", info.FullName);
                dgvPropiedades.Rows.Add("Carpeta contenedora", info.DirectoryName);
            }
        }
    }
}
