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
    public partial class frmDashboard : Form
    {
        string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "package_system.json");

        public frmDashboard()
        {
            InitializeComponent();       
            calculateEverything();
            stat1.AutoSize = false;
            stat2.AutoSize = false;
            stat3.AutoSize = false;
            stat4.AutoSize = false;
            stat5.AutoSize = false;
            stat1.TextAlign = ContentAlignment.MiddleCenter;
            stat2.TextAlign = ContentAlignment.MiddleCenter;
            stat3.TextAlign = ContentAlignment.MiddleCenter;
            stat4.TextAlign = ContentAlignment.MiddleCenter;
            stat5.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void calculateEverything()
        {
            string json = File.ReadAllText(ruta);
            var root = JsonConvert.DeserializeObject<RootData>(json) ?? new RootData();

            if (root.packages == null)
                root.packages = new Dictionary<string, Package>();

            stat1.Text = root.packages.Count.ToString();
            stat2.Text = root.packages.Values.Count(p => p.P_term == "Embarcado").ToString();
            stat3.Text = root.packages.Values.Count(p => p.P_term == "Recibido").ToString();
            stat4.Text = root.packages.Values.Count(p => p.P_term == "Transito").ToString();
            stat5.Text = "$" + root.packages.Values.Sum(p => p.P_cost).ToString();
        }

        //////////////////////
        //     BUTTONS      //
        //////////////////////
        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
