using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rtoasaS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string datoUno = txtDato.Text;
            string datoDos = txtDatoDos.Text;

            //Abrir ventana Registro
            Navigation.PushAsync(new Registro(datoUno, datoDos));
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}