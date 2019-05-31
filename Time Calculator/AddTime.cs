namespace Time_Calculator
{
    using System;
    using System.Windows.Forms;

    public partial class AddTime : Form
    {
        public AddTime()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add time
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            var time = DateTime.Parse(enterTimeTextBox.Text);
            var timeToAdd = DateTime.Parse(addTimeTextBox.Text);
            string output = String.Format("{0:HH:mm}",time.Add(timeToAdd.TimeOfDay));
            calculateButton.Text = output;
        }

        /// <summary>
        /// Subtract time
        /// </summary>
<<<<<<< HEAD
        /// <param name="sender"></param>
        /// <param name="e"></param>
=======
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
>>>>>>> 789d810d56d6f0a2bf8ad0b725ee6f6a3312bf87
        private void subtractButton_Click(object sender, EventArgs e)
        {
            new SubtractTime().Show();
            this.Hide();
        }
    }
}
