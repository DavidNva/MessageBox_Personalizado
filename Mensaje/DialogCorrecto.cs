using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensaje
{
    public partial class DialogCorrecto : Form
    {
        public DialogCorrecto(string tipoObjeto, string mensaje)
        {
            InitializeComponent();
            lblTipoObjeto.Text = tipoObjeto;
            lblMensaje.Text = mensaje;
        }

        private void DialogCorrecto_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            icon_delay.Start();
            icono.Enabled = true;
        }

        private void icon_delay_Tick(object sender, EventArgs e)
        {
            icono.Enabled = false;
            icon_delay.Stop();
            btnOK.Visible = true;
            //lblTipoObjeto.Visible = true;
            //lblMensaje.Visible = true;
        }

        private void DialogCorrecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnOK_Click(sender, e);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void MostrarDialogo(string tipoObjeto, string mensaje)
        {
            DialogCorrecto dialogo = new DialogCorrecto(tipoObjeto,mensaje);
            dialogo.ShowDialog();
        }
    }
}
