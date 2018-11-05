namespace Batalha_Naval
{
    partial class FormUXdesign
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUXdesign));
            this.textBoxEnterName = new System.Windows.Forms.TextBox();
            this.labelPlayerTurn = new System.Windows.Forms.Label();
            this.labelPlayerA = new System.Windows.Forms.Label();
            this.labelPlayerB = new System.Windows.Forms.Label();
            this.panelGridPlayerA = new System.Windows.Forms.Panel();
            this.labelColumn1_P1 = new System.Windows.Forms.Label();
            this.labellabelColumn2_P1 = new System.Windows.Forms.Label();
            this.labelColumn3_P1 = new System.Windows.Forms.Label();
            this.labelColumn4_P1 = new System.Windows.Forms.Label();
            this.labelColumn5_P1 = new System.Windows.Forms.Label();
            this.labelColumn6_P1 = new System.Windows.Forms.Label();
            this.labelColumn7_P1 = new System.Windows.Forms.Label();
            this.labelColumn8_P1 = new System.Windows.Forms.Label();
            this.labelColumn9_P1 = new System.Windows.Forms.Label();
            this.labelColumn10_P1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelColumnJ_P1 = new System.Windows.Forms.Label();
            this.labelColumnI_P1 = new System.Windows.Forms.Label();
            this.labelColumnH_P1 = new System.Windows.Forms.Label();
            this.labelColumnG_P1 = new System.Windows.Forms.Label();
            this.labelColumnF_P1 = new System.Windows.Forms.Label();
            this.labelColumnE_P1 = new System.Windows.Forms.Label();
            this.labelColumnD_P1 = new System.Windows.Forms.Label();
            this.labelColumnC_P1 = new System.Windows.Forms.Label();
            this.labelColumnB_P1 = new System.Windows.Forms.Label();
            this.labelColumnA_P1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelColumnJ_P2 = new System.Windows.Forms.Label();
            this.labelColumnI_P2 = new System.Windows.Forms.Label();
            this.labelColumnH_P2 = new System.Windows.Forms.Label();
            this.labelColumnG_P2 = new System.Windows.Forms.Label();
            this.labelColumnF_P2 = new System.Windows.Forms.Label();
            this.labelColumnE_P2 = new System.Windows.Forms.Label();
            this.labelColumnD_P2 = new System.Windows.Forms.Label();
            this.labelColumnC_P2 = new System.Windows.Forms.Label();
            this.labelColumnB_P2 = new System.Windows.Forms.Label();
            this.labelColumnA_P2 = new System.Windows.Forms.Label();
            this.labelColumn1_P2 = new System.Windows.Forms.Label();
            this.panelGridPlayerB = new System.Windows.Forms.Panel();
            this.labelColumn10_P2 = new System.Windows.Forms.Label();
            this.labelColumn2_P2 = new System.Windows.Forms.Label();
            this.labelColumn9_P2 = new System.Windows.Forms.Label();
            this.labelColumn3_P2 = new System.Windows.Forms.Label();
            this.labelColumn8_P2 = new System.Windows.Forms.Label();
            this.labelColumn4_P2 = new System.Windows.Forms.Label();
            this.labelColumn7_P2 = new System.Windows.Forms.Label();
            this.labelColumn5_P2 = new System.Windows.Forms.Label();
            this.labelColumn6_P2 = new System.Windows.Forms.Label();
            this.textBoxTimerPlayerB = new System.Windows.Forms.TextBox();
            this.textBoxTimerPlayerA = new System.Windows.Forms.TextBox();
            this.checkBoxTimedGame = new System.Windows.Forms.CheckBox();
            this.timerPlayerA = new System.Windows.Forms.Timer(this.components);
            this.timerPlayerB = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxEnterNameP2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEnterName
            // 
            this.textBoxEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxEnterName.Location = new System.Drawing.Point(188, 432);
            this.textBoxEnterName.Name = "textBoxEnterName";
            this.textBoxEnterName.Size = new System.Drawing.Size(432, 23);
            this.textBoxEnterName.TabIndex = 0;
            this.textBoxEnterName.Text = "Inserir Nome do Jogador 1";
            this.textBoxEnterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEnterName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEnterName_KeyDown);
            // 
            // labelPlayerTurn
            // 
            this.labelPlayerTurn.AutoSize = true;
            this.labelPlayerTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPlayerTurn.Location = new System.Drawing.Point(373, 37);
            this.labelPlayerTurn.Name = "labelPlayerTurn";
            this.labelPlayerTurn.Size = new System.Drawing.Size(52, 19);
            this.labelPlayerTurn.TabIndex = 1;
            this.labelPlayerTurn.Text = "Turno:";
            // 
            // labelPlayerA
            // 
            this.labelPlayerA.AutoSize = true;
            this.labelPlayerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPlayerA.ForeColor = System.Drawing.Color.Red;
            this.labelPlayerA.Location = new System.Drawing.Point(8, 37);
            this.labelPlayerA.Name = "labelPlayerA";
            this.labelPlayerA.Size = new System.Drawing.Size(73, 17);
            this.labelPlayerA.TabIndex = 2;
            this.labelPlayerA.Text = "Jogador A";
            // 
            // labelPlayerB
            // 
            this.labelPlayerB.AutoSize = true;
            this.labelPlayerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPlayerB.ForeColor = System.Drawing.Color.Blue;
            this.labelPlayerB.Location = new System.Drawing.Point(711, 37);
            this.labelPlayerB.Name = "labelPlayerB";
            this.labelPlayerB.Size = new System.Drawing.Size(73, 17);
            this.labelPlayerB.TabIndex = 3;
            this.labelPlayerB.Text = "Jogador B";
            this.labelPlayerB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelGridPlayerA
            // 
            this.panelGridPlayerA.BackColor = System.Drawing.Color.DarkRed;
            this.panelGridPlayerA.Location = new System.Drawing.Point(42, 30);
            this.panelGridPlayerA.Name = "panelGridPlayerA";
            this.panelGridPlayerA.Size = new System.Drawing.Size(301, 301);
            this.panelGridPlayerA.TabIndex = 4;
            this.panelGridPlayerA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGridPlayerA_Paint);
            // 
            // labelColumn1_P1
            // 
            this.labelColumn1_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn1_P1.Location = new System.Drawing.Point(42, 0);
            this.labelColumn1_P1.Name = "labelColumn1_P1";
            this.labelColumn1_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumn1_P1.TabIndex = 6;
            this.labelColumn1_P1.Text = "1";
            this.labelColumn1_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labellabelColumn2_P1
            // 
            this.labellabelColumn2_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labellabelColumn2_P1.Location = new System.Drawing.Point(72, 0);
            this.labellabelColumn2_P1.Name = "labellabelColumn2_P1";
            this.labellabelColumn2_P1.Size = new System.Drawing.Size(30, 30);
            this.labellabelColumn2_P1.TabIndex = 7;
            this.labellabelColumn2_P1.Text = "2";
            this.labellabelColumn2_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn3_P1
            // 
            this.labelColumn3_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn3_P1.Location = new System.Drawing.Point(102, 0);
            this.labelColumn3_P1.Name = "labelColumn3_P1";
            this.labelColumn3_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumn3_P1.TabIndex = 8;
            this.labelColumn3_P1.Text = "3";
            this.labelColumn3_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn4_P1
            // 
            this.labelColumn4_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn4_P1.Location = new System.Drawing.Point(132, 0);
            this.labelColumn4_P1.Name = "labelColumn4_P1";
            this.labelColumn4_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumn4_P1.TabIndex = 9;
            this.labelColumn4_P1.Text = "4";
            this.labelColumn4_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn5_P1
            // 
            this.labelColumn5_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn5_P1.Location = new System.Drawing.Point(162, 0);
            this.labelColumn5_P1.Name = "labelColumn5_P1";
            this.labelColumn5_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumn5_P1.TabIndex = 10;
            this.labelColumn5_P1.Text = "5";
            this.labelColumn5_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn6_P1
            // 
            this.labelColumn6_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn6_P1.Location = new System.Drawing.Point(192, 0);
            this.labelColumn6_P1.Name = "labelColumn6_P1";
            this.labelColumn6_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumn6_P1.TabIndex = 11;
            this.labelColumn6_P1.Text = "6";
            this.labelColumn6_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn7_P1
            // 
            this.labelColumn7_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn7_P1.Location = new System.Drawing.Point(222, 0);
            this.labelColumn7_P1.Name = "labelColumn7_P1";
            this.labelColumn7_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumn7_P1.TabIndex = 12;
            this.labelColumn7_P1.Text = "7";
            this.labelColumn7_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn8_P1
            // 
            this.labelColumn8_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn8_P1.Location = new System.Drawing.Point(252, 0);
            this.labelColumn8_P1.Name = "labelColumn8_P1";
            this.labelColumn8_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumn8_P1.TabIndex = 13;
            this.labelColumn8_P1.Text = "8";
            this.labelColumn8_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn9_P1
            // 
            this.labelColumn9_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn9_P1.Location = new System.Drawing.Point(282, 0);
            this.labelColumn9_P1.Name = "labelColumn9_P1";
            this.labelColumn9_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumn9_P1.TabIndex = 14;
            this.labelColumn9_P1.Text = "9";
            this.labelColumn9_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn10_P1
            // 
            this.labelColumn10_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn10_P1.Location = new System.Drawing.Point(312, 0);
            this.labelColumn10_P1.Name = "labelColumn10_P1";
            this.labelColumn10_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumn10_P1.TabIndex = 15;
            this.labelColumn10_P1.Text = "10";
            this.labelColumn10_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelColumnJ_P1);
            this.groupBox1.Controls.Add(this.labelColumnI_P1);
            this.groupBox1.Controls.Add(this.labelColumnH_P1);
            this.groupBox1.Controls.Add(this.labelColumnG_P1);
            this.groupBox1.Controls.Add(this.labelColumnF_P1);
            this.groupBox1.Controls.Add(this.labelColumnE_P1);
            this.groupBox1.Controls.Add(this.labelColumnD_P1);
            this.groupBox1.Controls.Add(this.labelColumnC_P1);
            this.groupBox1.Controls.Add(this.labelColumnB_P1);
            this.groupBox1.Controls.Add(this.labelColumnA_P1);
            this.groupBox1.Controls.Add(this.labelColumn1_P1);
            this.groupBox1.Controls.Add(this.panelGridPlayerA);
            this.groupBox1.Controls.Add(this.labelColumn10_P1);
            this.groupBox1.Controls.Add(this.labellabelColumn2_P1);
            this.groupBox1.Controls.Add(this.labelColumn9_P1);
            this.groupBox1.Controls.Add(this.labelColumn3_P1);
            this.groupBox1.Controls.Add(this.labelColumn8_P1);
            this.groupBox1.Controls.Add(this.labelColumn4_P1);
            this.groupBox1.Controls.Add(this.labelColumn7_P1);
            this.groupBox1.Controls.Add(this.labelColumn5_P1);
            this.groupBox1.Controls.Add(this.labelColumn6_P1);
            this.groupBox1.Location = new System.Drawing.Point(11, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 356);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // labelColumnJ_P1
            // 
            this.labelColumnJ_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnJ_P1.Location = new System.Drawing.Point(13, 300);
            this.labelColumnJ_P1.Name = "labelColumnJ_P1";
            this.labelColumnJ_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumnJ_P1.TabIndex = 25;
            this.labelColumnJ_P1.Text = "J";
            this.labelColumnJ_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnI_P1
            // 
            this.labelColumnI_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnI_P1.Location = new System.Drawing.Point(13, 270);
            this.labelColumnI_P1.Name = "labelColumnI_P1";
            this.labelColumnI_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumnI_P1.TabIndex = 24;
            this.labelColumnI_P1.Text = "I";
            this.labelColumnI_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnH_P1
            // 
            this.labelColumnH_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnH_P1.Location = new System.Drawing.Point(13, 240);
            this.labelColumnH_P1.Name = "labelColumnH_P1";
            this.labelColumnH_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumnH_P1.TabIndex = 23;
            this.labelColumnH_P1.Text = "H";
            this.labelColumnH_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnG_P1
            // 
            this.labelColumnG_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnG_P1.Location = new System.Drawing.Point(13, 210);
            this.labelColumnG_P1.Name = "labelColumnG_P1";
            this.labelColumnG_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumnG_P1.TabIndex = 22;
            this.labelColumnG_P1.Text = "G";
            this.labelColumnG_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnF_P1
            // 
            this.labelColumnF_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnF_P1.Location = new System.Drawing.Point(13, 180);
            this.labelColumnF_P1.Name = "labelColumnF_P1";
            this.labelColumnF_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumnF_P1.TabIndex = 21;
            this.labelColumnF_P1.Text = "F";
            this.labelColumnF_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnE_P1
            // 
            this.labelColumnE_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnE_P1.Location = new System.Drawing.Point(13, 150);
            this.labelColumnE_P1.Name = "labelColumnE_P1";
            this.labelColumnE_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumnE_P1.TabIndex = 20;
            this.labelColumnE_P1.Text = "E";
            this.labelColumnE_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnD_P1
            // 
            this.labelColumnD_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnD_P1.Location = new System.Drawing.Point(13, 120);
            this.labelColumnD_P1.Name = "labelColumnD_P1";
            this.labelColumnD_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumnD_P1.TabIndex = 19;
            this.labelColumnD_P1.Text = "D";
            this.labelColumnD_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnC_P1
            // 
            this.labelColumnC_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnC_P1.Location = new System.Drawing.Point(13, 90);
            this.labelColumnC_P1.Name = "labelColumnC_P1";
            this.labelColumnC_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumnC_P1.TabIndex = 18;
            this.labelColumnC_P1.Text = "C";
            this.labelColumnC_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnB_P1
            // 
            this.labelColumnB_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnB_P1.Location = new System.Drawing.Point(13, 60);
            this.labelColumnB_P1.Name = "labelColumnB_P1";
            this.labelColumnB_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumnB_P1.TabIndex = 17;
            this.labelColumnB_P1.Text = "B";
            this.labelColumnB_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnA_P1
            // 
            this.labelColumnA_P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnA_P1.Location = new System.Drawing.Point(13, 30);
            this.labelColumnA_P1.Name = "labelColumnA_P1";
            this.labelColumnA_P1.Size = new System.Drawing.Size(30, 30);
            this.labelColumnA_P1.TabIndex = 16;
            this.labelColumnA_P1.Text = "A";
            this.labelColumnA_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.labelColumnJ_P2);
            this.groupBox2.Controls.Add(this.labelColumnI_P2);
            this.groupBox2.Controls.Add(this.labelColumnH_P2);
            this.groupBox2.Controls.Add(this.labelColumnG_P2);
            this.groupBox2.Controls.Add(this.labelColumnF_P2);
            this.groupBox2.Controls.Add(this.labelColumnE_P2);
            this.groupBox2.Controls.Add(this.labelColumnD_P2);
            this.groupBox2.Controls.Add(this.labelColumnC_P2);
            this.groupBox2.Controls.Add(this.labelColumnB_P2);
            this.groupBox2.Controls.Add(this.labelColumnA_P2);
            this.groupBox2.Controls.Add(this.labelColumn1_P2);
            this.groupBox2.Controls.Add(this.panelGridPlayerB);
            this.groupBox2.Controls.Add(this.labelColumn10_P2);
            this.groupBox2.Controls.Add(this.labelColumn2_P2);
            this.groupBox2.Controls.Add(this.labelColumn9_P2);
            this.groupBox2.Controls.Add(this.labelColumn3_P2);
            this.groupBox2.Controls.Add(this.labelColumn8_P2);
            this.groupBox2.Controls.Add(this.labelColumn4_P2);
            this.groupBox2.Controls.Add(this.labelColumn7_P2);
            this.groupBox2.Controls.Add(this.labelColumn5_P2);
            this.groupBox2.Controls.Add(this.labelColumn6_P2);
            this.groupBox2.Location = new System.Drawing.Point(432, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 356);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // labelColumnJ_P2
            // 
            this.labelColumnJ_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnJ_P2.Location = new System.Drawing.Point(13, 300);
            this.labelColumnJ_P2.Name = "labelColumnJ_P2";
            this.labelColumnJ_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumnJ_P2.TabIndex = 25;
            this.labelColumnJ_P2.Text = "J";
            this.labelColumnJ_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnI_P2
            // 
            this.labelColumnI_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnI_P2.Location = new System.Drawing.Point(13, 270);
            this.labelColumnI_P2.Name = "labelColumnI_P2";
            this.labelColumnI_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumnI_P2.TabIndex = 24;
            this.labelColumnI_P2.Text = "I";
            this.labelColumnI_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnH_P2
            // 
            this.labelColumnH_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnH_P2.Location = new System.Drawing.Point(13, 240);
            this.labelColumnH_P2.Name = "labelColumnH_P2";
            this.labelColumnH_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumnH_P2.TabIndex = 23;
            this.labelColumnH_P2.Text = "H";
            this.labelColumnH_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnG_P2
            // 
            this.labelColumnG_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnG_P2.Location = new System.Drawing.Point(13, 210);
            this.labelColumnG_P2.Name = "labelColumnG_P2";
            this.labelColumnG_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumnG_P2.TabIndex = 22;
            this.labelColumnG_P2.Text = "G";
            this.labelColumnG_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnF_P2
            // 
            this.labelColumnF_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnF_P2.Location = new System.Drawing.Point(13, 180);
            this.labelColumnF_P2.Name = "labelColumnF_P2";
            this.labelColumnF_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumnF_P2.TabIndex = 21;
            this.labelColumnF_P2.Text = "F";
            this.labelColumnF_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnE_P2
            // 
            this.labelColumnE_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnE_P2.Location = new System.Drawing.Point(13, 150);
            this.labelColumnE_P2.Name = "labelColumnE_P2";
            this.labelColumnE_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumnE_P2.TabIndex = 20;
            this.labelColumnE_P2.Text = "E";
            this.labelColumnE_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnD_P2
            // 
            this.labelColumnD_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnD_P2.Location = new System.Drawing.Point(13, 120);
            this.labelColumnD_P2.Name = "labelColumnD_P2";
            this.labelColumnD_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumnD_P2.TabIndex = 19;
            this.labelColumnD_P2.Text = "D";
            this.labelColumnD_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnC_P2
            // 
            this.labelColumnC_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnC_P2.Location = new System.Drawing.Point(13, 90);
            this.labelColumnC_P2.Name = "labelColumnC_P2";
            this.labelColumnC_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumnC_P2.TabIndex = 18;
            this.labelColumnC_P2.Text = "C";
            this.labelColumnC_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnB_P2
            // 
            this.labelColumnB_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnB_P2.Location = new System.Drawing.Point(13, 60);
            this.labelColumnB_P2.Name = "labelColumnB_P2";
            this.labelColumnB_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumnB_P2.TabIndex = 17;
            this.labelColumnB_P2.Text = "B";
            this.labelColumnB_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnA_P2
            // 
            this.labelColumnA_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumnA_P2.Location = new System.Drawing.Point(13, 30);
            this.labelColumnA_P2.Name = "labelColumnA_P2";
            this.labelColumnA_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumnA_P2.TabIndex = 16;
            this.labelColumnA_P2.Text = "A";
            this.labelColumnA_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn1_P2
            // 
            this.labelColumn1_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn1_P2.Location = new System.Drawing.Point(43, 0);
            this.labelColumn1_P2.Name = "labelColumn1_P2";
            this.labelColumn1_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumn1_P2.TabIndex = 6;
            this.labelColumn1_P2.Text = "1";
            this.labelColumn1_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGridPlayerB
            // 
            this.panelGridPlayerB.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelGridPlayerB.Location = new System.Drawing.Point(42, 30);
            this.panelGridPlayerB.Name = "panelGridPlayerB";
            this.panelGridPlayerB.Size = new System.Drawing.Size(301, 301);
            this.panelGridPlayerB.TabIndex = 4;
            this.panelGridPlayerB.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGridPlayerB_Paint);
            // 
            // labelColumn10_P2
            // 
            this.labelColumn10_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn10_P2.Location = new System.Drawing.Point(313, 0);
            this.labelColumn10_P2.Name = "labelColumn10_P2";
            this.labelColumn10_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumn10_P2.TabIndex = 15;
            this.labelColumn10_P2.Text = "10";
            this.labelColumn10_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn2_P2
            // 
            this.labelColumn2_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn2_P2.Location = new System.Drawing.Point(73, 0);
            this.labelColumn2_P2.Name = "labelColumn2_P2";
            this.labelColumn2_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumn2_P2.TabIndex = 7;
            this.labelColumn2_P2.Text = "2";
            this.labelColumn2_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn9_P2
            // 
            this.labelColumn9_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn9_P2.Location = new System.Drawing.Point(283, 0);
            this.labelColumn9_P2.Name = "labelColumn9_P2";
            this.labelColumn9_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumn9_P2.TabIndex = 14;
            this.labelColumn9_P2.Text = "9";
            this.labelColumn9_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn3_P2
            // 
            this.labelColumn3_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn3_P2.Location = new System.Drawing.Point(103, 0);
            this.labelColumn3_P2.Name = "labelColumn3_P2";
            this.labelColumn3_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumn3_P2.TabIndex = 8;
            this.labelColumn3_P2.Text = "3";
            this.labelColumn3_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn8_P2
            // 
            this.labelColumn8_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn8_P2.Location = new System.Drawing.Point(253, 0);
            this.labelColumn8_P2.Name = "labelColumn8_P2";
            this.labelColumn8_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumn8_P2.TabIndex = 13;
            this.labelColumn8_P2.Text = "8";
            this.labelColumn8_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn4_P2
            // 
            this.labelColumn4_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn4_P2.Location = new System.Drawing.Point(133, 0);
            this.labelColumn4_P2.Name = "labelColumn4_P2";
            this.labelColumn4_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumn4_P2.TabIndex = 9;
            this.labelColumn4_P2.Text = "4";
            this.labelColumn4_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn7_P2
            // 
            this.labelColumn7_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn7_P2.Location = new System.Drawing.Point(223, 0);
            this.labelColumn7_P2.Name = "labelColumn7_P2";
            this.labelColumn7_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumn7_P2.TabIndex = 12;
            this.labelColumn7_P2.Text = "7";
            this.labelColumn7_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn5_P2
            // 
            this.labelColumn5_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn5_P2.Location = new System.Drawing.Point(163, 0);
            this.labelColumn5_P2.Name = "labelColumn5_P2";
            this.labelColumn5_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumn5_P2.TabIndex = 10;
            this.labelColumn5_P2.Text = "5";
            this.labelColumn5_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumn6_P2
            // 
            this.labelColumn6_P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn6_P2.Location = new System.Drawing.Point(193, 0);
            this.labelColumn6_P2.Name = "labelColumn6_P2";
            this.labelColumn6_P2.Size = new System.Drawing.Size(30, 30);
            this.labelColumn6_P2.TabIndex = 11;
            this.labelColumn6_P2.Text = "6";
            this.labelColumn6_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTimerPlayerB
            // 
            this.textBoxTimerPlayerB.Enabled = false;
            this.textBoxTimerPlayerB.Location = new System.Drawing.Point(668, 412);
            this.textBoxTimerPlayerB.Name = "textBoxTimerPlayerB";
            this.textBoxTimerPlayerB.ReadOnly = true;
            this.textBoxTimerPlayerB.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimerPlayerB.TabIndex = 27;
            this.textBoxTimerPlayerB.Text = "00:00";
            this.textBoxTimerPlayerB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTimerPlayerA
            // 
            this.textBoxTimerPlayerA.Enabled = false;
            this.textBoxTimerPlayerA.Location = new System.Drawing.Point(42, 412);
            this.textBoxTimerPlayerA.Name = "textBoxTimerPlayerA";
            this.textBoxTimerPlayerA.ReadOnly = true;
            this.textBoxTimerPlayerA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimerPlayerA.TabIndex = 28;
            this.textBoxTimerPlayerA.Text = "00:00";
            this.textBoxTimerPlayerA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxTimedGame
            // 
            this.checkBoxTimedGame.AutoSize = true;
            this.checkBoxTimedGame.Location = new System.Drawing.Point(350, 461);
            this.checkBoxTimedGame.Name = "checkBoxTimedGame";
            this.checkBoxTimedGame.Size = new System.Drawing.Size(101, 17);
            this.checkBoxTimedGame.TabIndex = 29;
            this.checkBoxTimedGame.Text = "Jogo com Timer";
            this.checkBoxTimedGame.UseVisualStyleBackColor = true;
            // 
            // timerPlayerA
            // 
            this.timerPlayerA.Interval = 60000;
            this.timerPlayerA.Tick += new System.EventHandler(this.timerPlayerA_Tick);
            // 
            // timerPlayerB
            // 
            this.timerPlayerB.Interval = 60000;
            this.timerPlayerB.Tick += new System.EventHandler(this.timerPlayerB_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(373, 186);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(57, 27);
            this.buttonStart.TabIndex = 30;
            this.buttonStart.Text = "Começar";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxEnterNameP2
            // 
            this.textBoxEnterNameP2.Enabled = false;
            this.textBoxEnterNameP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxEnterNameP2.Location = new System.Drawing.Point(188, 461);
            this.textBoxEnterNameP2.Name = "textBoxEnterNameP2";
            this.textBoxEnterNameP2.Size = new System.Drawing.Size(432, 23);
            this.textBoxEnterNameP2.TabIndex = 31;
            this.textBoxEnterNameP2.Text = "Inserir Nome do Jogador 2";
            this.textBoxEnterNameP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEnterNameP2.Visible = false;
            this.textBoxEnterNameP2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEnterNameP2_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogoToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.carregarToolStripMenuItem,
            this.reiniciarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.jogoToolStripMenuItem.Text = "Jogo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // carregarToolStripMenuItem
            // 
            this.carregarToolStripMenuItem.Name = "carregarToolStripMenuItem";
            this.carregarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.carregarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.carregarToolStripMenuItem.Text = "Carregar";
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Options";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormUXdesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.textBoxEnterNameP2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkBoxTimedGame);
            this.Controls.Add(this.textBoxTimerPlayerA);
            this.Controls.Add(this.textBoxTimerPlayerB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPlayerB);
            this.Controls.Add(this.labelPlayerA);
            this.Controls.Add(this.labelPlayerTurn);
            this.Controls.Add(this.textBoxEnterName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUXdesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UX Design";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEnterName;
        private System.Windows.Forms.Label labelPlayerTurn;
        private System.Windows.Forms.Label labelPlayerA;
        private System.Windows.Forms.Label labelPlayerB;
        private System.Windows.Forms.Panel panelGridPlayerA;
        private System.Windows.Forms.Label labelColumn1_P1;
        private System.Windows.Forms.Label labellabelColumn2_P1;
        private System.Windows.Forms.Label labelColumn3_P1;
        private System.Windows.Forms.Label labelColumn4_P1;
        private System.Windows.Forms.Label labelColumn5_P1;
        private System.Windows.Forms.Label labelColumn6_P1;
        private System.Windows.Forms.Label labelColumn7_P1;
        private System.Windows.Forms.Label labelColumn8_P1;
        private System.Windows.Forms.Label labelColumn9_P1;
        private System.Windows.Forms.Label labelColumn10_P1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelColumnA_P1;
        private System.Windows.Forms.Label labelColumnJ_P1;
        private System.Windows.Forms.Label labelColumnI_P1;
        private System.Windows.Forms.Label labelColumnH_P1;
        private System.Windows.Forms.Label labelColumnG_P1;
        private System.Windows.Forms.Label labelColumnF_P1;
        private System.Windows.Forms.Label labelColumnE_P1;
        private System.Windows.Forms.Label labelColumnD_P1;
        private System.Windows.Forms.Label labelColumnC_P1;
        private System.Windows.Forms.Label labelColumnB_P1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelColumnJ_P2;
        private System.Windows.Forms.Label labelColumnI_P2;
        private System.Windows.Forms.Label labelColumnH_P2;
        private System.Windows.Forms.Label labelColumnG_P2;
        private System.Windows.Forms.Label labelColumnF_P2;
        private System.Windows.Forms.Label labelColumnE_P2;
        private System.Windows.Forms.Label labelColumnD_P2;
        private System.Windows.Forms.Label labelColumnC_P2;
        private System.Windows.Forms.Label labelColumnB_P2;
        private System.Windows.Forms.Label labelColumnA_P2;
        private System.Windows.Forms.Label labelColumn1_P2;
        private System.Windows.Forms.Panel panelGridPlayerB;
        private System.Windows.Forms.Label labelColumn10_P2;
        private System.Windows.Forms.Label labelColumn2_P2;
        private System.Windows.Forms.Label labelColumn9_P2;
        private System.Windows.Forms.Label labelColumn3_P2;
        private System.Windows.Forms.Label labelColumn8_P2;
        private System.Windows.Forms.Label labelColumn4_P2;
        private System.Windows.Forms.Label labelColumn7_P2;
        private System.Windows.Forms.Label labelColumn5_P2;
        private System.Windows.Forms.Label labelColumn6_P2;
        private System.Windows.Forms.TextBox textBoxTimerPlayerB;
        private System.Windows.Forms.TextBox textBoxTimerPlayerA;
        private System.Windows.Forms.Timer timerPlayerA;
        private System.Windows.Forms.Timer timerPlayerB;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxEnterNameP2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.CheckBox checkBoxTimedGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

