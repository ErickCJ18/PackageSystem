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
    public partial class Form1 : Form
    {

        string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "package_system.json");
        bool packageEditing = false;
        public Form1()
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
                // crea el archivo
                Dictionary<string, Package> packages = new Dictionary<string, Package>();
                string json = JsonConvert.SerializeObject(packages);
                //Dictionary<string, User> users = new Dictionary<string, User>();
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

        //////////////////////
        //       CRUD       //
        //////////////////////

        // Actualiza el dataGridView
        private void refreshDGV() 
        {
            gridView.DataSource = readPackages();
            DataGridViewStyling();
        }

        // Lee el JSON de paquetes y los retorna al DataGridView
        private List<Package> readPackages()
        {
            string json = File.ReadAllText(ruta);

            var packages = JsonConvert.DeserializeObject<Dictionary<string, Package>>(json);
            if (packages == null)
            {
                packages = new Dictionary<string, Package>();
            }

            return packages.Values.ToList();
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
                P_cost = (float.Parse(tbWeight.Text) * 189)
            };

            if (packageEditing) 
            {
                string json = File.ReadAllText(ruta);
                var packages = JsonConvert.DeserializeObject<Dictionary<string, Package>>(json);

                if (packages == null)
                {
                    packages = new Dictionary<string, Package>();
                }

                if (packages.ContainsKey(tbCode.Text))
                {
                    packages[tbCode.Text] = newPackage;
                }

                string updatedJson = JsonConvert.SerializeObject(packages, Formatting.Indented);
                File.WriteAllText(ruta, updatedJson);
                MessageBox.Show("Paquete editado!");
            }
            else 
            {
                string json = File.ReadAllText(ruta);
                var packages = JsonConvert.DeserializeObject<Dictionary<string, Package>>(json);

                if (packages == null)
                {
                    packages = new Dictionary<string, Package>();
                }

                string key = newPackage.P_code.ToString();

                if (packages.ContainsKey(key))
                {
                    MessageBox.Show("YA HAY UN PAQUETE CON ESE CODIGO!");
                    return;
                }

                packages.Add(key, newPackage);

                string updatedJson = JsonConvert.SerializeObject(packages, Formatting.Indented);
                File.WriteAllText(ruta, updatedJson);
                MessageBox.Show("Paquete guardado!");
            }

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
                int code = int.Parse(gridView.SelectedRows[0].Cells["P_Code"].Value.ToString());
                //----------
                string json = File.ReadAllText(ruta);
                var packages = JsonConvert.DeserializeObject<Dictionary<string, Package>>(json);

                if (packages == null)
                {
                    packages = new Dictionary<string, Package>();
                }

                if (packages.ContainsKey(code.ToString())) 
                {
                    packages.Remove(code.ToString());
                    string updatedJson = JsonConvert.SerializeObject(packages, Formatting.Indented);
                    File.WriteAllText(ruta, updatedJson);
                }
                refreshDGV();
                MessageBox.Show("Paquete eliminado!");
            }
        }
    }
}
