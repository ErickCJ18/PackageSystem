namespace Sistema_de_Paqueteria
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnBack = new System.Windows.Forms.Panel();
            this.btnSign = new System.Windows.Forms.Button();
            this.tbNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbClave = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnIngresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tbSignName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbSignClave = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblSignup = new System.Windows.Forms.Label();
            this.btnSignnow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGotAcc = new System.Windows.Forms.Button();
            this.pnBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBack
            // 
            this.pnBack.BackColor = System.Drawing.SystemColors.Menu;
            this.pnBack.Controls.Add(this.btnGotAcc);
            this.pnBack.Controls.Add(this.btnSignnow);
            this.pnBack.Controls.Add(this.lblSignup);
            this.pnBack.Controls.Add(this.tbSignClave);
            this.pnBack.Controls.Add(this.tbSignName);
            this.pnBack.Controls.Add(this.btnSign);
            this.pnBack.Controls.Add(this.tbNombre);
            this.pnBack.Controls.Add(this.tbClave);
            this.pnBack.Controls.Add(this.btnIngresar);
            this.pnBack.Controls.Add(this.pbUser);
            this.pnBack.Controls.Add(this.pnTop);
            this.pnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBack.Location = new System.Drawing.Point(0, 0);
            this.pnBack.Margin = new System.Windows.Forms.Padding(2);
            this.pnBack.Name = "pnBack";
            this.pnBack.Size = new System.Drawing.Size(431, 585);
            this.pnBack.TabIndex = 0;
            // 
            // btnSign
            // 
            this.btnSign.FlatAppearance.BorderSize = 0;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Location = new System.Drawing.Point(164, 438);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(129, 23);
            this.btnSign.TabIndex = 8;
            this.btnSign.Text = "¿No tienes cuenta?";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNombre.HintForeColor = System.Drawing.Color.Empty;
            this.tbNombre.HintText = "";
            this.tbNombre.isPassword = false;
            this.tbNombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNombre.LineThickness = 3;
            this.tbNombre.Location = new System.Drawing.Point(119, 317);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(214, 26);
            this.tbNombre.TabIndex = 7;
            this.tbNombre.Text = "Nombre";
            this.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbClave
            // 
            this.tbClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbClave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbClave.HintForeColor = System.Drawing.Color.Empty;
            this.tbClave.HintText = "";
            this.tbClave.isPassword = true;
            this.tbClave.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbClave.LineIdleColor = System.Drawing.Color.Gray;
            this.tbClave.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbClave.LineThickness = 3;
            this.tbClave.Location = new System.Drawing.Point(119, 356);
            this.tbClave.Margin = new System.Windows.Forms.Padding(4);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(214, 26);
            this.tbClave.TabIndex = 7;
            this.tbClave.Text = "Clave";
            this.tbClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresar.BorderRadius = 0;
            this.btnIngresar.ButtonText = "Ingresar";
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.DisabledColor = System.Drawing.Color.Gray;
            this.btnIngresar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIngresar.Iconimage = null;
            this.btnIngresar.Iconimage_right = null;
            this.btnIngresar.Iconimage_right_Selected = null;
            this.btnIngresar.Iconimage_Selected = null;
            this.btnIngresar.IconMarginLeft = 0;
            this.btnIngresar.IconMarginRight = 0;
            this.btnIngresar.IconRightVisible = true;
            this.btnIngresar.IconRightZoom = 0D;
            this.btnIngresar.IconVisible = true;
            this.btnIngresar.IconZoom = 90D;
            this.btnIngresar.IsTab = false;
            this.btnIngresar.Location = new System.Drawing.Point(135, 394);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIngresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnIngresar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIngresar.selected = false;
            this.btnIngresar.Size = new System.Drawing.Size(184, 39);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresar.Textcolor = System.Drawing.Color.White;
            this.btnIngresar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.SystemColors.GrayText;
            this.pbUser.Image = global::Sistema_de_Paqueteria.Properties.Resources.decor3;
            this.pbUser.Location = new System.Drawing.Point(200, 196);
            this.pbUser.Margin = new System.Windows.Forms.Padding(2);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(48, 48);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUser.TabIndex = 1;
            this.pbUser.TabStop = false;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.BurlyWood;
            this.pnTop.Controls.Add(this.btnClose);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(431, 32);
            this.pnTop.TabIndex = 0;
            this.pnTop.Tag = "prime";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Sistema_de_Paqueteria.Properties.Resources.Close_app;
            this.btnClose.Location = new System.Drawing.Point(392, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Tag = "prime";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // tbSignName
            // 
            this.tbSignName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSignName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSignName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSignName.HintForeColor = System.Drawing.Color.Empty;
            this.tbSignName.HintText = "";
            this.tbSignName.isPassword = false;
            this.tbSignName.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSignName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSignName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSignName.LineThickness = 3;
            this.tbSignName.Location = new System.Drawing.Point(119, 260);
            this.tbSignName.Margin = new System.Windows.Forms.Padding(4);
            this.tbSignName.Name = "tbSignName";
            this.tbSignName.Size = new System.Drawing.Size(214, 26);
            this.tbSignName.TabIndex = 9;
            this.tbSignName.Text = "Nombre";
            this.tbSignName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSignName.Visible = false;
            // 
            // tbSignClave
            // 
            this.tbSignClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSignClave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSignClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSignClave.HintForeColor = System.Drawing.Color.Empty;
            this.tbSignClave.HintText = "";
            this.tbSignClave.isPassword = true;
            this.tbSignClave.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSignClave.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSignClave.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSignClave.LineThickness = 3;
            this.tbSignClave.Location = new System.Drawing.Point(119, 308);
            this.tbSignClave.Margin = new System.Windows.Forms.Padding(4);
            this.tbSignClave.Name = "tbSignClave";
            this.tbSignClave.Size = new System.Drawing.Size(214, 26);
            this.tbSignClave.TabIndex = 10;
            this.tbSignClave.Text = "Clave";
            this.tbSignClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSignClave.Visible = false;
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.BackColor = System.Drawing.Color.Transparent;
            this.lblSignup.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.ForeColor = System.Drawing.Color.Peru;
            this.lblSignup.Location = new System.Drawing.Point(74, 196);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(304, 35);
            this.lblSignup.TabIndex = 11;
            this.lblSignup.Text = "¡Se parte de nosotros!";
            this.lblSignup.Visible = false;
            // 
            // btnSignnow
            // 
            this.btnSignnow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSignnow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSignnow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignnow.BorderRadius = 0;
            this.btnSignnow.ButtonText = "Registrarse";
            this.btnSignnow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignnow.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignnow.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignnow.Iconimage = null;
            this.btnSignnow.Iconimage_right = null;
            this.btnSignnow.Iconimage_right_Selected = null;
            this.btnSignnow.Iconimage_Selected = null;
            this.btnSignnow.IconMarginLeft = 0;
            this.btnSignnow.IconMarginRight = 0;
            this.btnSignnow.IconRightVisible = true;
            this.btnSignnow.IconRightZoom = 0D;
            this.btnSignnow.IconVisible = true;
            this.btnSignnow.IconZoom = 90D;
            this.btnSignnow.IsTab = false;
            this.btnSignnow.Location = new System.Drawing.Point(135, 362);
            this.btnSignnow.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignnow.Name = "btnSignnow";
            this.btnSignnow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSignnow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSignnow.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignnow.selected = false;
            this.btnSignnow.Size = new System.Drawing.Size(184, 39);
            this.btnSignnow.TabIndex = 12;
            this.btnSignnow.Text = "Registrarse";
            this.btnSignnow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignnow.Textcolor = System.Drawing.Color.White;
            this.btnSignnow.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignnow.Visible = false;
            this.btnSignnow.Click += new System.EventHandler(this.btnSignnow_Click);
            // 
            // btnGotAcc
            // 
            this.btnGotAcc.FlatAppearance.BorderSize = 0;
            this.btnGotAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGotAcc.Location = new System.Drawing.Point(164, 408);
            this.btnGotAcc.Name = "btnGotAcc";
            this.btnGotAcc.Size = new System.Drawing.Size(129, 23);
            this.btnGotAcc.TabIndex = 13;
            this.btnGotAcc.Text = "Ya tengo cuenta";
            this.btnGotAcc.UseVisualStyleBackColor = true;
            this.btnGotAcc.Visible = false;
            this.btnGotAcc.Click += new System.EventHandler(this.btnGotAcc_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 585);
            this.Controls.Add(this.pnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.pnBack.ResumeLayout(false);
            this.pnBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBack;
        private System.Windows.Forms.Panel pnTop;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pbUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnIngresar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbClave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNombre;
        private System.Windows.Forms.Button btnSign;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbSignClave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbSignName;
        private System.Windows.Forms.Label lblSignup;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignnow;
        private System.Windows.Forms.Button btnGotAcc;
    }
}