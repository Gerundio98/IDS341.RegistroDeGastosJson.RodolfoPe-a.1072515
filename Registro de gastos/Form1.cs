using System.Text;
using Newtonsoft.Json;

namespace Registro_de_gastos
{
    public partial class Form1 : Form
    {
        int a = 1;
        int b = 1;
        List<clssGasto> gastoList = new List<clssGasto>();
        List<clssConcepto> conceptoList = new List<clssConcepto>();
        List<clssCategoría> categoríaList = new List<clssCategoría>();
        DateTime FechaLabel = DateTime.Now;
        
        public Form1()
        {
            InitializeComponent();
            int SumaGasto=0;
            lblFecha.Text = FechaLabel.ToString();
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Gastos.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                gastoList = JsonConvert.DeserializeObject<List<clssGasto>>(json);
                dgvGasto.DataSource = gastoList;
                for (int i = 0; i < gastoList.Count; i++)
                {
                    SumaGasto =SumaGasto+gastoList[i].Gasto;
                }
                txtbTotalGasto.Text = SumaGasto.ToString();
            }
            var auxList = new List<string> { };
                json = string.Empty;
                pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Categorías.json";
                if (File.Exists(pathFile))
                {
                    json = File.ReadAllText(pathFile, Encoding.UTF8);
                    categoríaList = JsonConvert.DeserializeObject<List<clssCategoría>>(json);
                    for (int i = 0; i < categoríaList.Count; i++)
                    {
                        if (categoríaList[i].Visibilidad == true)
                        {
                            auxList.Add(categoríaList[i].Nombre);
                        }
                    }
                }
                cbCategoría.DataSource = auxList;

