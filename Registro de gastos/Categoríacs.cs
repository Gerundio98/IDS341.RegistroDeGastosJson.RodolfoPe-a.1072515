using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Registro_de_gastos
{
    public partial class Categoríacs : Form
    {
        int a = 1;
        int b = 1;
        List<clssCategoría> categoríaList = new List<clssCategoría>();
        DateTime FechaLabel = DateTime.Now;

        public Categoríacs()
        {
            InitializeComponent();
            lblFecha.Text =FechaLabel.ToString();
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Categorías.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                categoríaList = JsonConvert.DeserializeObject<List<clssCategoría>>(json);
                dgvCategoría.DataSource = categoríaList;
            }
        }
        private void BorradoCamposRellenables()
        {
            txtbNombre.Text = string.Empty;
            txtbDescripcion.Text = string.Empty;
            txtbID.Text = string.Empty;
        }
        private void HabilitarBotones(int b)
        {
            if (b == 1)
            {
                bttnGuardar.Enabled = true;
                b = 0;
            }
            else
            {
                bttnGuardar.Enabled = false;
                b = 1;
            }

        }
        public class clssCategoría
        {
            public Guid ID { get; set; }
            public string Nombre { get; set; }
            public string Descripción { get; set; }
            public DateTime Fecha_de_creación { get; set; }
            public bool Visibilidad { get; set; }
        }
        public void Editar_Guardar()
        {
            int j=0;
            var vCategoría = new clssCategoría()
            {
                ID = Guid.NewGuid(),
                Nombre = txtbNombre.Text,
                Descripción = txtbDescripcion.Text,
                Fecha_de_creación = DateTime.Now,
                Visibilidad = false,
            };
            if (chbVisibilidad.Checked==true)
            {
                vCategoría = new clssCategoría()
                {
                    ID = Guid.NewGuid(),
                    Nombre = txtbNombre.Text,
                    Descripción = txtbDescripcion.Text,
                    Fecha_de_creación = DateTime.Now,
                    Visibilidad = true,
                };
            }
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Categorías.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                categoríaList = JsonConvert.DeserializeObject<List<clssCategoría>>(json);
                dgvCategoría.DataSource = categoríaList;
                for (int i = 0; i < categoríaList.Count; i++)
                {
                    if (categoríaList[i].Nombre == vCategoría.Nombre)
                    {
                        categoríaList.Remove(categoríaList[i]);
                        categoríaList.Add(vCategoría);
                        MessageBox.Show($"El categoría {txtbNombre.Text} fue encontrado y actualizado.");
                        j = 1;
                        break;
                    }
                }
                if (j == 0) {
                    categoríaList.Add(vCategoría);
                    MessageBox.Show($"El categoría {txtbNombre.Text} agregado correctamente.");
                }

            }
            else
            {
                categoríaList.Add(vCategoría);
                MessageBox.Show($"El categoría {txtbNombre.Text} agregado correctamente.");
            }
            json = JsonConvert.SerializeObject(categoríaList);
            var sv = new StreamWriter(pathFile, false, Encoding.UTF8);
            sv.Write(json);
            sv.Close();
            dgvCategoría.DataSource = null;
            dgvCategoría.DataSource = categoríaList;
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarBotones(b);

        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            b = 0;
            a = 0;
            BorradoCamposRellenables();
            HabilitarBotones(b);

        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Categorías.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                categoríaList = JsonConvert.DeserializeObject<List<clssCategoría>>(json);
                dgvCategoría.DataSource = categoríaList;
                for (int i = 0; i < categoríaList.Count; i++)
                {
                    if (categoríaList[i].Nombre == txtbNombre.Text.ToString())
                    {
                        bttnEliminar.Enabled = true;
                        txtbNombre.Text = categoríaList[i].Nombre.ToString();
                        txtbDescripcion.Text = categoríaList[i].Descripción.ToString();
                        txtbID.Text = categoríaList[i].ID.ToString();
                        chbVisibilidad.Checked = categoríaList[i].Visibilidad;
                        break;
                    }
                }
                MessageBox.Show($"El categoría referenciado como {txtbNombre.Text}, No existe");
            }
            else
            {
                MessageBox.Show($"Aún no ha ingresado ningun dato.");
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Categorías.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                categoríaList = JsonConvert.DeserializeObject<List<clssCategoría>>(json);
                for (int j = 0; j < categoríaList.Count; j++)
                {
                    if (categoríaList[j].Nombre == txtbNombre.Text)
                    {
                        categoríaList.Remove(categoríaList[j]);
                        MessageBox.Show($"El categoría {txtbNombre.Text} fue eliminado correctamente.");
                        break;
                    }
                }
                MessageBox.Show($"No existe ningun categoría con el nombre de {txtbNombre.Text} que coincida en la lista.");
            }
            else
            {
                MessageBox.Show($"Aún no se han ingresado categorías.");
            }
            json = JsonConvert.SerializeObject(categoríaList);
            var sv = new StreamWriter(pathFile, false, Encoding.UTF8);
            sv.Write(json);
            sv.Close();
            dgvCategoría.DataSource = categoríaList;
            bttnEliminar.Enabled = false;
            BorradoCamposRellenables();

        }

        private void bttnGuardar_Click_1(object sender, EventArgs e)
        {
            Editar_Guardar();
            BorradoCamposRellenables();
            HabilitarBotones(b);
        }

        private void Categoríacs_Load(object sender, EventArgs e)
        {

        }
    }
}
