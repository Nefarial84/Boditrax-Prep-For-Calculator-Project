using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prep_For_Calculator_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber;
            int secondNumber;
            int thirdnumber;
            int answer;

            firstTextBoxNumber = int.Parse(textBox1.Text);
            secondNumber = int.Parse(textBox2.Text);
            thirdnumber = int.Parse(textBox3.Text);

            //Exercise Logic - Uncoment Logic based on question

           //answer = (firstTextBoxNumber + secondNumber) - thirdnumber;
           //answer = (firstTextBoxNumber - secondNumber) * thirdnumber;
           //answer = firstTextBoxNumber * (secondNumber - thirdnumber);
           answer = (firstTextBoxNumber / secondNumber) + thirdnumber;

            MessageBox.Show(answer.ToString(), "Text Box Number", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Check out my text box logic", "Stepping up", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
