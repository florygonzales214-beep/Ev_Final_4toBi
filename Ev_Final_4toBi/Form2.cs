using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            Byte Var1 = Byte.Parse(TextVar1.Text);
            Byte Var2 = Byte.Parse(TextVar2.Text);
            int producto = Var1 * Var2;
            MessageBox.Show("El Resultado es" + producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Byte Var1 = Byte.Parse(TextVar1.Text);
            Byte Var2 = Byte.Parse(TextVar2.Text);
            int suma = Var1 + Var2;
            MessageBox.Show("Elm resultado es" + suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int Var1 = int.Parse(TextVar1.Text);
            int Var2 = int.Parse(TextVar2.Text);
            int potencia = 1;
            int J = 0;
            while (J != Var2) ;
            {
                potencia = potencia * Var2;
                J++;
            }
            MessageBox.Show("El resultado es" + potencia);




        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float Var1 = float.Parse(TextVar1.Text);
            float Var2 = float.Parse(TextVar2.Text);
            if (Var2 > 0) 
            {
                float Division = Var1 / Var2;
                MessageBox.Show("El resultado es" + Division);
            }
            else
            {
                MessageBox.Show("No se puede dividir entre 0");
           


            }



            }
    }
}
