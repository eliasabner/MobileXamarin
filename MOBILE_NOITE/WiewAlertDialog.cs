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
    [Activity(Label = "WiewAlertDialog",MainLauncher = false,  Icon ="@drawable/PROJETO")]
    public class WiewAlertDialog : Activity
    {
        Button btAlert, btToast, btYeNo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // cs chamar o xml
            SetContentView(Resource.Layout.WiewAlertDialog);
            // pegar  o botão do xml
            btToast = FindViewById<Button>(Resource.Id.btToast);
            btAlert = FindViewById<Button>(Resource.Id.btAlert);
            btYeNo = FindViewById<Button>(Resource.Id.btAlertOkNo);

            // EVENTO DO BOTÃO
            btToast.Click += BtToast_Click;
            btAlert.Click += BtAlert_Click;
            btYeNo.Click += BtYeNo_Click;
        }

        private void BtYeNo_Click(object sender, EventArgs e)
        {
            //objeto
            AlertDialog.Builder alerta = new AlertDialog.Builder(this);
            //titulo
            alerta.SetTitle("YES NO");
            //icon
            alerta.SetIcon(Android.Resource.Drawable.IcLockLock);
            // ms
            alerta.SetMessage(" MENSAGEM");
            // EVENTOS
            alerta.SetPositiveButton("YES", ( senderAlert, arg)=> {
                Toast.MakeText(this, "clicou em yes",
                    ToastLength.Short).Show();
            });

            alerta.SetNegativeButton("NO", (senderAlert,arg)=> {

                Toast.MakeText(this, "clicou em no",
                    ToastLength.Short).Show();
            });

            alerta.SetNeutralButton("neutro", (senderAlert, arg) => {

                Toast.MakeText(this, "clicou em neutro",
                    ToastLength.Short).Show();
            });
            //MOSTRA
            alerta.Show();
        }

        private void BtAlert_Click(object sender, EventArgs e)
        {
            // OBJETO ALERT
            AlertDialog.Builder alerta = new AlertDialog.Builder(this);
            //titulo da caixa do alert
            alerta.SetTitle(" TITULO DA CAIXA");
            // MENSAGEN DA CAIXA ALERTA
            alerta.SetMessage(" MENSAGEM DE ALERTA ");
            // ICONES DA CAIXA
            alerta.SetIcon(Android.Resource.Drawable.IcDialogAlert);

            // EXIBIR
            alerta.Show();
        }

        private void BtToast_Click(object sender, EventArgs e)
        {
            // MENSAGEM NUVENS
            Toast.MakeText(this, "ALERTA DE MENSAGEM",
                ToastLength.Long).Show();
        }
    }
}