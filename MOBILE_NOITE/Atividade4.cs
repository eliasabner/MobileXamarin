using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MOBILE_NOITE
{
    [Activity(Label = "Atividade4")]
    public class Atividade4 : Activity
    {
        Spinner spinner;
        ArrayAdapter arrayAdapter;
        string mostra;
        EditText nome,senha;
        Button cadastrar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Atividade4);
            spinner = FindViewById<Spinner>(Resource.Id.spAtiv4);
            nome = FindViewById<EditText>(Resource.Id.atv4_nome);
            senha = FindViewById<EditText>(Resource.Id.senhaAtv4);
            cadastrar = FindViewById<Button>(Resource.Id.ativ4Cadastar);

            
            // CRIAR UM ARRAY COM ITEM XML E COLOCAR NO ADAPTER
            arrayAdapter = ArrayAdapter.CreateFromResource(this,
                Resource.Array.estadoXML, Android.Resource.Layout.SimpleListItem1);
            // SE ADAPTAR AO SPINNER
            spinner.Adapter = arrayAdapter;
            spinner.ItemSelected += Spinner_ItemSelected;

            cadastrar.Click += Cadastrar_Click;

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Intent pag = new Intent(this,typeof(RecebeAtvidade4));

            Bundle dados = new Bundle();

            dados.PutString("nome",nome.Text);
            dados.PutString("estados", mostra.ToString());
            dados.PutString("senha", senha.Text);


            pag.PutExtras(dados);

            StartActivity(pag);


        }

        private void Spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            mostra = spinner.SelectedItem.ToString();
        }
    }
}