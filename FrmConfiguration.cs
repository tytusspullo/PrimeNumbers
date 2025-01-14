using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbersCalculatorGP
{
    public partial class FrmConfiguration : Form
    {
        ICycleConfiguration _config = new CycleConfiguration();
        int _defaultCycle = 10;

        public FrmConfiguration()
        {
            InitializeComponent();
        }

        private void FrmConfiguration_Load(object sender, EventArgs e)
        {
            _defaultCycle = _config.ReadDefaultCycle();
            tbDefaultCycle.Text = _defaultCycle.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _config.SaveDefaultCycle(_defaultCycle);
        }

        private void tbDefaultCycle_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbDefaultCycle.Text, out int parsedValue))
            {
                if (parsedValue >= int.MinValue && parsedValue <= int.MaxValue)
                {
                    _defaultCycle = parsedValue;
                }
                else
                {
                    MessageBox.Show("The number is too large or too small for an integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbDefaultCycle.Text = _defaultCycle.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDefaultCycle.Text = _defaultCycle.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
