namespace Sistema_de_Paqueteria
{
    partial class frmDashboard
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pnScreen = new System.Windows.Forms.Panel();
            this.lblGreet = new System.Windows.Forms.Label();
            this.pbDecor1 = new System.Windows.Forms.PictureBox();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblStat1 = new System.Windows.Forms.Label();
            this.stat1 = new System.Windows.Forms.Label();
            this.lblStat2 = new System.Windows.Forms.Label();
            this.stat2 = new System.Windows.Forms.Label();
            this.lblStat3 = new System.Windows.Forms.Label();
            this.stat3 = new System.Windows.Forms.Label();
            this.lblStat4 = new System.Windows.Forms.Label();
            this.stat4 = new System.Windows.Forms.Label();
            this.lblStat6 = new System.Windows.Forms.Label();
            this.stat5 = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.pnScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecor1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            // pnScreen
            // 
            this.pnScreen.BackColor = System.Drawing.SystemColors.Menu;
            this.pnScreen.Controls.Add(this.panel5);
            this.pnScreen.Controls.Add(this.panel4);
            this.pnScreen.Controls.Add(this.panel3);
            this.pnScreen.Controls.Add(this.panel2);
            this.pnScreen.Controls.Add(this.panel1);
            this.pnScreen.Controls.Add(this.lblGreet);
            this.pnScreen.Controls.Add(this.pbDecor1);
            this.pnScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnScreen.Location = new System.Drawing.Point(0, 38);
            this.pnScreen.Name = "pnScreen";
            this.pnScreen.Size = new System.Drawing.Size(1251, 627);
            this.pnScreen.TabIndex = 1;
            // 
            // lblGreet
            // 
            this.lblGreet.AutoSize = true;
            this.lblGreet.BackColor = System.Drawing.Color.Transparent;
            this.lblGreet.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreet.ForeColor = System.Drawing.Color.Peru;
            this.lblGreet.Location = new System.Drawing.Point(137, 59);
            this.lblGreet.Name = "lblGreet";
            this.lblGreet.Size = new System.Drawing.Size(235, 35);
            this.lblGreet.TabIndex = 1;
            this.lblGreet.Text = "Panel de Usuario";
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
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.pnTop;
            this.DragControl.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.stat1);
            this.panel1.Controls.Add(this.lblStat1);
            this.panel1.Location = new System.Drawing.Point(146, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 150);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.stat2);
            this.panel2.Controls.Add(this.lblStat2);
            this.panel2.Location = new System.Drawing.Point(516, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 150);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.stat3);
            this.panel3.Controls.Add(this.lblStat3);
            this.panel3.Location = new System.Drawing.Point(891, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 150);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Goldenrod;
            this.panel4.Controls.Add(this.stat4);
            this.panel4.Controls.Add(this.lblStat4);
            this.panel4.Location = new System.Drawing.Point(332, 430);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 150);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel5.Controls.Add(this.stat5);
            this.panel5.Controls.Add(this.lblStat6);
            this.panel5.Location = new System.Drawing.Point(704, 430);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 150);
            this.panel5.TabIndex = 30;
            // 
            // lblStat1
            // 
            this.lblStat1.AutoSize = true;
            this.lblStat1.BackColor = System.Drawing.Color.Transparent;
            this.lblStat1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStat1.Location = new System.Drawing.Point(18, 0);
            this.lblStat1.Name = "lblStat1";
            this.lblStat1.Size = new System.Drawing.Size(203, 35);
            this.lblStat1.TabIndex = 31;
            this.lblStat1.Text = "Total Paquetes";
            // 
            // stat1
            // 
            this.stat1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stat1.AutoSize = true;
            this.stat1.BackColor = System.Drawing.Color.Transparent;
            this.stat1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat1.ForeColor = System.Drawing.Color.Gainsboro;
            this.stat1.Location = new System.Drawing.Point(102, 65);
            this.stat1.Name = "stat1";
            this.stat1.Size = new System.Drawing.Size(31, 35);
            this.stat1.TabIndex = 32;
            this.stat1.Text = "X";
            // 
            // lblStat2
            // 
            this.lblStat2.AutoSize = true;
            this.lblStat2.BackColor = System.Drawing.Color.Transparent;
            this.lblStat2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStat2.Location = new System.Drawing.Point(21, 0);
            this.lblStat2.Name = "lblStat2";
            this.lblStat2.Size = new System.Drawing.Size(196, 35);
            this.lblStat2.TabIndex = 33;
            this.lblStat2.Text = "Embarcado(s)";
            // 
            // stat2
            // 
            this.stat2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stat2.AutoSize = true;
            this.stat2.BackColor = System.Drawing.Color.Transparent;
            this.stat2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat2.ForeColor = System.Drawing.Color.Gainsboro;
            this.stat2.Location = new System.Drawing.Point(104, 65);
            this.stat2.Name = "stat2";
            this.stat2.Size = new System.Drawing.Size(31, 35);
            this.stat2.TabIndex = 33;
            this.stat2.Text = "X";
            // 
            // lblStat3
            // 
            this.lblStat3.AutoSize = true;
            this.lblStat3.BackColor = System.Drawing.Color.Transparent;
            this.lblStat3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat3.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStat3.Location = new System.Drawing.Point(26, 0);
            this.lblStat3.Name = "lblStat3";
            this.lblStat3.Size = new System.Drawing.Size(186, 35);
            this.lblStat3.TabIndex = 34;
            this.lblStat3.Text = "Disponible(s)";
            // 
            // stat3
            // 
            this.stat3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stat3.AutoSize = true;
            this.stat3.BackColor = System.Drawing.Color.Transparent;
            this.stat3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat3.ForeColor = System.Drawing.Color.Gainsboro;
            this.stat3.Location = new System.Drawing.Point(103, 65);
            this.stat3.Name = "stat3";
            this.stat3.Size = new System.Drawing.Size(31, 35);
            this.stat3.TabIndex = 34;
            this.stat3.Text = "X";
            // 
            // lblStat4
            // 
            this.lblStat4.AutoSize = true;
            this.lblStat4.BackColor = System.Drawing.Color.Transparent;
            this.lblStat4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat4.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStat4.Location = new System.Drawing.Point(42, 0);
            this.lblStat4.Name = "lblStat4";
            this.lblStat4.Size = new System.Drawing.Size(155, 35);
            this.lblStat4.TabIndex = 35;
            this.lblStat4.Text = "En tránsito";
            // 
            // stat4
            // 
            this.stat4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stat4.AutoSize = true;
            this.stat4.BackColor = System.Drawing.Color.Transparent;
            this.stat4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat4.ForeColor = System.Drawing.Color.Gainsboro;
            this.stat4.Location = new System.Drawing.Point(101, 65);
            this.stat4.Name = "stat4";
            this.stat4.Size = new System.Drawing.Size(31, 35);
            this.stat4.TabIndex = 34;
            this.stat4.Text = "X";
            // 
            // lblStat6
            // 
            this.lblStat6.AutoSize = true;
            this.lblStat6.BackColor = System.Drawing.Color.Transparent;
            this.lblStat6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat6.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStat6.Location = new System.Drawing.Point(28, 0);
            this.lblStat6.Name = "lblStat6";
            this.lblStat6.Size = new System.Drawing.Size(185, 35);
            this.lblStat6.TabIndex = 36;
            this.lblStat6.Text = "Total gastado";
            // 
            // stat5
            // 
            this.stat5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stat5.BackColor = System.Drawing.Color.Transparent;
            this.stat5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat5.ForeColor = System.Drawing.Color.Gainsboro;
            this.stat5.Location = new System.Drawing.Point(44, 65);
            this.stat5.Name = "stat5";
            this.stat5.Size = new System.Drawing.Size(150, 35);
            this.stat5.TabIndex = 36;
            this.stat5.Text = "X";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 665);
            this.Controls.Add(this.pnScreen);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.pnScreen.ResumeLayout(false);
            this.pnScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecor1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnScreen;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbDecor1;
        private System.Windows.Forms.Label lblGreet;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stat1;
        private System.Windows.Forms.Label lblStat1;
        private System.Windows.Forms.Label lblStat2;
        private System.Windows.Forms.Label stat2;
        private System.Windows.Forms.Label stat3;
        private System.Windows.Forms.Label lblStat3;
        private System.Windows.Forms.Label stat4;
        private System.Windows.Forms.Label lblStat4;
        private System.Windows.Forms.Label stat5;
        private System.Windows.Forms.Label lblStat6;
    }
}

