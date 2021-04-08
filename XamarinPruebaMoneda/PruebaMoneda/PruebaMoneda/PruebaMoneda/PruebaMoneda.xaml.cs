using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebaMoneda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PruebaMoneda : ContentPage
    {
        public PruebaMoneda()
        {
            InitializeComponent();

            List<Data> myData = new List<Data>();
            myData.Add(new Data { Name = "this is red color", ColorNumber = 1 });
            myData.Add(new Data { Name = "this is green color", ColorNumber = 2 });
            myData.Add(new Data { Name = "this is orange color", ColorNumber = 3 });
            myData.Add(new Data { Name = "this is blue color", ColorNumber = 4 });
            myData.Add(new Data { Name = "this is violate color", ColorNumber = 5 });

            listData.ItemsSource = myData;
        }

    }
    public class Data
    {

        public string Name { get; set; }
        public int ColorNumber { get; set; }
    }
}