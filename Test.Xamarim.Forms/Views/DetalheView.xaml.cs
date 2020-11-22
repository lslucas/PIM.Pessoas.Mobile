using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test.Xamarim.Forms
{
    public partial class DetalheView : ContentPage
    {
        public Pessoas Pessoas { get; set; }

        public DetalheView(Pessoas pessoa)
        {
            this.Pessoas = pessoa;
            InitializeComponent();
            this.BindingContext = this;
        }

        private void botaoProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroView());
        }
    }
}
