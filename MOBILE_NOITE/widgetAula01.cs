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
    [Activity(Label = "widgetAula01", MainLauncher = false)]
    public class widgetAula01 : Activity
    {
        EditText campoNomeCss;
        Button bt;
        TextView mostra;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // chamar a tela  do xml 
            SetContentView(Resource.Layout.widgetAula01);

            // pegar a referencia  do widget do xml
            // pegar o campo atraves do id do xml
            campoNomeCss = FindViewById<EditText>(Resource.Id.campoNome);
            bt = FindViewById<Button>(Resource.Id.bt);
            mostra = FindViewById<TextView>(Resource.Id.mostra);

            // evento de clicar
            bt.Click += Bt_Click;

        }
        // procedural(função) OOP(METODO)
        
        private void Bt_Click(object sender, EventArgs e)
        {
            // nuvem
            Toast.MakeText(this,campoNomeCss.Text,ToastLength.Short).Show();
            mostra.Text = campoNomeCss.Text;

        }
    }
}