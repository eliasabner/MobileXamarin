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
    [Activity(Label = "ViewAutoCompletTextViewXML")]
    public class ViewAutoCompletTextViewXML : Activity
    {
        // Pegar estado
        ArrayAdapter<String> estado;
        AutoCompleteTextView lista;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ViewAutoCompletTextViewXML);
            //ReferenciA
            lista = FindViewById<AutoCompleteTextView>(Resource.Id.aut_xml);


        }
    }
}