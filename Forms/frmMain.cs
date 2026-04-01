using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Sistema_de_Paqueteria
{
    public partial class frmMain : Form
    {

        string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "package_system.json");
        bool packageEditing = false;
        public frmMain()
        {
            InitializeComponent();
            turnOffPanel();
            // pequeño check de seguridad
            if (File.Exists(ruta))
            {
                refreshDGV();
            }
            else
            {
                var root = new RootData();
                string json = JsonConvert.SerializeObject(root, Formatting.Indented);
                File.WriteAllText(ruta, json);
            }

            // llenado del comboBox de "Termino"
            string[] termTypes = { "Embarcado", "Recibido", "Transito", "Disponible", "Entregado" };
            for (int i = 0; i < termTypes.Length; i++) 
            {
                cbTerm.Items.Add(termTypes[i]);
            }
        }

        private void turnOffPanel()
        {
            foreach (Control ctrl in pnManager.Controls)
            {
                ctrl.Enabled = false;
            }
        }

        private void turnOnPanel()
        {
            foreach (Control ctrl in pnManager.Controls)
            {
                ctrl.Enabled = true;
            }
        }

        // Estilo para el datagridview
        private void DataGridViewStyling()
        {
            gridView.Columns["P_code"].HeaderText = "Código";
            gridView.Columns["P_term"].HeaderText = "Término";
            gridView.Columns["P_ETA"].HeaderText = "Llegada Aproximada";
            gridView.Columns["P_content"].HeaderText = "Contenido";
            gridView.Columns["P_weight"].HeaderText = "Peso";
            gridView.Columns["P_vol"].HeaderText = "Vol.";
            gridView.Columns["P_cost"].HeaderText = "Balance";
            gridView.Columns["P_ETA"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // Filtro de busqueda que funciona por Codigo de paquete o su contenido
        private void tbFilter_OnValueChanged(object sender, EventArgs e)
        {
            refreshDGV(tbFilter.Text.Trim());
        }   

        //////////////////////
        //       CRUD       //
        //////////////////////

        // Actualiza el dataGridView
        private void refreshDGV(string filtro = "") 
        {
            gridView.DataSource = readPackages(filtro);
            DataGridViewStyling();
        }

        // Lee el JSON de paquetes y los retorna al DataGridView
        private List<Package> readPackages(string filtro = "")
        {
            string json = File.ReadAllText(ruta);
            var root = JsonConvert.DeserializeObject<RootData>(json) ?? new RootData();

            if (root.packages == null)
                root.packages = new Dictionary<string, Package>();

            var lista = root.packages.Values.ToList();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                lista = lista.Where(p =>
                    p.P_code.ToString().Contains(filtro) ||
                    p.P_content.ToLower().Contains(filtro.ToLower())
                ).ToList();
            }

            return lista;
        }

        //////////////////////
        //     BUTTONS      //
        //////////////////////
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            turnOnPanel();
            cbTerm.SelectedIndex = 0;
            tbCode.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbTerm.SelectedIndex = -1;
            emptyOffPanel();
            turnOffPanel();
        }

        private void emptyOffPanel() 
        {
            foreach (Control ctrl in pnManager.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear(); // o textBox.Text = "";
                }
            }
            dtp.Value = DateTime.Now;
            cbTerm.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbTerm.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un término");
                return;
            }
            savePackage();
        }

        private void savePackage()
        {
            Package newPackage = new Package()
            {
                P_code = int.Parse(tbCode.Text),
                P_content = tbContent.Text,
                P_term = cbTerm.SelectedItem.ToString(),
                P_ETA = dtp.Value,
                P_weight = float.Parse(tbWeight.Text),
                P_vol = float.Parse(tbVol.Text),
                P_cost = float.Parse(tbWeight.Text) * 189
            };

            string json = File.ReadAllText(ruta);
            var root = JsonConvert.DeserializeObject<RootData>(json) ?? new RootData();

            if (root.packages == null)
                root.packages = new Dictionary<string, Package>();

            string key = newPackage.P_code.ToString();

            if (packageEditing)
            {
                if (root.packages.ContainsKey(key))
                    root.packages[key] = newPackage;

                MessageBox.Show("Paquete editado!");
            }
            else
            {
                if (root.packages.ContainsKey(key))
                {
                    MessageBox.Show("YA HAY UN PAQUETE CON ESE CODIGO!");
                    return;
                }

                root.packages.Add(key, newPackage);
                MessageBox.Show("Paquete guardado!");
            }

            string updatedJson = JsonConvert.SerializeObject(root, Formatting.Indented);
            File.WriteAllText(ruta, updatedJson);

            packageEditing = false;
            refreshDGV();
            emptyOffPanel();
        }


        // FINISHHH THIIIIIIIIS
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                turnOnPanel();
                packageEditing = true;
                int code = int.Parse(gridView.SelectedRows[0].Cells["P_Code"].Value.ToString());
                string term = gridView.SelectedRows[0].Cells["P_term"].Value.ToString();
                //----------
                tbCode.Text = code.ToString();
                cbTerm.SelectedIndex = cbTerm.Items.IndexOf(term);
                dtp.Value = DateTime.Parse(gridView.SelectedRows[0].Cells["P_ETA"].Value.ToString());
                tbContent.Text = gridView.SelectedRows[0].Cells["P_Content"].Value.ToString();
                tbWeight.Text = gridView.SelectedRows[0].Cells["P_Weight"].Value.ToString();
                tbVol.Text = gridView.SelectedRows[0].Cells["P_Vol"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                string key = gridView.SelectedRows[0].Cells["P_Code"].Value.ToString();

                string json = File.ReadAllText(ruta);
                var root = JsonConvert.DeserializeObject<RootData>(json) ?? new RootData();

                if (root.packages != null && root.packages.ContainsKey(key))
                {
                    root.packages.Remove(key);
                    string updatedJson = JsonConvert.SerializeObject(root, Formatting.Indented);
                    File.WriteAllText(ruta, updatedJson);
                }

                refreshDGV();
                MessageBox.Show("Paquete eliminado!");
            }
        }
    }
}
