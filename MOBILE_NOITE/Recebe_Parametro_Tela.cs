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
    [Activity(Label = "Recebe_Parametro_Tela")]
    public class Recebe_Parametro_Tela : Activity
    {
        TextView mostra;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Recebe_Parametro_Tela);
            mostra = FindViewById<TextView>(Resource.Id.recebeDados);

            //Pegar os dados enviado pelo activity passagem_parametro_tela

            string par = Intent.GetStringExtra("chaveNome");
            mostra.Text = par;
            
        }
    }
}