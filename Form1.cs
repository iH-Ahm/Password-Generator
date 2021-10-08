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
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                textBox1.Text = "";
            }
            else
            {
                textBox1.Text = generatePassword();
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
                string selectedCharacter = selectValue();
                password = password + selectedCharacter;
            }

            return password;
        }

        private string selectValue()
        {
            int checkBoxNumber = random.Next(1, 5);
            string character = "";
            if (checkBox1.Checked == true && checkBoxNumber == 1)
            {
                return character = getUpperCase();
            }
            else if (checkBox2.Checked == true && checkBoxNumber == 2)
            {
                return character = getLowerCase();
            }
            else if (checkBox3.Checked == true && checkBoxNumber == 3)
            {
                return character = getNumber();
            }
            else if (checkBox4.Checked == true && checkBoxNumber == 4)
            {
                return character = getSymbol();
            }
            else
            {
                return character = selectValue();
            }
        }
    }
}
