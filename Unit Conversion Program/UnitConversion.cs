using System;
using System.Windows.Forms;

namespace UnitConversion
{
    public partial class UnitConversion : Form
    {
        public UnitConversion()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = int.Parse(textBox1.Text) * 2.54 + "센티미터";
            }
            if (radioButton2.Checked)
            {
                label1.Text = int.Parse(textBox1.Text) * 0.453592 + "킬로그램";
            }
        }
    }
}
