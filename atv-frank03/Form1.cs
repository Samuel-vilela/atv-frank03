using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv_frank03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            int idadePessoal1 = Convert.ToInt32(txtBoxIdade1.Text);
            int idadePessoal2 = Convert.ToInt32(txtBoxIdade2.Text);
            int idadePessoal3 = Convert.ToInt32(txtBoxIdade3.Text);

            double mediaIdades = (idadePessoal1 + idadePessoal2 + idadePessoal3) / 3;
            string mediaIdadeStr = mediaIdades.ToString();

            labelresult.Text = mediaIdadeStr;   
        }
    }
}