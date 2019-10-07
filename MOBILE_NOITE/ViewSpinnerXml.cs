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
    [Activity(Label = "ViewSpinnerXml")]
    public class ViewSpinnerXml : Activity
    {
        Spinner sp;
        TextView lbl;
        ArrayAdapter adapter;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // 
            SetContentView(Resource.Layout.ViewSpinner);

            // pegar o Spinner

            sp = FindViewById<Spinner>(Resource.Id.sp01);

            lbl = FindViewById<TextView>(Resource.Id.lb_sp);

            // CRIAR UM ARRAY COM ITEM XML E COLOCAR NO ADAPTER
            adapter = ArrayAdapter.CreateFromResource(this,
                Resource.Array.estadoXML, Android.Resource.Layout.SimpleListItem1);
            // SE ADAPTAR AO SPINNER
            sp.Adapter = adapter;
            sp.ItemSelected += Sp_ItemSelected;
        }
        private void Sp_ItemSelected(object sender, 
            AdapterView.ItemSelectedEventArgs e)
        {   Spinner cvsp = (Spinner)sender;
            // usar o evento para saber a posição ItemSelectedEventArgs

            //lbl.Text = e.Position.ToString();
            //lbl.Text = cvsp.SelectedItemPosition.ToString();

            //lbl.Text = cvsp.SelectedItem.ToString(); // retorno o texto

            lbl.Text = cvsp.GetItemAtPosition(e.Position).ToString();


        }
    }
}