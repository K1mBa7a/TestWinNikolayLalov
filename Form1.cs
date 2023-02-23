using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinNikolayLalov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            if (Frstn.Text == " ")
            {
                MessageBox.Show("You do not fill the empy side for the First Name");
            }
            if (Scndn.Text == " ")
            {
                MessageBox.Show("You do not fill the empy side for the Second Name");
            }
            if (Lstn.Text == " ")
            {
                MessageBox.Show("You do not fill the empy side for the Last Name");
            }
            if (ID.Text == " ")
            {
                MessageBox.Show("You do not fill the empy side for the ID");
            }
            if (textBox1.Text == " ")
            {
                MessageBox.Show("You do not fill the empy side for the job");
            }
            if (ID.Text.Length==10)
            {
                MessageBox.Show("ok 10 symbols");
            }
            if (ID.Text.Length >= 10&&ID.Text.Length<=10)
            {
                MessageBox.Show("cant be lower or higher than 10");
            }
            if (MaleOrFemale.Checked)
            {
                MessageBox.Show("male");

            }
            else
            {
                MessageBox.Show("female");
            }

            DialogResult RegisterInfo = MessageBox.Show($"your name {Frstn.Text}{Scndn.Text}{Lstn.Text}");
            if (RegisterInfo==DialogResult.OK)
            {
                Frstn.Text = "";
                Scndn.Text = "";
                Lstn.Text= " ";

            
            }
        }
    }
}
