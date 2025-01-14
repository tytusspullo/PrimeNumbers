namespace PrimeNumbersCalculatorGP
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primeNumersCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cycleDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculationsToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculationsToolStripMenuItem
            // 
            this.calculationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primeNumersCalculatorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.calculationsToolStripMenuItem.Name = "calculationsToolStripMenuItem";
            this.calculationsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.calculationsToolStripMenuItem.Text = "Calculations";
            // 
            // primeNumersCalculatorToolStripMenuItem
            // 
            this.primeNumersCalculatorToolStripMenuItem.Name = "primeNumersCalculatorToolStripMenuItem";
            this.primeNumersCalculatorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.primeNumersCalculatorToolStripMenuItem.Text = "Prime Numers calculator";
            this.primeNumersCalculatorToolStripMenuItem.Click += new System.EventHandler(this.primeNumersCalculatorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cycleDefinitionToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // cycleDefinitionToolStripMenuItem
            // 
            this.cycleDefinitionToolStripMenuItem.Name = "cycleDefinitionToolStripMenuItem";
            this.cycleDefinitionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cycleDefinitionToolStripMenuItem.Text = "Cycle definition";
            this.cycleDefinitionToolStripMenuItem.Click += new System.EventHandler(this.cycleDefinitionToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Prime Numbers calculator by Grzegorz Piszczek";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primeNumersCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cycleDefinitionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}

