using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cracha_NextTeamBr
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void Btm_Motorista_Click(object sender, EventArgs e)
        {
            Frm_Motorista frm_Motorista = new Frm_Motorista();

            frm_Motorista.Show();
        }

        private void Btm_Admin_Click(object sender, EventArgs e)
        {
            Frm_Administrador frm_admin = new Frm_Administrador();

            frm_admin.Show();
        }
    }
}
