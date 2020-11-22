using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test.Xamarim.Forms
{
    public class Endereco
    {
        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string CEP { get; set; }

        public string UF { get; set; }
    }
    public class Pessoas
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public Endereco Endereco { get; set; }
        public string Telefones { get; set; }
        public string EnderecoFormatado
        {
            get
            {
                return string.Format("{0}, {1} - {2}, {3}/{4}", Endereco.Logradouro, Endereco.Numero, Endereco.Bairro, Endereco.Cidade, Endereco.UF);
            }
        }

        public FormattedString PessoaLabel
        {
            get
            {
                return new FormattedString
                {
                    Spans = {
                        new Span { Text = Nome },
                        new Span { Text = " | " },
                        new Span { Text = CPF, FontAttributes = FontAttributes.Italic, FontSize = 9 }}
                };
            }
            set { }
        }
    }

    public partial class List : ContentPage
    {
        public List<Pessoas> Pessoas { get; set; }
        public List()
        {
            InitializeComponent();

            Endereco Enderecos = new Endereco();
            Enderecos.Logradouro = "Av. Miguel Yunes";
            Enderecos.Numero = 455;
            Enderecos.Bairro = "Usina Piratininga";
            Enderecos.CEP = "04444-000";
            Enderecos.Cidade = "São Paulo";
            Enderecos.UF = "SP";

            this.Pessoas = new List<Pessoas>()
            {
                new Pessoas { Nome = "Lucas Serafim", CPF = "37089327817", Endereco = Enderecos},
                new Pessoas { Nome = "Bruno Serafim", CPF = "08124017867", Endereco = Enderecos },
                new Pessoas { Nome = "Khatia Alexzandra", CPF = "250234929119", Endereco = Enderecos },
                new Pessoas { Nome = "Fulano", CPF = "37089327211", Endereco = Enderecos },
            };

            this.BindingContext = this;
        }

        private void listPessoas_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var pessoas = (Pessoas)e.Item;

            Navigation.PushAsync(new DetalheView(pessoas));
        }

        private void botaoNovo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroView());
        }

    }
}
