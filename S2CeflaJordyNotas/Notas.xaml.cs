using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S2CeflaJordyNotas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notas : ContentPage
    {
        public Notas()
        {
            InitializeComponent();

        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            double dato1 = Convert.ToDouble(txtNota1.Text);
            double dato2 = Convert.ToDouble(txtExamen1.Text);
            double dato3 = Convert.ToDouble(txtParcial1.Text);
            double dato4 = Convert.ToDouble(txtNota2.Text);
            double dato5 = Convert.ToDouble(txtExamen2.Text);
            double dato6 = Convert.ToDouble(txtParcial2.Text);
            
            double A1    = dato1 * 0.20 ;
            double A2 = dato1 * 0.30;
            double A3 = A1 + A2;
            txtParcial1.Text = A3.ToString();

            double A5 = dato4 * 0.20;
            double A6 = dato5 * 0.30;
            double A7 = A5 + A6;
            txtParcial2.Text = A7.ToString();

            double A8 = A7 + A3;
            txtNotaFinal.Text = A8.ToString();

            if (A8 >= 7)
            {
                DisplayAlert("Aprobado",A8 + ".\nFelicitaciones","ok");

            } else if (A8 >= 5 && A8<=6.9) 
            
            {
                DisplayAlert("Examen Complementario", A8 + ".\nComplementario", "ok");

            }
                else
                {

                DisplayAlert("Reprobado", A8 + ".\nGracias", "ok");

            }

        }
    }
}