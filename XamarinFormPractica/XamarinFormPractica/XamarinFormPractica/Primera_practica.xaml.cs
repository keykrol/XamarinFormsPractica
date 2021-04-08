using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormPractica
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Primera_practica : ContentPage
    {
        public Primera_practica()
        {
            InitializeComponent();
            slider.Value = 0.5;

           /* Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Hola mundo .cs"
            }; // se coloca esta forma cuando se desea trabajar un segmento de la interfaz de forma dinamica*/
        }

        /*private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Numero: {0:F2}", e.NewValue); // se obtiene un valor double entre el 1 y el 0, se le coloca el f2 para formatear a 2 decimales

        }
                <Slider x:Name="slider" ValueChanged="Slider_ValueChanged"></Slider>
*/
    }
}