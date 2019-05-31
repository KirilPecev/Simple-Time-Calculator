namespace Time_Calculator
{
    using System;
    using System.Windows.Forms;

    public partial class SubtractTime : Form
    {
        public SubtractTime()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var time = DateTime.Parse(enterTimeTextBox.Text);
            var timeToSubtract = DateTime.Parse(subtractTimeTextBox.Text);
            string output = String.Format("{0:HH:mm}", time.Subtract(timeToSubtract.TimeOfDay));
            calculateButton.Text = output;
        }

        /// <summary>
        /// Go to Add Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subtractButton_Click(object sender, EventArgs e)
        {
            new AddTime().Show();
            this.Hide();
        }
    }
}
