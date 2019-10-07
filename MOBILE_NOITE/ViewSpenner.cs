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
    [Activity(Label = "ViewSpenner")]
    public class ViewSpenner : Activity
    {
        Spinner spn;
        string[] opcao = new string[] {"ACRE","AMAPA","BAHIA"};
        TextView lbl;
        ArrayAdapter arrayAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // chama o spinner
            SetContentView(Resource.Layout.ViewSpinner);

            // elemento
            spn = FindViewById<Spinner>(Resource.Id.sp01);
            lbl = FindViewById<TextView>(Resource.Id.lb_sp);

            // fazer o array(estado) ser compactado no arrayadapter
            arrayAdapter = new ArrayAdapter(this,
                Android.Resource.Layout.SimpleListItem1, opcao);

            spn.Adapter = arrayAdapter;
            spn.ItemSelected += Spn_ItemSelected;
        }

        private void Spn_ItemSelected(object sender,
            AdapterView.ItemSelectedEventArgs e)
        {
            // especificar o objeto de click
            Spinner sp = (Spinner)sender;
           // lbl  // propridade
           // lbl.Text = sp.SelectedItem.ToString();
            lbl.Text = sp.SelectedItemPosition.ToString();
            lbl.Text = e.Position.ToString();

        }
    }
}