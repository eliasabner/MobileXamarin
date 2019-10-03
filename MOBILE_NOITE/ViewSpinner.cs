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
    [Activity(Label = "ViewSpinner")]
    public class ViewSpinner : Activity
    {
        Spinner spn;
        string[] opcao = new string[] {"Acre","Amapa","Bahia" };
        TextView lbl;
        ArrayAdapter arrayAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            //Chama tela spinner
            SetContentView(Resource.Layout.ViewSpinner);

            //Elemento
            spn = FindViewById<Spinner>(Resource.Id.sp01);
            lbl = FindViewById<TextView>(Resource.Id.lb_sp);

            //Fazer o array(Estado) ser compactado no arrayAdapter
            arrayAdapter = new ArrayAdapter(this,Android.Resource.Layout.SimpleListItem1,opcao);

            spn.Adapter = arrayAdapter;

            spn.ItemSelected += Spn_ItemSelected;
        }

        private void Spn_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            //Especificar o objeto de click
            Spinner sp = (Spinner)sender;
            //lbl // propriedadeS
            //lbl.Text = sp.SelectedItem.ToString();
            lbl.Text = sp.SelectedItemPosition.ToString();
        }
    }
}