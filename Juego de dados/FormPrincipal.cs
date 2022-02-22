using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Juego_de_dados
{
    public partial class FormPrincipal : Form
    {
        public static int variable;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_aceptarprin_Click(object sender, EventArgs e)
        {
            if (rb_jugador1.Checked)
            {
                variable = int.Parse(rb_jugador1.Text);
            }

            if (rb_jugador2.Checked)
            {
                variable = int.Parse(rb_jugador2.Text);
            }
            if (rb_jugador3.Checked)
            {
                variable = int.Parse(rb_jugador3.Text);
            }

            Form1 abrir = new Form1();

            abrir.Visible = true;

            this.Hide();
        }
    }
}
