using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PsuDropCalculator : Form
    {
        double DNR, MesetaRate, AreaRate, ItemRate, SpecialRate, Result, Result1, Result2, Result3, Result0;

        private void button1_Click(object sender, EventArgs e)
        {
            DNR = Convert.ToDouble(txtDNR.Text);
            MesetaRate = Convert.ToDouble(txtMesetaRate.Text);
            AreaRate = Convert.ToDouble(txtAreaRate.Text);
            ItemRate = Convert.ToDouble(txtItemRate.Text);
            SpecialRate = Convert.ToDouble(txtSpecialRate.Text);
            Result = (double)MesetaRate / 100 * 50000;
            Result1 = AreaRate / 100 * 50000;
            Result2 = (double)ItemRate / 100 * 50000;
            Result3 = (double)SpecialRate / 100 * 50000;
            Result0 = DNR - Result - Result1 - Result2 - Result3;
            txtResult1.Text = "[ " + Result0.ToString() + ", " + Result.ToString() + ", " + Result1.ToString() + ", " + Result2.ToString() + ", " + Result3.ToString() + " ]";
        }

        public PsuDropCalculator()
        {
            InitializeComponent();
        }
    }
}
