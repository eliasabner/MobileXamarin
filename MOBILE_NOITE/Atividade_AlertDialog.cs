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
    [Activity(Label = "Atividade_AlertDialog", MainLauncher = false)]
    public class Atividade_AlertDialog : Activity
    {
        EditText nome;
        Button bt;
        TextView mostra;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Atividade_AlertDialog);
            // referencia
            nome = FindViewById<EditText>(Resource.Id.campoNome);
            bt = FindViewById<Button>(Resource.Id.btPer);
            mostra = FindViewById<TextView>(Resource.Id.mostraPer);

            bt.Click += Bt_Click;
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            AlertDialog.Builder alerta = new AlertDialog.Builder(this);
            // titulo da caixa
            alerta.SetTitle("titulo");
            // icone
            alerta.SetIcon(Android.Resource.Drawable.IcDialogAlert);
            //mensagem
            alerta.SetMessage("deseja mostra?");

            alerta.SetPositiveButton("SIM",(senderAlert, arg)=> {
                // .Text - pegar valor ou atribui
                mostra.Text = nome.Text;
            });

            alerta.SetNegativeButton("NÃO",(senderAlert,arg)=> {
                Toast.MakeText(this, "NÃO MOSTRAR", ToastLength.Short).Show();
                mostra.Text = "";
                nome.Text = "";
                //nome.Text = String.Empty;

            });

            alerta.Show();

            
            
            
        }
    }
}