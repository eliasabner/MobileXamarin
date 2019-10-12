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
    [Activity(Label = "RecebeAtvidade4")]
    public class RecebeAtvidade4 : Activity
    {
        TextView mostra;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RecebeAtvidade4);
            mostra = FindViewById<TextView>(Resource.Id.recebeAtvid4);

            string nome = Intent.GetStringExtra("nome");
            string estados = Intent.GetStringExtra("estados");
            string senha = Intent.GetStringExtra("senha");

            mostra.Text = nome +"\n"+estados+"\n"+senha;

        }
    }
}