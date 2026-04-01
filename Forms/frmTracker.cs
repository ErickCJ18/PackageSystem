using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Paqueteria
{
    public partial class frmTracker : Form
    {
        string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "package_system.json");

        public frmTracker()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == string.Empty)
            {
                MessageBox.Show("Ingresa un código de paquete.");
                return;
            }

            string json = File.ReadAllText(ruta);
            var root = JsonConvert.DeserializeObject<RootData>(json) ?? new RootData();

            if (root.packages == null || !root.packages.ContainsKey(tbCodigo.Text.Trim()))
            {
                MessageBox.Show("Paquete no encontrado.");
                return;
            }

            Package p = root.packages[tbCodigo.Text.Trim()];

            lblCodigo.Text = p.P_code.ToString();
            lblContenido.Text = p.P_content;
            lblTermino.Text = p.P_term;
            TimeSpan tiempoFaltante = p.P_ETA - DateTime.Now;

            if (tiempoFaltante.TotalDays > 0)
            {
                lblETA.Text = $"{(int)tiempoFaltante.TotalDays} días, {tiempoFaltante.Hours} horas restantes";
            }
            else
            {
                lblETA.Text = "El paquete ya debió haber llegado";
            }
            lblPeso.Text = p.P_weight.ToString() + " lbs";
            lblBalance.Text = "$" + p.P_cost.ToString("F2");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
