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

        private void Options_Activated(object sender, EventArgs e)
        {
            /*FormUXdesign formUXdesign = new FormUXdesign();
            formUXdesign.Close();
            groupBoxGameSpeed.Enabled = formUXdesign.getTimedGame();*/
        }

        private void groupBoxGameSpeed_EnabledChanged(object sender, EventArgs e)
        {
            FormUXdesign formUXdesign = new FormUXdesign();
            if (formUXdesign.checkBoxTimedGame.Enabled == true)
            {
                groupBoxGameSpeed.Enabled = true;
                radioButtonNormalGame.Checked = true;
            }
            if (formUXdesign.checkBoxTimedGame.Enabled == false)
            {
                groupBoxGameSpeed.Enabled = false;
            }
        }
    }
}
