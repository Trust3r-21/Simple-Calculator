namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        bool appendText = true;
        bool plusClicked = false;
        bool minusClicked = false;
        bool multiplyClicked = false;
        bool divisionClicked = false;
        String number;

        public Form1()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            if(appendText == true)
            {
                Display.Text = Display.Text + "1";
            }
            else
            {
                Display.Text = "1";
                appendText = true;
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (appendText == true)
            {
                Display.Text = Display.Text + "2";
            }
            else
            {
                Display.Text = "2";
                appendText = true;
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (appendText == true)
            {
                Display.Text = Display.Text + "3";
            }
            else
            {
                Display.Text = "3";
                appendText = true;
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (appendText == true)
            {
                Display.Text = Display.Text + "4";
            }
            else
            {
                Display.Text = "4";
                appendText = true;
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (appendText == true)
            {
                Display.Text = Display.Text + "5";
            }
            else
            {
                Display.Text = "5";
                appendText = true;
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (appendText == true)
            {
                Display.Text = Display.Text + "6";
            }
            else
            {
                Display.Text = "6";
                appendText = true;
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (appendText == true)
            {
                Display.Text = Display.Text + "7";
            }
            else
            {
                Display.Text = "7";
                appendText = true;
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (appendText == true)
            {
                Display.Text = Display.Text + "8";
            }
            else
            {
                Display.Text = "8";
                appendText = true;
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (appendText == true)
            {
                Display.Text = Display.Text + "9";
            }
            else
            {
                Display.Text = "9";
                appendText = true;
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (appendText == true)
            {
                Display.Text = Display.Text + "0";
            }
            else
            {
                Display.Text = "0";
                appendText = true;
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            plusClicked = true;
            if(Display.Text != null)
            {
                appendText = true;
                number = Display.Text;
                Display.Text = "";
            }
            else
            {
                appendText = true;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            minusClicked = true;
            if (Display.Text != null)
            {
                appendText = true;
                number = Display.Text;
                Display.Text = "";
            }
            else
            {
                appendText = true;
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            multiplyClicked = true;
            if (Display.Text != null)
            {
                appendText = true;
                number = Display.Text;
                Display.Text = "";
            }
            else
            {
                appendText = true;
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            divisionClicked = true;
            if (Display.Text != null)
            {
                appendText = true;
                number = Display.Text;
                Display.Text = "";
            }
            else
            {
                appendText = true;
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (appendText == true)
            {
                Display.Text = Display.Text + ".";
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            appendText = false;

            if(plusClicked == true && Display.Text != null)
            {
                double n1, n2, result;

                n1 = int.Parse(number);
                n2 = int.Parse(Display.Text);
                result = n1 + n2;

                Display.Text = Convert.ToString(result);
            }
            else if(minusClicked == true && Display.Text != null)
            {
                int n1, n2, result;

                n1 = int.Parse(number);
                n2 = int.Parse(Display.Text);
                result = n1 - n2;

                Display.Text = Convert.ToString(result);
            }
            else if(multiplyClicked == true && Display.Text != null)
            {
                int n1, n2, result;

                n1 = int.Parse(number);
                n2 = int.Parse(Display.Text);
                result = n1 * n2;

                Display.Text = Convert.ToString(result);
            }
            else if(divisionClicked == true && Display.Text != null)
            {
                int n1, n2, result;

                n1 = int.Parse(number);
                n2 = int.Parse(Display.Text);
                result = n1 / n2;

                Display.Text = Convert.ToString(result);
            }

            plusClicked = false;
            minusClicked = false;
            multiplyClicked = false;
            divisionClicked = false;
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {
            if(Display.Text.Length >= 14)
            {
                One.Enabled = false;
                Two.Enabled = false;
                Three.Enabled = false;
                Four.Enabled = false;
                Five.Enabled = false;
                Six.Enabled = false;
                Seven.Enabled = false;
                Eight.Enabled = false;
                Nine.Enabled = false;
                Zero.Enabled = false;
                Plus.Enabled = false;
                Minus.Enabled = false;
                Multiply.Enabled = false;
                Division.Enabled = false;
                Equals.Enabled = false;
                Dot.Enabled = false;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Display.Text = "";

            if (One.Enabled == false)
            {
                One.Enabled = true;
                Two.Enabled = true;
                Three.Enabled = true;
                Four.Enabled = true;
                Five.Enabled = true;
                Six.Enabled = true;
                Seven.Enabled = true;
                Eight.Enabled = true;
                Nine.Enabled = true;
                Zero.Enabled = true;
                Plus.Enabled = true;
                Minus.Enabled = true;
                Multiply.Enabled = true;
                Division.Enabled = true;
                Equals.Enabled = true;
                Dot.Enabled = true;
            }
        }
    }
}