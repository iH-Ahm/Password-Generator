using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Text = getUpperCase();
            }
        }

        private string getUpperCase()
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return letters[random.Next(0,letters.Length)].ToString();
        }

        private string getLowerCase()
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            return letters[random.Next(0, letters.Length)].ToString();
        }

        private string getNumber()
        {
            string numbers = "0123456789";
            return numbers[random.Next(0, numbers.Length)].ToString();
        }

        private string getSymbol()
        {
            string symbols = "!£$%^&*()-_+=";
            return symbols[random.Next(0, symbols.Length)].ToString();
        }

        private string generatePassword()
        {
            int passwordLength = Convert.ToInt32(numericUpDown1.Value);
            string password = "";

            for (int i = 0; i < passwordLength; i++)
            {
                string selectedValue = selectValue();
                password = password + selectedValue;
            }

            return password;
        }

        private string selectValue()
        {
            return "";
        }
    }
}
