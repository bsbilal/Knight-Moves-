using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightMoves
{

    public partial class FormGame : Form
    {

        public static int g_Kare = 5;
        public static int g_Tiklama = 1;
        public static bool[] g_IsGreen = new bool[81];
        public static int g_Score;

        public FormGame()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Green;
            button1.BackColor = Color.GhostWhite;

            button2.ForeColor = Color.Red;
            button2.BackColor = Color.GhostWhite;

            lblPossible.Visible = false;
            label1.Visible = false;
            lblSkor.Visible = false;
            xxxzxxassa.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPossible.Text = "1";
            lblSkor.Text = "0";
            g_Score = 0;
            xxxzxxassa.Visible = true;
            lblSkor.Visible = true;
            label1.Visible = true;
            lblPossible.Visible = true;


            for (int i = 0; i < 81; i++)
            {
                g_IsGreen[i] = false;

            }
            int satır = 0, sutun = 0;

            foreach (Control c in grpSqr.Controls)
            {
                if (c is Button)
                    grpSqr.Controls.Clear();
            }

            int sayac = 1;
            for (int i = 1; i <= g_Kare; i++)
            {
                for (int j = 1; j <= g_Kare; j++)
                {
                    Button Yeni = new Button();
                    Yeni.Top = sutun; //Yukarıdan bırakılacak mesafe
                    Yeni.Left = satır; //Soldan Bırakılacak mesaf
                    Yeni.Height = 30;  //Yüksekliği
                    Yeni.Width = 30; //Eni
                    Yeni.ForeColor = Color.Black;

                    
                    Yeni.BackColor = Color.Gray; //Rengi
                    grpSqr.Controls.Add(Yeni);
                    satır += 30;
                    Yeni.Click += Yeni_Click;
                    sayac++;
                }

                sutun += 30;
                satır = 0;
            }
        }
        void Yeni_Click(object sender, EventArgs e)
        {
            int possibleMoves = 0, mod1;
            int[] deger = new int[8];

            var whichbutton = (Button)sender;
            g_IsGreen[whichbutton.TabIndex] = true;
            mod1 = whichbutton.TabIndex % g_Kare;//3. karede 2 betiriyor 


            //-
            // |
            if (mod1 != 0 && whichbutton.TabIndex >= g_Kare * 2 )
                deger[0] = whichbutton.TabIndex - g_Kare * 2 - 2;
            else
                deger[0] = -5;
            //  -
            // |
            if (mod1 != g_Kare - 1 && whichbutton.TabIndex >= g_Kare * 2 )
                deger[1] = whichbutton.TabIndex - g_Kare * 2;
            else
                deger[1] = -5;

            // --
            //|
            if (mod1 != 0 && mod1 != 1 && whichbutton.TabIndex > g_Kare )
                deger[2] = whichbutton.TabIndex - g_Kare - 3;
            else
                deger[2] = -5;
            //--
            //  |
            if (mod1 != g_Kare - 1 && mod1 != g_Kare - 2 && whichbutton.TabIndex+1 > g_Kare)
                deger[3] = whichbutton.TabIndex - g_Kare + 1;
            else
                deger[3] = -5;
            //  |
            //--
            if (mod1 != 0 && mod1 != 1)
                deger[4] = whichbutton.TabIndex + g_Kare - 3;
            else
                deger[4] = -5;
            //|
            // --
            if (mod1 != g_Kare - 1 && mod1 != g_Kare - 2)
                deger[5] = whichbutton.TabIndex + g_Kare + 1;
            else
                deger[5] = -5;
            // |
            //-

            if (mod1 != 0)
                deger[6] = whichbutton.TabIndex + g_Kare * 2 - 2;
            else
                deger[6] = -5;
            //|
            // -

            if (mod1 != g_Kare - 1)
                deger[7] = whichbutton.TabIndex + g_Kare * 2;
            else
                deger[7] = -5;

            int j = 0;
            foreach (Control c in grpSqr.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = false;
                    if (g_IsGreen[j] == true)
                    {
                        c.BackColor = Color.Pink;

                        c.Enabled = false;
                    }
                    else
                        c.BackColor = Color.Red;

                }
                for (int i = 0; i < 8; i++)
                {
                    if (c is Button && c.TabIndex == deger[i] + 1 && g_IsGreen[deger[i] + 1] == false)
                    {
                        if (deger[i] == -5) continue;
                        c.BackColor = Color.Green;
                        c.Enabled = true;
                        possibleMoves++;

                    }
                }
                j++;
            }
            g_Score++;
            lblSkor.Text = g_Score.ToString();
            if(possibleMoves==0)
            {
                MessageBox.Show("Mevcut Hamle Kalmadı SKORUNUZ : "+g_Score);

            }
            lblPossible.Text = possibleMoves.ToString();
        }
   
        private void button2_Click_1(object sender, EventArgs e)
        {
            FormConfigs cfg = new FormConfigs();
            cfg.Show();
        }
    }
}
