namespace PrimeNumbersCalculatorGP
{
    partial class FrmCalculator
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
            this.gbRetriveLastCalculations = new System.Windows.Forms.GroupBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.gbLast = new System.Windows.Forms.GroupBox();
            this.tbWhenPrimeNumberWasFound = new System.Windows.Forms.TextBox();
            this.tbCycleDuration = new System.Windows.Forms.TextBox();
            this.lblcycle = new System.Windows.Forms.Label();
            this.tbCycle = new System.Windows.Forms.TextBox();
            this.lblLastPrimeNumber = new System.Windows.Forms.Label();
            this.lblCycleDuration = new System.Windows.Forms.Label();
            this.tbLastPrimeNumber = new System.Windows.Forms.TextBox();
            this.lblWhenPrimenumberWasFound = new System.Windows.Forms.Label();
            this.gbCalculationsCycle = new System.Windows.Forms.GroupBox();
            this.tbError = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblNewCycle = new System.Windows.Forms.Label();
            this.tbNewCycle = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbRetriveLastCalculations.SuspendLayout();
            this.gbLast.SuspendLayout();
            this.gbCalculationsCycle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRetriveLastCalculations
            // 
            this.gbRetriveLastCalculations.Controls.Add(this.btnRead);
            this.gbRetriveLastCalculations.Controls.Add(this.gbLast);
            this.gbRetriveLastCalculations.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbRetriveLastCalculations.Location = new System.Drawing.Point(0, 0);
            this.gbRetriveLastCalculations.Name = "gbRetriveLastCalculations";
            this.gbRetriveLastCalculations.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.gbRetriveLastCalculations.Size = new System.Drawing.Size(800, 226);
            this.gbRetriveLastCalculations.TabIndex = 0;
            this.gbRetriveLastCalculations.TabStop = false;
            this.gbRetriveLastCalculations.Text = "Retrive Last Calculations";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 19);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(176, 34);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read from XML";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // gbLast
            // 
            this.gbLast.Controls.Add(this.tbWhenPrimeNumberWasFound);
            this.gbLast.Controls.Add(this.tbCycleDuration);
            this.gbLast.Controls.Add(this.lblcycle);
            this.gbLast.Controls.Add(this.tbCycle);
            this.gbLast.Controls.Add(this.lblLastPrimeNumber);
            this.gbLast.Controls.Add(this.lblCycleDuration);
            this.gbLast.Controls.Add(this.tbLastPrimeNumber);
            this.gbLast.Controls.Add(this.lblWhenPrimenumberWasFound);
            this.gbLast.Location = new System.Drawing.Point(12, 59);
            this.gbLast.Name = "gbLast";
            this.gbLast.Size = new System.Drawing.Size(432, 154);
            this.gbLast.TabIndex = 9;
            this.gbLast.TabStop = false;
            // 
            // tbWhenPrimeNumberWasFound
            // 
            this.tbWhenPrimeNumberWasFound.Location = new System.Drawing.Point(191, 109);
            this.tbWhenPrimeNumberWasFound.Name = "tbWhenPrimeNumberWasFound";
            this.tbWhenPrimeNumberWasFound.Size = new System.Drawing.Size(227, 20);
            this.tbWhenPrimeNumberWasFound.TabIndex = 10;
            // 
            // tbCycleDuration
            // 
            this.tbCycleDuration.Location = new System.Drawing.Point(104, 54);
            this.tbCycleDuration.Name = "tbCycleDuration";
            this.tbCycleDuration.Size = new System.Drawing.Size(314, 20);
            this.tbCycleDuration.TabIndex = 9;
            // 
            // lblcycle
            // 
            this.lblcycle.AutoSize = true;
            this.lblcycle.Location = new System.Drawing.Point(19, 26);
            this.lblcycle.Name = "lblcycle";
            this.lblcycle.Size = new System.Drawing.Size(36, 13);
            this.lblcycle.TabIndex = 0;
            this.lblcycle.Text = "Cycle:";
            // 
            // tbCycle
            // 
            this.tbCycle.Location = new System.Drawing.Point(61, 23);
            this.tbCycle.Name = "tbCycle";
            this.tbCycle.Size = new System.Drawing.Size(357, 20);
            this.tbCycle.TabIndex = 1;
            // 
            // lblLastPrimeNumber
            // 
            this.lblLastPrimeNumber.AutoSize = true;
            this.lblLastPrimeNumber.Location = new System.Drawing.Point(19, 83);
            this.lblLastPrimeNumber.Name = "lblLastPrimeNumber";
            this.lblLastPrimeNumber.Size = new System.Drawing.Size(99, 13);
            this.lblLastPrimeNumber.TabIndex = 2;
            this.lblLastPrimeNumber.Text = "Last Prime Number:";
            // 
            // lblCycleDuration
            // 
            this.lblCycleDuration.AutoSize = true;
            this.lblCycleDuration.Location = new System.Drawing.Point(19, 55);
            this.lblCycleDuration.Name = "lblCycleDuration";
            this.lblCycleDuration.Size = new System.Drawing.Size(79, 13);
            this.lblCycleDuration.TabIndex = 6;
            this.lblCycleDuration.Text = "Cycle Duration:";
            // 
            // tbLastPrimeNumber
            // 
            this.tbLastPrimeNumber.Location = new System.Drawing.Point(124, 80);
            this.tbLastPrimeNumber.Name = "tbLastPrimeNumber";
            this.tbLastPrimeNumber.Size = new System.Drawing.Size(294, 20);
            this.tbLastPrimeNumber.TabIndex = 3;
            // 
            // lblWhenPrimenumberWasFound
            // 
            this.lblWhenPrimenumberWasFound.AutoSize = true;
            this.lblWhenPrimenumberWasFound.Location = new System.Drawing.Point(19, 112);
            this.lblWhenPrimenumberWasFound.Name = "lblWhenPrimenumberWasFound";
            this.lblWhenPrimenumberWasFound.Size = new System.Drawing.Size(166, 13);
            this.lblWhenPrimenumberWasFound.TabIndex = 4;
            this.lblWhenPrimenumberWasFound.Text = "When Prime Number Was Found:";
            // 
            // gbCalculationsCycle
            // 
            this.gbCalculationsCycle.Controls.Add(this.tbError);
            this.gbCalculationsCycle.Controls.Add(this.lblError);
            this.gbCalculationsCycle.Controls.Add(this.lblNewCycle);
            this.gbCalculationsCycle.Controls.Add(this.tbNewCycle);
            this.gbCalculationsCycle.Controls.Add(this.btnStop);
            this.gbCalculationsCycle.Controls.Add(this.btnStart);
            this.gbCalculationsCycle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCalculationsCycle.Location = new System.Drawing.Point(0, 226);
            this.gbCalculationsCycle.Name = "gbCalculationsCycle";
            this.gbCalculationsCycle.Size = new System.Drawing.Size(800, 224);
            this.gbCalculationsCycle.TabIndex = 1;
            this.gbCalculationsCycle.TabStop = false;
            this.gbCalculationsCycle.Text = "New Calculations";
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(73, 108);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(371, 20);
            this.tbError.TabIndex = 15;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(31, 111);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(32, 13);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Error:";
            // 
            // lblNewCycle
            // 
            this.lblNewCycle.AutoSize = true;
            this.lblNewCycle.Location = new System.Drawing.Point(31, 83);
            this.lblNewCycle.Name = "lblNewCycle";
            this.lblNewCycle.Size = new System.Drawing.Size(36, 13);
            this.lblNewCycle.TabIndex = 12;
            this.lblNewCycle.Text = "Cycle:";
            // 
            // tbNewCycle
            // 
            this.tbNewCycle.Location = new System.Drawing.Point(73, 80);
            this.tbNewCycle.Name = "tbNewCycle";
            this.tbNewCycle.Size = new System.Drawing.Size(371, 20);
            this.tbNewCycle.TabIndex = 13;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(236, 28);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(209, 34);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop cycle";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(209, 34);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start new cycle";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_ClickAsync);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCalculationsCycle);
            this.Controls.Add(this.gbRetriveLastCalculations);
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prime Numbers Calculator";
            this.gbRetriveLastCalculations.ResumeLayout(false);
            this.gbLast.ResumeLayout(false);
            this.gbLast.PerformLayout();
            this.gbCalculationsCycle.ResumeLayout(false);
            this.gbCalculationsCycle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRetriveLastCalculations;
        private System.Windows.Forms.GroupBox gbCalculationsCycle;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblcycle;
        private System.Windows.Forms.TextBox tbLastPrimeNumber;
        private System.Windows.Forms.Label lblLastPrimeNumber;
        private System.Windows.Forms.TextBox tbCycle;
        private System.Windows.Forms.Label lblCycleDuration;
        private System.Windows.Forms.Label lblWhenPrimenumberWasFound;
        private System.Windows.Forms.GroupBox gbLast;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblNewCycle;
        private System.Windows.Forms.TextBox tbNewCycle;
        private System.Windows.Forms.TextBox tbCycleDuration;
        private System.Windows.Forms.TextBox tbWhenPrimeNumberWasFound;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.Label lblError;
    }
}