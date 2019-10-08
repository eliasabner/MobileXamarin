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
    [Activity(Label = "Atividade3")]

   
    public class Atividade3 : Activity
    {
        Spinner spinner;
        TextView lbl;
        ArrayAdapter arrayAdapter;
        string mostra;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Atividae3);

            spinner = FindViewById<Spinner>(Resource.Id.spForm);
            //lbl = FindViewById<TextView>(Resource.Id.lb_form);

            // CRIAR UM ARRAY COM ITEM XML E COLOCAR NO ADAPTER
            arrayAdapter = ArrayAdapter.CreateFromResource(this,
                Resource.Array.estadoXML, Android.Resource.Layout.SimpleListItem1);
            // SE ADAPTAR AO SPINNER
            spinner.Adapter = arrayAdapter;
            spinner.ItemSelected += Spinner_ItemSelected;

        }

        private void Spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            mostra = spinner.SelectedItem.ToString();

            Toast.MakeText(this,mostra , ToastLength.Short).Show();
        }
    }
}