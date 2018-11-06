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
    public partial class FormStrategyPlayerA : Form
    {
        public FormStrategyPlayerA()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void panelAirCarrierExample_Paint(object sender, PaintEventArgs e)
        {
            Graphics Carrier_Grid = e.Graphics;
            int BlockSize = 30;
            Pen p = new Pen(Color.Black);
                Carrier_Grid.DrawLine(p, 0, BlockSize * 1, BlockSize, BlockSize * 1);
            Carrier_Grid.DrawLine(p, 0, BlockSize * 2, BlockSize, BlockSize * 2);
            Carrier_Grid.DrawLine(p, 0, BlockSize * 3, BlockSize, BlockSize * 3);
            Carrier_Grid.DrawLine(p, 0, BlockSize * 4, BlockSize, BlockSize * 4);
        }

        private void panelDestroyerExample_Paint(object sender, PaintEventArgs e)
        {
            Graphics Destroyer_Grid = e.Graphics;
            int BlockSize = 30;
            Pen p = new Pen(Color.Black);
            Destroyer_Grid.DrawLine(p, 0, BlockSize * 1, BlockSize, BlockSize * 1);
        }

        private void panelBattleshipExample_Paint(object sender, PaintEventArgs e)
        {
            Graphics Battleship_Grid = e.Graphics;
            int BlockSize = 30;
            Pen p = new Pen(Color.Black);
            Battleship_Grid.DrawLine(p, 0, BlockSize * 1, BlockSize, BlockSize * 1);
            Battleship_Grid.DrawLine(p, 0, BlockSize * 2, BlockSize, BlockSize * 2);
            Battleship_Grid.DrawLine(p, 0, BlockSize * 3, BlockSize, BlockSize * 3);
        }

        private void panelCruiserExample_Paint(object sender, PaintEventArgs e)
        {
            Graphics Cruiser_Grid = e.Graphics;
            int BlockSize = 30;
            Pen p = new Pen(Color.Black);
            Cruiser_Grid.DrawLine(p, 0, BlockSize * 1, BlockSize, BlockSize * 1);
            Cruiser_Grid.DrawLine(p, 0, BlockSize * 2, BlockSize, BlockSize * 2);
        }

        private void panelSubmarineExample_Paint(object sender, PaintEventArgs e)
        {
            Graphics Submarine_Grid = e.Graphics;
            int BlockSize = 30;
            Pen p = new Pen(Color.Black);
            Submarine_Grid.DrawLine(p, 0, BlockSize * 1, BlockSize, BlockSize * 1);
            Submarine_Grid.DrawLine(p, 0, BlockSize * 2, BlockSize, BlockSize * 2);
        }
    }
}
