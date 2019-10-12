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
    [Activity(Label = "Passagem_Parametro_Tela")]
    public class Passagem_Parametro_Tela : Activity
    {

        EditText campoNome;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Passagem_Parametro_Tela);

            var bt_passagem_tela = FindViewById<Button>(Resource.Id.bt_Passagem);
             campoNome = FindViewById<EditText>(Resource.Id.nomePassagem);

            bt_passagem_tela.Click += Bt_passagem_tela_Click;

        }

        private void Bt_passagem_tela_Click(object sender, EventArgs e)
        {
            //Objeto/ Instancia de tela
            Intent pag = new Intent(this, typeof(Recebe_Parametro_Tela));

            //Tratando o dado(Agrupando ou compactando os dados)
            Bundle dados = new Bundle();

            //Compactando o Dado
            dados.PutString("chaveNome", campoNome.Text);

            pag.PutExtras(dados);
            //Chama e passar o parametro
            StartActivity(pag);
           
        }
    }
}