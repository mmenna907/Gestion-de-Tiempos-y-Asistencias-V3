using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infra.CrossCutting;
using Aplication;

namespace UI.Desktop.Forms
{
    public partial class BienvenidoFrm : Form
    {
        public BienvenidoFrm()
        {
            InitializeComponent();
        }        

        private void BienvenidoFrm_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = SesionService.Instancia.ObtenerNombreUsuario();
            this.Opacity = 0.00;
            timerFadeIn.Start();
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
        }
        private void TimerFadeIn_Tick(object sender, EventArgs e)
        {
            //Este metodo se comporta como un bucle, que se repite cada 30 milisegundos
            if (this.Opacity < 1)            
                this.Opacity += 0.03;//Aumento la opacidad hasta llegar a 1
            circularProgressBar1.Value++;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100 )//van a transcurrir 100*30milisegundos= 3000 milisegundos es decir 3 segundos
            {
                timerFadeIn.Stop();
                timerFadeOut.Start();
            }
        }

        private void TimerFadeOut_Tick(object sender, EventArgs e)
        {
            //se comporta como un bucle 
            this.Opacity -= 0.1;
            if (this.Opacity == 0)//Lo vuelvo a trasparentar en 0.3 segundos
            {
                timerFadeOut.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }


    }
}
