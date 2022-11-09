using System.Text.RegularExpressions;

namespace WindowsFormActivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            bool n = isValidName(name.Text);
            bool c = isValidMobile(mobile.Text);
            bool em = isValidEmail(email.Text);

            if(n==true && c==true && em == true)
            {
                MessageBox.Show(" Name: " + name.Text
                                + "\n Address: " + address.Text
                                + "\n Mobile Number: " + mobile.Text
                                + "\n Email: " + email.Text);
            }

        }
        public bool isValidName(string n)
        {
            Regex check = new Regex(@"([A-Z][a-z-A-z]+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if(valid == true)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Name Format is Incorrect");
                return valid;
            }
        }

        public bool isValidMobile(string m)
        {
            Regex check = new Regex(@"^[0]{1}[9]{1}[0-9]{9}$");
            bool valid = false;
            valid = check.IsMatch(m);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Mobile Number Format is Incorrect.");
                return valid;
            }
        }

        public bool isValidEmail(string e)
        {
            Regex check = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool valid = false;
            valid = check.IsMatch(e);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Enter a valid email address.");
                return valid;
            }
        }
    }
}