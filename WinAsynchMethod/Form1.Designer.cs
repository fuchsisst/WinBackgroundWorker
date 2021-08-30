
namespace WinAsynchMethod
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDocumetationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblA
            // 
            resources.ApplyResources(this.lblA, "lblA");
            this.helpProvider1.SetHelpString(this.lblA, resources.GetString("lblA.HelpString"));
            this.lblA.Name = "lblA";
            this.helpProvider1.SetShowHelp(this.lblA, ((bool)(resources.GetObject("lblA.ShowHelp"))));
            this.toolTip1.SetToolTip(this.lblA, resources.GetString("lblA.ToolTip"));
            // 
            // lblB
            // 
            resources.ApplyResources(this.lblB, "lblB");
            this.helpProvider1.SetHelpString(this.lblB, resources.GetString("lblB.HelpString"));
            this.lblB.Name = "lblB";
            this.helpProvider1.SetShowHelp(this.lblB, ((bool)(resources.GetObject("lblB.ShowHelp"))));
            this.toolTip1.SetToolTip(this.lblB, resources.GetString("lblB.ToolTip"));
            // 
            // txbA
            // 
            resources.ApplyResources(this.txbA, "txbA");
            this.txbA.Name = "txbA";
            this.helpProvider1.SetShowHelp(this.txbA, ((bool)(resources.GetObject("txbA.ShowHelp"))));
            // 
            // txbB
            // 
            resources.ApplyResources(this.txbB, "txbB");
            this.txbB.Name = "txbB";
            this.helpProvider1.SetShowHelp(this.txbB, ((bool)(resources.GetObject("txbB.ShowHelp"))));
            // 
            // btnRun
            // 
            this.helpProvider1.SetHelpString(this.btnRun, resources.GetString("btnRun.HelpString"));
            resources.ApplyResources(this.btnRun, "btnRun");
            this.btnRun.Name = "btnRun";
            this.helpProvider1.SetShowHelp(this.btnRun, ((bool)(resources.GetObject("btnRun.ShowHelp"))));
            this.toolTip1.SetToolTip(this.btnRun, resources.GetString("btnRun.ToolTip"));
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnWork
            // 
            this.helpProvider1.SetHelpString(this.btnWork, resources.GetString("btnWork.HelpString"));
            resources.ApplyResources(this.btnWork, "btnWork");
            this.btnWork.Name = "btnWork";
            this.helpProvider1.SetShowHelp(this.btnWork, ((bool)(resources.GetObject("btnWork.ShowHelp"))));
            this.toolTip1.SetToolTip(this.btnWork, resources.GetString("btnWork.ToolTip"));
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // helpProvider1
            // 
            resources.ApplyResources(this.helpProvider1, "helpProvider1");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.helpProvider1.SetShowHelp(this.menuStrip1, ((bool)(resources.GetObject("menuStrip1.ShowHelp"))));
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDocumetationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // viewDocumetationToolStripMenuItem
            // 
            this.viewDocumetationToolStripMenuItem.Name = "viewDocumetationToolStripMenuItem";
            resources.ApplyResources(this.viewDocumetationToolStripMenuItem, "viewDocumetationToolStripMenuItem");
            this.viewDocumetationToolStripMenuItem.Click += new System.EventHandler(this.viewDocumetationToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDocumetationToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

