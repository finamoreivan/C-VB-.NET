using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Numero = 1;
        int Vuelta = 1;

        Random random = new Random();
        private int NumeroDado()
        {
            int numero_azar = random.Next(0, 5);
            return numero_azar;
        }

        private void Cubilete_Click(object sender, EventArgs e)
        {
            CambiaDado(Dado1);
            CambiaDado(Dado2);
            CambiaDado(Dado3);
            CambiaDado(Dado4);
            CambiaDado(Dado5);

            String Turno = "Tiro número " + Numero + " de la vuelta " + Vuelta +" realizado";
            MessageBox.Show(Turno);
            Numero += 1;
            if (Numero > 3)
            {
                Numero = 1;
                Vuelta += 1;
            }
            if (Vuelta == 11)
            {
                Juego_Completado final = new Juego_Completado();
                final.ShowDialog();
            }

        }
        private void CambiaDado(PictureBox DadoX)
        {
            int numero = NumeroDado();
            switch (numero)
            {
                case 1: DadoX.Image = Properties.Resources.dado1; 
                    break;
                case 2: DadoX.Image = Properties.Resources.dado2; 
                    break;
                case 3: DadoX.Image = Properties.Resources.dado3; 
                    break;
                case 4: DadoX.Image = Properties.Resources.dado4; 
                    break;
                case 5: DadoX.Image = Properties.Resources.dado5; 
                    break;
                case 6: DadoX.Image = Properties.Resources.dado6; 
                    break;
            }
        }
    }
}
