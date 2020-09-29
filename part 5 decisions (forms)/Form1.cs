using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_5_decisions__forms_
{
    public partial class frmRandomDivisible : Form
    {
        Random generator = new Random();







        public frmRandomDivisible()
        {
            InitializeComponent();
        }




        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int min = 1;
            int max = 7;
            int number = Convert.ToInt32(txtboxAnswer.Text);
            int sum;
            int randomnum = generator.Next();


            sum = number % randomnum;

            lblResult.Text = ($"{ sum }");






        }

        private void frmRandomDivisible_Load(object sender, EventArgs e)
        {
            int min = 1;
            int max = 7;
            lblInstructions.Text = generator.Next(min, max) + "";





        }






    }
}
