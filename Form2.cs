using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batalha_Naval
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
        }

        private void groupBoxGameSpeed_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonCustomSpeed_Click(object sender, EventArgs e)
        {
            if (radioButtonCustomSpeed.Checked == true)
                textBoxGameSpeed.ReadOnly = false;
        }

        private void buttonApplyCustomTime_Click(object sender, EventArgs e)
        {
            int CustomTime;
            bool sucess = Int32.TryParse(textBoxGameSpeed.Text, out CustomTime);
            if (sucess == false)
            {
                textBoxGameSpeed.Text = "00:00";
                MessageBox.Show("Introduza um numero inteiro entre 1 e 300");
            }
            else
            {
                if (CustomTime >= 5 && CustomTime <= 300)
                {
                    textBoxGameSpeed.Text = textBoxGameSpeed.Text;
                    FormUXdesign formUXdesign = new FormUXdesign();
                    formUXdesign.timerPlayerB.Interval = CustomTime * 1000;
                    MessageBox.Show("Tempo definido para " + textBoxGameSpeed.Text + " segundos");
                }
            }
        }
    }
}
