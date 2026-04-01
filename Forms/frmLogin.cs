using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Paqueteria
{
    public partial class frmLogin : Form
    {
        string name;
        string pass;
        string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "package_system.json");
        public frmLogin()
        {
            InitializeComponent();
            if (!File.Exists(ruta))
            {
                var root = new RootData();
                string json = JsonConvert.SerializeObject(root, Formatting.Indented);
                File.WriteAllText(ruta, json);
            }
        }

        //////////////////////////////
        //          BUTTONS         //
        //////////////////////////////
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != string.Empty)
            {
                if (tbClave.Text != string.Empty)
                {
                    string json = File.ReadAllText(ruta);
                    var root = JsonConvert.DeserializeObject<RootData>(json) ?? new RootData();

                    if (root.users == null || root.users.Count == 0)
                    {
                        MessageBox.Show("No hay usuarios registrados.");
                        return;
                    }

                    if (root.users.ContainsKey(tbNombre.Text.Trim()))
                    {
                        User user = root.users[tbNombre.Text.Trim()];

                        if (user.U_pass == tbClave.Text.Trim())
                        {
                            frmMain frm = new frmMain();
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Clave incorrecta.");
                            tbClave.Text = "";
                            tbClave.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.");
                        tbNombre.Text = "";
                        tbNombre.Focus();
                    }
                }
            }
        }
        private void hideLogin()
        {
            tbNombre.Visible = false;
            tbClave.Visible = false;
            btnIngresar.Visible = false;
            btnSign.Visible = false;
            pbUser.Visible = false;
            // ------
            tbSignName.Visible = true;
            tbSignClave.Visible = true;
            lblSignup.Visible = true;
            btnSignnow.Visible = true;
            btnGotAcc.Visible = true;
        }

        private void showLogin()
        {
            tbNombre.Visible = true;
            tbClave.Visible = true;
            btnIngresar.Visible = true;
            btnSign.Visible = true;
            pbUser.Visible = true;
            // ------
            tbSignName.Visible = false;
            tbSignClave.Visible = false;
            lblSignup.Visible = false;
            btnSignnow.Visible = false;
            btnGotAcc.Visible = false;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            hideLogin();
        }

        private void btnGotAcc_Click(object sender, EventArgs e)
        {
            showLogin();
        }

        private void btnSignnow_Click(object sender, EventArgs e)
        {
            if (tbSignName.Text != string.Empty)
            {
                if (tbSignClave.Text != string.Empty)
                {
                    string json = File.ReadAllText(ruta);
                    var root = JsonConvert.DeserializeObject<RootData>(json) ?? new RootData();

                    if (root.users == null)
                        root.users = new Dictionary<string, User>();

                    if (root.users.ContainsKey(tbSignName.Text.Trim()))
                    {
                        MessageBox.Show("Ya hay un usuario con ese nombre!");
                        return;
                    }

                    User newUser = new User
                    {
                        U_name = tbSignName.Text,
                        U_pass = tbSignClave.Text
                    };

                    root.users.Add(tbSignName.Text.Trim(), newUser);

                    string updatedJson = JsonConvert.SerializeObject(root, Formatting.Indented);
                    File.WriteAllText(ruta, updatedJson);
                    MessageBox.Show("Se ha creado tu cuenta!");
                    showLogin();
                }
            }
        }
    }
}
