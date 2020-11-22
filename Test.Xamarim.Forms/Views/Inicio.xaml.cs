using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test.Xamarim.Forms
{
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void botaoLista_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new List());
        }

        private void botaoNovo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroView());
        }

    }
}
