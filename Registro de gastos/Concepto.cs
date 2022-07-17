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

    public partial class Concepto : Form
    {
        int a = 1;
        int b = 1;
        List<clssConcepto> conceptoList = new List<clssConcepto>();
        DateTime FechaLabel = DateTime.Now;
      
        public Concepto()
        {
            InitializeComponent();
            lblFecha.Text = FechaLabel.ToString();
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Conceptos.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptoList = JsonConvert.DeserializeObject<List<clssConcepto>>(json);
                dgvConcepto.DataSource = conceptoList;
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
                b= 0;
            }
            else
            {
                bttnGuardar.Enabled = false;
                b= 1;
            }

        }
        public class clssConcepto
        {
            public Guid ID { get; set; }
            public string Nombre { get; set; }
            public string Descripción { get; set; }
            public DateTime Fecha_de_creación  { get; set; }
            public bool Visibilidad { get; set; }
        }

        public void Editar_Guardar()
        {
            var vConcepto = new clssConcepto()
            {
                ID = Guid.NewGuid(),
                Nombre = txtbNombre.Text,
                Descripción = txtbDescripcion.Text,
                Fecha_de_creación = DateTime.Now,
                Visibilidad = false,
            };
            if (chbVisibilidad.Checked == true)
            {
                vConcepto= new clssConcepto()
                {
                    ID = Guid.NewGuid(),
                    Nombre = txtbNombre.Text,
                    Descripción = txtbDescripcion.Text,
                    Fecha_de_creación = DateTime.Now,
                    Visibilidad = true,
                };
            }
            int j = 0;
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Conceptos.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptoList = JsonConvert.DeserializeObject<List<clssConcepto>>(json);
                dgvConcepto.DataSource = conceptoList;
                for (int i = 0; i < conceptoList.Count; i++)
                {
                    if (conceptoList[i].Nombre == vConcepto.Nombre)
                    {
                        conceptoList.Remove(conceptoList[i]);
                        conceptoList.Add(vConcepto);
                        j = 1;
                        MessageBox.Show($"El concepto {txtbNombre.Text} fue encontrado y actualizado.");
                        break;
                    }
                }
                if (j == 0)
                {
                    conceptoList.Add(vConcepto);
                    MessageBox.Show($"El concepto {txtbNombre.Text} agregado correctamente.");

                }
            }
            else
            {
                conceptoList.Add(vConcepto);
                MessageBox.Show($"El concepto {txtbNombre.Text} agregado correctamente.");

            }
            json = JsonConvert.SerializeObject(conceptoList);
            var sv = new StreamWriter(pathFile, false, Encoding.UTF8);
            sv.Write(json);
            sv.Close();
            dgvConcepto.DataSource = null;
            dgvConcepto.DataSource = conceptoList;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Editar_Guardar();
            BorradoCamposRellenables();
            HabilitarBotones(b);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(b);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            b = 0;
            a = 0;
            BorradoCamposRellenables();
            HabilitarBotones(b);
            var oForm = new Form1();
            oForm.Show();
            this.Close();

        }

        private void lblCreatedDate_Click(object sender, EventArgs e)
        {

        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {

            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Conceptos.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptoList = JsonConvert.DeserializeObject<List<clssConcepto>>(json);
                dgvConcepto.DataSource = conceptoList;
                for (int i = 0; i < conceptoList.Count; i++)
                {
                    if (conceptoList[i].Nombre == txtbNombre.Text.ToString())
                    {
                        bttnEliminar.Enabled = true;
                        txtbNombre.Text = conceptoList[i].Nombre.ToString();
                        txtbDescripcion.Text = conceptoList[i].Descripción.ToString();
                        txtbID.Text = conceptoList[i].ID.ToString();
                        chbVisibilidad.Checked = conceptoList[i].Visibilidad;
                        break;
                    }
                }
                MessageBox.Show($"El concepto referenciado como {txtbNombre.Text}, No existe");
            }
            else
            {
                MessageBox.Show($"Aún no ha ingresado ningun dato.");
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Conceptos.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptoList = JsonConvert.DeserializeObject<List<clssConcepto>>(json);
                for (int j = 0; j < conceptoList.Count; j++)
                {
                    if (conceptoList[j].Nombre == txtbNombre.Text)
                    {
                        conceptoList.Remove(conceptoList[j]);
                        MessageBox.Show($"El concepto {txtbNombre} fue eliminado correctamente.");
                        break;
                    }
                }
                MessageBox.Show($"No existe ningun concepto con el nombre de {txtbNombre.Text} que coincida en la lista.");
            }
            else
            {
                MessageBox.Show($"Aún no se han ingresado conceptos.");
            }
            json = JsonConvert.SerializeObject(conceptoList);
            var sv = new StreamWriter(pathFile, false, Encoding.UTF8);
            sv.Write(json);
            sv.Close();
            dgvConcepto.DataSource = conceptoList;
            bttnEliminar.Enabled = false;
            BorradoCamposRellenables();
        }
    }
}
