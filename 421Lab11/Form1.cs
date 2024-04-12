namespace _421Lab11
{
    public partial class Form1 : Form
    {
        private string currentValue = "0";
        private bool isNegative = false;

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(currentValue); // Set initial value of list box
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {

        }

        private void divide_Click(object sender, EventArgs e)
        {

        }

        private void recipricol_Click(object sender, EventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {

        }

        private void minus_Click(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {

        }

        private void dec_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            if (currentValue.Length > 1) // If the current value has more than one digit
            {
                // Remove the last digit
                currentValue = currentValue.Substring(0, currentValue.Length - 1);
                if (isNegative) { SignChange(); };
                if (currentValue == "-")
                {
                    currentValue = "0";
                }
            }
            else if (currentValue != "0") // If the current value is not "0"
            {
                // Set the current value to "0" if the sign is negative
                if (currentValue.StartsWith("-"))
                {
                    currentValue = "0";
                }
                else // If the sign is positive or there is no sign, set the current value to empty
                {
                    currentValue = "";
                }
            }

            listBox1.Items.Clear();
            listBox1.Items.Add(currentValue);
        }


        private void clearEntry_Click(object sender, EventArgs e)
        {
            currentValue = "0";
            listBox1.Items.Clear();
            listBox1.Items.Add(currentValue);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //clearEntry_Click(sender, e); // Reuse the logic of clearEntry_Click
        }

        private void SignChange()
        {
            if (currentValue != "0") // Check if the current value is not "0"
            {
                // Toggle the sign of the number
                if (currentValue.Contains("-"))
                {
                    currentValue = currentValue.Replace("-", ""); // Remove the negative sign
                }
                else
                {
                    currentValue = "-" + currentValue; // Add the negative sign
                }

                listBox1.Items.Clear();
                listBox1.Items.Add(currentValue);
            }
            // else, if the current value is "0", do nothing
        }

        private void signChange_Click(object sender, EventArgs e)
        {
            SignChange();
        }

        private void zer_Click(object sender, EventArgs e)
        {
            UpdateListBox("0");
        }
        private void one_Click(object sender, EventArgs e)
        {
            UpdateListBox("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            UpdateListBox("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            UpdateListBox("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            UpdateListBox("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            UpdateListBox("5");
        }
        private void six_Click(object sender, EventArgs e)
        {
            UpdateListBox("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            UpdateListBox("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            UpdateListBox("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            UpdateListBox("9");
        }

        private void UpdateListBox(string number)
        {
            if (currentValue == "0") // If current value is 0, replace it with the new number
            {
                currentValue = number;
            }
            else // Otherwise, append the new number to the current value
            {
                currentValue += number;
            }

            Console.WriteLine(currentValue);
            listBox1.Items.Clear();
            listBox1.Items.Add(currentValue);
        }
    }
}
