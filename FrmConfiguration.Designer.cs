namespace PrimeNumbersCalculatorGP
{
    partial class FrmConfiguration
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
            this.lblcycle = new System.Windows.Forms.Label();
            this.tbDefaultCycle = new System.Windows.Forms.TextBox();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcycle
            // 
            this.lblcycle.AutoSize = true;
            this.lblcycle.Location = new System.Drawing.Point(24, 26);
            this.lblcycle.Name = "lblcycle";
            this.lblcycle.Size = new System.Drawing.Size(163, 13);
            this.lblcycle.TabIndex = 2;
            this.lblcycle.Text = "Default Cycle Length in seconds:";
            // 
            // tbDefaultCycle
            // 
            this.tbDefaultCycle.Location = new System.Drawing.Point(193, 23);
            this.tbDefaultCycle.Name = "tbDefaultCycle";
            this.tbDefaultCycle.Size = new System.Drawing.Size(214, 20);
            this.tbDefaultCycle.TabIndex = 3;
            this.tbDefaultCycle.TextChanged += new System.EventHandler(this.tbDefaultCycle_TextChanged);
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btnClose);
            this.gbButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbButtons.Location = new System.Drawing.Point(0, 134);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(608, 52);
            this.gbButtons.TabIndex = 4;
            this.gbButtons.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(420, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(176, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(420, 15);
            this.btnSave.MaximumSize = new System.Drawing.Size(176, 34);
            this.btnSave.MinimumSize = new System.Drawing.Size(176, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 186);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.lblcycle);
            this.Controls.Add(this.tbDefaultCycle);
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(624, 225);
            this.Name = "FrmConfiguration";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.FrmConfiguration_Load);
            this.gbButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcycle;
        private System.Windows.Forms.TextBox tbDefaultCycle;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}