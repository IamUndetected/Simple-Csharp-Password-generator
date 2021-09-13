using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePasswordGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_Gen_Click(object sender, EventArgs e)
        {
            //Checks for the checkboxes on Form1.cs
            //and generates the amount of chars in the checkbox
            if (Check6Chars.Checked)
            {
                PasswordGenerator(6);
            }
            else if (Check10Chars.Checked)
            {
                PasswordGenerator(10);

            }
            else if (Check20Chars.Checked)
            {
                PasswordGenerator(20);
            }
            else if (Check35Chars.Checked)
            {
                PasswordGenerator(35);
            }
        }



        public void PasswordGenerator(int len)
        {
            //All chars listed here can be used for the password
            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOP0123456789!Q@#'*+~´`";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);

            }
            txtPassword.Text = result.ToString();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            //Closes the application after a click on the close pic
            Application.Exit();
        }

        private void bnt_Copy_Click(object sender, EventArgs e)
        {
            //Sets the password in the Password Textbox to the clipboard and checks if the password textbox is empty
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Cant find password!", "Simple Password gen for github", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clipboard.SetText(txtPassword.Text);
            }
        }
    }
}