                auxList = new List<string> { };
                json = string.Empty;
                pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Conceptos.json";
                if (File.Exists(pathFile))
                {
                    json = File.ReadAllText(pathFile, Encoding.UTF8);
                    conceptoList = JsonConvert.DeserializeObject<List<clssConcepto>>(json);
                    for (int i = 0; i < conceptoList.Count; i++)
                    {
                        if (conceptoList[i].Visibilidad == true)
                        {
                            auxList.Add(conceptoList[i].Nombre);
                        }
                    }
                }
                cbConcepto.DataSource = auxList;

            }
            private void BorradoCamposRellenables()
        {
            txtbCantidad.Text = string.Empty;
            cbCategoría.SelectedItem=null;
            cbConcepto.SelectedItem = null;
            dtpFecha.Text=string.Empty;
            txtbID.Text = string.Empty;
            txtbMonto.Text = string.Empty;
            txtbNombreDelGasto.Text = string.Empty;
        }
        public class clssGasto
        {
            public Guid ID { get; set; }
            public string Nombre { get; set; }
            public string Concepto { get; set; }
            public string Categoría { get; set; }
            public DateTime Fecha { get; set; }
            public int Cantidad { get; set; }
            public int Monto { get; set; }
            public int Gasto { get; set; }

        }
        public void Editar_Guardar()
        {
            int SumaGasto = 0;
            int j = 0;
            var vGasto = new clssGasto()
            {
                Concepto = cbConcepto.SelectedItem.ToString(),
                Categoría = cbCategoría.SelectedItem.ToString(),
                Fecha = dtpFecha.Value,
                Cantidad = int.Parse(txtbCantidad.Text),
                Monto = int.Parse(txtbMonto.Text),
                Gasto = int.Parse(txtbCantidad.Text) * int.Parse(txtbMonto.Text),
                Nombre = txtbNombreDelGasto.Text,
            };
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Gastos.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                gastoList = JsonConvert.DeserializeObject<List<clssGasto>>(json);
                for (int i = 0; i < gastoList.Count; i++)
                {
                    if (gastoList[i].Nombre == vGasto.Nombre)
                    {
                        gastoList.Remove(gastoList[i]);
                        gastoList.Add(vGasto);
                        MessageBox.Show($"El gasto {txtbNombreDelGasto.Text} fue encontrado y actualizado.");
                        j = 1;
                        break;
                    }
                }
                if (j == 0)
                {
                    gastoList.Add(vGasto);
                    MessageBox.Show($"El gasto {txtbNombreDelGasto.Text} agregado correctamente.");

                }
            }
            else
            {
                gastoList.Add(vGasto);
                MessageBox.Show($"El gasto {txtbNombreDelGasto.Text} agregado correctamente.");
            }
            json = JsonConvert.SerializeObject(gastoList);
            var sv = new StreamWriter(pathFile, false, Encoding.UTF8);
            sv.Write(json);
            sv.Close();
            dgvGasto.DataSource = null;
            dgvGasto.DataSource = gastoList;
            for (int i = 0; i < gastoList.Count; i++)
            {
                SumaGasto = SumaGasto + gastoList[i].Gasto;
            }
            txtbTotalGasto.Text = SumaGasto.ToString();

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnConcepto_Click(object sender, EventArgs e)
        {
            var oForm = new Concepto();
            oForm.Show();
        }
        private void btnCategoría_Click(object sender, EventArgs e)
        {
            var oForm = new Categoríacs();
            oForm.Show();
        }
        private void bttnAgregar_Click(object sender, EventArgs e)
        {

        }
        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            Editar_Guardar();
            BorradoCamposRellenables();
        }
        class clssConcepto
        {
            public Guid ID { get; set; }
            public string Nombre { get; set; }
            public string Descripción { get; set; }
            public DateTime Fecha_de_creación { get; set; }
            public bool Visibilidad { get; set; }
        }
        private void cbConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbCategoría_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbConcepto_Click(object sender, EventArgs e)
        {
        }
        public class clssCategoría
        {
            public Guid ID { get; set; }
            public string Nombre { get; set; }
            public string Descripción { get; set; }
            public DateTime Fecha_de_creación { get; set; }
            public bool Visibilidad { get; set; }
        }
        private void cbCategoría_Click(object sender, EventArgs e)
        {
        }
        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            int j = 0;
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Gastos.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                gastoList = JsonConvert.DeserializeObject<List<clssGasto>>(json);
                dgvGasto.DataSource = gastoList;
                for (int i = 0; i < gastoList.Count; i++)
                {
                    if (gastoList[i].Nombre.ToString() == txtbNombreDelGasto.Text)
                    {
                        bttnEliminar.Enabled = true;
                        cbConcepto.SelectedItem = gastoList[i].Concepto.ToString();
                        cbCategoría.SelectedItem = gastoList[i].Categoría.ToString();
                        dtpFecha.Value = gastoList[i].Fecha;
                        txtbCantidad.Text = gastoList[i].Cantidad.ToString();
                        txtbMonto.Text = gastoList[i].Monto.ToString();
                        txtbID.Text = gastoList[i].ID.ToString();
                        txtbNombreDelGasto.Text = gastoList[i].Nombre.ToString();
                        j = 1;
                        break;
                    }
                }
                if(j == 0)
                {
                    MessageBox.Show($"El gasto referenciado como {txtbNombreDelGasto.Text}, No existe");
                }
            }
            else
            {
                MessageBox.Show($"Aún no ha ingresado ningun dato.");
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            int j = 0;
            int SumaGasto = 0;
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Gastos.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                gastoList = JsonConvert.DeserializeObject<List<clssGasto>>(json);
                for (int i = 0; i < gastoList.Count; i++)
                {
                    if (gastoList[j].Nombre.ToString() == txtbNombreDelGasto.Text)
                    {
                        gastoList.Remove(gastoList[i]);
                        MessageBox.Show($"El gasto {txtbNombreDelGasto.Text} fue eliminado correctamente.");
                        break;
                        j = 1;
                    }
                }
                if (j == 0)
                {
                    MessageBox.Show($"No existe ningun gasto con el nombre de {txtbNombreDelGasto.Text} que coincida en la lista.");
                }
            }
            else
            {
                MessageBox.Show($"Aún no se han ingresado gastos.");
            }
            json = JsonConvert.SerializeObject(gastoList);
            var sv = new StreamWriter(pathFile, false, Encoding.UTF8);
            sv.Write(json);
            sv.Close();
            dgvGasto.DataSource = null;
            dgvGasto.DataSource = gastoList;
            bttnEliminar.Enabled = false;
            for (int i = 0; i < gastoList.Count; i++)
            {
                SumaGasto = SumaGasto + gastoList[i].Gasto;
            }
            txtbTotalGasto.Text = SumaGasto.ToString();
            BorradoCamposRellenables();
        }

        private void txtbTotalGasto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
