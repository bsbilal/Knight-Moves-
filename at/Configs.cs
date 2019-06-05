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
    public partial class FormConfigs : Form
    {
        
        public FormConfigs()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int giden = 0;
            if (rdAlti.Checked == true) giden = 6;
            if (rdBes.Checked == true) giden = 5;
            if (rdYedi.Checked == true) giden = 7;
            if (rdSekiz.Checked == true) giden = 8;
            if (rdDokuz.Checked == true) giden = 9;
            FormGame.g_Kare = giden;
            this.Close();


        }

        private void Configs_Load(object sender, EventArgs e)
        {

        }
    }
}
