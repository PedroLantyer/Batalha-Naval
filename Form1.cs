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
    public partial class FormUXdesign : Form
    {

        public FormUXdesign()
        {
            InitializeComponent();
        }

        private void panelGridPlayerA_Paint(object sender, PaintEventArgs e)
        {
            Graphics PlayerA_Grid = e.Graphics;
            int NumOfBlocks = 10;
            int BlockSize = 30;
            Pen p = new Pen(Color.Black);

            for (int y = 0; y < NumOfBlocks; y++)
            {
                PlayerA_Grid.DrawLine(p, 0, y * BlockSize, NumOfBlocks * BlockSize, y * BlockSize);
            }

            for (int x = 0; x < NumOfBlocks; x++)
            {
                PlayerA_Grid.DrawLine(p, x * BlockSize, 0, x * BlockSize, NumOfBlocks * BlockSize);
            }

            for (int y = 0; y < NumOfBlocks; y++)
            {
                PlayerA_Grid.DrawLine(p, BlockSize * NumOfBlocks, y * BlockSize, 0, y * BlockSize);
            }

                PlayerA_Grid.DrawLine(p, NumOfBlocks * BlockSize, 0, NumOfBlocks * BlockSize, NumOfBlocks * BlockSize);
                PlayerA_Grid.DrawLine(p, BlockSize * NumOfBlocks, BlockSize * NumOfBlocks, 0, NumOfBlocks * BlockSize);
        }

        private void panelGridPlayerB_Paint(object sender, PaintEventArgs e)
        {
            Graphics PlayerB_Grid = e.Graphics;
            int NumOfBlocks = 10;
            int BlockSize = 30;
            Pen p = new Pen(Color.Black);

            for (int y = 0; y < NumOfBlocks; y++)
            {
                PlayerB_Grid.DrawLine(p, 0, y * BlockSize, NumOfBlocks * BlockSize, y * BlockSize);
            }

            for (int x = 0; x < NumOfBlocks; x++)
            {
                PlayerB_Grid.DrawLine(p, x * BlockSize, 0, x * BlockSize, NumOfBlocks * BlockSize);
            }

            for (int y = 0; y < NumOfBlocks; y++)
            {
                PlayerB_Grid.DrawLine(p, BlockSize * NumOfBlocks, y * BlockSize, 0, y * BlockSize);
            }

            PlayerB_Grid.DrawLine(p, NumOfBlocks * BlockSize, 0, NumOfBlocks * BlockSize, NumOfBlocks * BlockSize);
            PlayerB_Grid.DrawLine(p, BlockSize * NumOfBlocks, BlockSize * NumOfBlocks, 0, NumOfBlocks * BlockSize);
        }

        private void textBoxEnterName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (textBoxEnterName.Text != "" && textBoxEnterName.Text != "Introduza o Nome do Jogador 1")
                {
                    labelPlayerA.Text = textBoxEnterName.Text;
                    textBoxEnterName.Enabled = false;
                    textBoxEnterName.Visible = false;
                    textBoxEnterNameP2.Enabled = true;
                    textBoxEnterNameP2.Visible = true;
                    Select(true, true);
                }
    }

        private void textBoxEnterNameP2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (textBoxEnterNameP2.Text != "" && textBoxEnterName.Text != "Introduza o Nome do Jogador 2")
                {
                    labelPlayerB.Text = textBoxEnterNameP2.Text;
                    textBoxEnterNameP2.Enabled = false;
                    textBoxEnterNameP2.Visible = false;
                    buttonStart.Enabled = true;
                    buttonStart.Visible = true;
                }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Options form2 = new Options();
            form2.ShowDialog();
            form2.Close();
        }

        private void timerPlayerA_Tick(object sender, EventArgs e)
        {
            Options options = new Options();
            int CustomTime;
            Int32.TryParse(options.textBoxGameSpeed.Text, out CustomTime);
            if (options.radioButtonFastGame.Checked == true)
            {
                timerPlayerA.Interval = 30000;
            }
            if (options.radioButtonNormalGame.Checked == true)
            {
                timerPlayerA.Interval = 60000;
            }
            if (options.radioButtonSlowGame.Checked == true)
            {
                timerPlayerA.Interval = 90000;
            }
            if (options.radioButtonCustomSpeed.Checked == true)
            {
                timerPlayerA.Interval = CustomTime * 1000;
            }
        }

        private void timerPlayerB_Tick(object sender, EventArgs e)
        {
            Options options = new Options();
            int CustomTime;
            Int32.TryParse(options.textBoxGameSpeed.Text, out CustomTime);
            if (options.radioButtonFastGame.Checked == true)
            {
                timerPlayerB.Interval = 30000;
            }
            if (options.radioButtonNormalGame.Checked == true)
            {
                timerPlayerB.Interval = 60000;
            }
            if (options.radioButtonSlowGame.Checked == true)
            {
                timerPlayerB.Interval = 90000;
            }
            if (options.radioButtonCustomSpeed.Checked == true)
            {
                timerPlayerB.Interval = CustomTime * 1000;
            }
            }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (checkBoxTimedGame.Checked == true)
            {
                timerPlayerA.Enabled = true;
                timerPlayerB.Enabled = true;
            }
            if (checkBoxTimedGame.Checked == false)
            {
                timerPlayerA.Enabled = false;
                timerPlayerB.Enabled = false;
            }
        }

        /* public bool getTimedGame()
         {
             if (checkBoxTimedGame.Checked == true)
             {
                 bool TimedGame = true;
                 return TimedGame;
             }
             else
             {
                 bool TimedGame = false;
                 return TimedGame;
             }
         }*/

    }
    }
