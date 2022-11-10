using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal n1;
        private decimal n2;
        private decimal res;
        private decimal contador;


        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            //logica del juego

            //ramdon
            Random r = new Random();
            
            //facil
            if(rb_facil.Checked == true)
            {
                n1 = r.Next(0,10);
                n2 = r.Next(0, 10);
                res = n1 + n2;

                lb_n1.Text = n1.ToString();
                lb_r.Text = res.ToString();
            }

            //medio

            if (rb_medio.Checked == true)
            {
                n1 = r.Next(0, 100);
                n2 = r.Next(0, 100);
                res = n1 + n2;

                lb_n1.Text = n1.ToString();
                lb_r.Text = res.ToString();
            }

            //dificil

            if (rb_dificil.Checked == true)
            {
                n1 = r.Next(0, 1000);
                n2 = r.Next(0, 1000);
                res = n1 + n2;

                lb_n1.Text = n1.ToString();
                lb_r.Text = res.ToString();
            }

        }

        private void btn_comprobar_Click(object sender, EventArgs e)
        {
            if(nud_n2.Value == n2)
            {
                nud_n2.ForeColor = Color.Black;
                nud_n2.Value= 0;
                contador += 1;
                lb_puntos.Text = $"Puntos {contador}";
                btn_iniciar_Click(sender, e);
            }
            else
            {
                nud_n2.ForeColor = Color.Red;
            }
        }
    }
}
