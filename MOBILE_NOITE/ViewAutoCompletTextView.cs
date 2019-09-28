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
    [Activity(Label = "ViewAutoCompletTextView")]
    public class ViewAutoCompletTextView : Activity
    {

        static string[] estado = new string[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "CURITIBA"
        };

        AutoCompleteTextView AutoC;
        static ArrayAdapter<String> adaptador;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ViewAutoCompletTextView);

            AutoC = FindViewById<AutoCompleteTextView>(
                Resource.Id.estado);

            adaptador = new ArrayAdapter<String>(this,
                Android.Resource.Layout.SimpleListItem1, estado);

            AutoC.Adapter = adaptador;

            //Evento AutoCompletView
            AutoC.ItemClick += AutoC_ItemClick;

        }

        private void AutoC_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var v = (AutoCompleteTextView)sender; 
            //retorna a posição do elemeneto clicado no auto view indice
            Toast.MakeText(this, e.Position.ToString(), ToastLength.Short).Show();
            //
            //Toast.MakeText(this,AutoC.Text , ToastLength.Short).Show();
        }

    }
}