namespace Sistema_de_Paqueteria
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnScreen = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnManager = new System.Windows.Forms.Panel();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbVol = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDecor2 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.lblStand1 = new System.Windows.Forms.Label();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pbDecor1 = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.tbFilter = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pnTop.SuspendLayout();
            this.pnScreen.SuspendLayout();
            this.pnManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.BurlyWood;
            this.pnTop.Controls.Add(this.pbExit);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1251, 38);
            this.pnTop.TabIndex = 0;
            // 
            // pnScreen
            // 
            this.pnScreen.BackColor = System.Drawing.SystemColors.Menu;
            this.pnScreen.Controls.Add(this.tbFilter);
            this.pnScreen.Controls.Add(this.btnDelete);
            this.pnScreen.Controls.Add(this.btnEdit);
            this.pnScreen.Controls.Add(this.btnNew);
            this.pnScreen.Controls.Add(this.pnManager);
            this.pnScreen.Controls.Add(this.gridView);
            this.pnScreen.Controls.Add(this.lblStand1);
            this.pnScreen.Controls.Add(this.pbDecor1);
            this.pnScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnScreen.Location = new System.Drawing.Point(0, 38);
            this.pnScreen.Name = "pnScreen";
            this.pnScreen.Size = new System.Drawing.Size(1251, 627);
            this.pnScreen.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(406, 555);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 38);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightYellow;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(209, 555);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(191, 38);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNew.Location = new System.Drawing.Point(12, 555);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(191, 38);
            this.btnNew.TabIndex = 26;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnManager
            // 
            this.pnManager.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnManager.Controls.Add(this.dtp);
            this.pnManager.Controls.Add(this.cbTerm);
            this.pnManager.Controls.Add(this.btnCancel);
            this.pnManager.Controls.Add(this.btnSave);
            this.pnManager.Controls.Add(this.tbVol);
            this.pnManager.Controls.Add(this.lblVolume);
            this.pnManager.Controls.Add(this.tbWeight);
            this.pnManager.Controls.Add(this.lblWeight);
            this.pnManager.Controls.Add(this.tbContent);
            this.pnManager.Controls.Add(this.lblContenido);
            this.pnManager.Controls.Add(this.lblDate);
            this.pnManager.Controls.Add(this.label2);
            this.pnManager.Controls.Add(this.tbCode);
            this.pnManager.Controls.Add(this.lblCode);
            this.pnManager.Controls.Add(this.lblDecor2);
            this.pnManager.Location = new System.Drawing.Point(874, 103);
            this.pnManager.Name = "pnManager";
            this.pnManager.Size = new System.Drawing.Size(321, 510);
            this.pnManager.TabIndex = 3;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(65, 204);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 25;
            // 
            // cbTerm
            // 
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Location = new System.Drawing.Point(60, 140);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(210, 21);
            this.cbTerm.TabIndex = 24;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(169, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 40);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(86, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 40);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbVol
            // 
            this.tbVol.Location = new System.Drawing.Point(60, 396);
            this.tbVol.Name = "tbVol";
            this.tbVol.Size = new System.Drawing.Size(210, 20);
            this.tbVol.TabIndex = 18;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblVolume.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.Black;
            this.lblVolume.Location = new System.Drawing.Point(139, 368);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(45, 25);
            this.lblVolume.TabIndex = 17;
            this.lblVolume.Text = "Vol.";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(60, 332);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(210, 20);
            this.tbWeight.TabIndex = 16;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblWeight.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.Black;
            this.lblWeight.Location = new System.Drawing.Point(132, 304);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(57, 25);
            this.lblWeight.TabIndex = 15;
            this.lblWeight.Text = "Peso";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(60, 270);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(210, 20);
            this.tbContent.TabIndex = 14;
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.BackColor = System.Drawing.Color.Transparent;
            this.lblContenido.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.ForeColor = System.Drawing.Color.Black;
            this.lblContenido.Location = new System.Drawing.Point(112, 242);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(105, 25);
            this.lblContenido.TabIndex = 13;
            this.lblContenido.Text = "Contenido";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(97, 176);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(135, 25);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Fecha Aprox.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(121, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Término";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(60, 81);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(210, 20);
            this.tbCode.TabIndex = 8;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.Location = new System.Drawing.Point(121, 53);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(74, 25);
            this.lblCode.TabIndex = 7;
            this.lblCode.Text = "Código";
            // 
            // lblDecor2
            // 
            this.lblDecor2.AutoSize = true;
            this.lblDecor2.BackColor = System.Drawing.Color.Transparent;
            this.lblDecor2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecor2.ForeColor = System.Drawing.Color.Black;
            this.lblDecor2.Location = new System.Drawing.Point(112, 0);
            this.lblDecor2.Name = "lblDecor2";
            this.lblDecor2.Size = new System.Drawing.Size(102, 35);
            this.lblDecor2.TabIndex = 4;
            this.lblDecor2.Text = "Gestor";
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.GridColor = System.Drawing.SystemColors.Menu;
            this.gridView.Location = new System.Drawing.Point(12, 154);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersWidth = 35;
            this.gridView.Size = new System.Drawing.Size(808, 395);
            this.gridView.TabIndex = 2;
            // 
            // lblStand1
            // 
            this.lblStand1.AutoSize = true;
            this.lblStand1.BackColor = System.Drawing.Color.Transparent;
            this.lblStand1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStand1.ForeColor = System.Drawing.Color.Peru;
            this.lblStand1.Location = new System.Drawing.Point(137, 59);
            this.lblStand1.Name = "lblStand1";
            this.lblStand1.Size = new System.Drawing.Size(135, 35);
            this.lblStand1.TabIndex = 1;
            this.lblStand1.Text = "Paquetes";
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.pnTop;
            this.DragControl.Vertical = true;
            // 
            // pbDecor1
            // 
            this.pbDecor1.Image = global::Sistema_de_Paqueteria.Properties.Resources.decor1;
            this.pbDecor1.Location = new System.Drawing.Point(31, 24);
            this.pbDecor1.Name = "pbDecor1";
            this.pbDecor1.Size = new System.Drawing.Size(100, 100);
            this.pbDecor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDecor1.TabIndex = 0;
            this.pbDecor1.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::Sistema_de_Paqueteria.Properties.Resources.Close_app;
            this.pbExit.Location = new System.Drawing.Point(1216, 3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 32);
            this.pbExit.TabIndex = 0;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbFilter.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbFilter.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbFilter.BorderThickness = 3;
            this.tbFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbFilter.isPassword = false;
            this.tbFilter.Location = new System.Drawing.Point(505, 112);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(315, 35);
            this.tbFilter.TabIndex = 29;
            this.tbFilter.Text = "Código o Contenido...";
            this.tbFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFilter.OnValueChanged += new System.EventHandler(this.tbFilter_OnValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 665);
            this.Controls.Add(this.pnScreen);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnTop.ResumeLayout(false);
            this.pnScreen.ResumeLayout(false);
            this.pnScreen.PerformLayout();
            this.pnManager.ResumeLayout(false);
            this.pnManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnScreen;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbDecor1;
        private System.Windows.Forms.Label lblStand1;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Panel pnManager;
        private System.Windows.Forms.Label lblDecor2;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox tbVol;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbTerm;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbFilter;
    }
}

