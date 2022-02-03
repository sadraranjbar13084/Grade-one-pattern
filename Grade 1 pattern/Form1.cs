using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_1_pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            lblabout.Text = "طراح و برنامه نویس:صدرا رنجبر" +
			"
			"
                "تاریخ:2 فوریه 2022";
             
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int Deltanum1 = (int)(num2.Value - num1.Value);
            int Deltanum2 = (int)(num3.Value - num2.Value);

            if(Deltanum1 == Deltanum2)
            {
                int number = (int)(num1.Value - Deltanum1);
                string general = $"{Deltanum1}n+{number}";
                lblgen2.Text = general; 
            }
            else
            {
                lblgen2.Text = "این الگو درجه یک نیست.الگویی درجه یک وارد کنید.باتشکر";
            }
        }
    }
}
