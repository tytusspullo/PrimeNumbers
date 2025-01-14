using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbersCalculatorGP
{
    public partial class FrmCalculator : Form
    {
        ICycleConfiguration _config = new CycleConfiguration();
        CalculationResult _calculationResult = null;
        CalculatePrimeNumber _calculator = null;
        string _fileName = "results.xml";
        int lastcycle = 0;
        bool _isStarted = false;
        int _defaultCycleLength = 10;//in seconds

        public FrmCalculator()
        {
            _defaultCycleLength = _config.ReadDefaultCycle();
            _calculator = new CalculatePrimeNumber(_calculationResult, _defaultCycleLength);
            InitializeComponent();
            ReadLastResultFromfile();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!_isStarted)
            {
                ReadLastResultFromfile();
            }
            else
            {
                MessageBox.Show("Calculations in progress, can't read now.", "Information"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void ReadLastResultFromfile()
        {
            try
            {
                var xmlResultRetriver = new XMLResultRetriver(_fileName);
                _calculationResult = xmlResultRetriver.ReadFromXML();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("There was problem with file read.", "Warning!"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //==when was unable read from file create new instance
            if (_calculationResult == null)
            {
                _calculationResult = new CalculationResult();
                _calculationResult.CycleNumber = 0;
            }
            DisplayResult(_calculationResult);
        }
        private async void btnStart_ClickAsync(object sender, EventArgs e)
        {
            await Start();
        }
        private async Task Start()
        {
            StartCycle();

            _calculator = new CalculatePrimeNumber(_calculationResult, _defaultCycleLength);
            var result = await _calculator.CalculateAsync();
            _calculationResult = result;
            //==save
            try
            {
                XMLResultSaver xmlSaver = new XMLResultSaver(result, _fileName);
                xmlSaver.WriteToXML();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("There was problem with file write.", "Warning!"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //==display error information if not calculated in cycle==
            if (!_calculationResult.PrimeNumberWasCalculated)
                tbError.Text = "For cycle:" + _calculationResult.CycleNumber.ToString() + " prime number was not found!";
            //==display as old now==
            DisplayResult(_calculationResult);

            StopCycle();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopCycle();
            _calculator.CancelManual();
        }

        private void TimerCallback(object state)
        {
           this.Invoke(new Action(async () => await Start()));
        }
        private void StartCycle()
        {
            _isStarted = true;
            btnStart.Enabled = !_isStarted;
            btnStop.Enabled = _isStarted;
            //==display information about new cycle
            int newCycle = _calculationResult.CycleNumber + 1;
            tbNewCycle.Text = "Starting cycle:" + newCycle.ToString();
            
        }
        private void StopCycle()
        {
            _isStarted = false;
            btnStart.Enabled = !_isStarted;
            btnStop.Enabled = _isStarted;
            //clean display new 
            tbNewCycle.Text = string.Empty;
        }
        private void DisplayResult(CalculationResult calculationResult)
        { 
            tbCycle.Text = calculationResult.CycleNumber.ToString();
            tbLastPrimeNumber.Text = calculationResult.LastPrimeNumber.ToString();
            tbWhenPrimeNumberWasFound.Text = calculationResult.WhenPrimeNumberWasFound.ToLongDateString() 
                            + " " + calculationResult.WhenPrimeNumberWasFound.ToLongTimeString();
            tbCycleDuration.Text = calculationResult.CycleDuration.ToLongTimeString();
        }
    }
}
