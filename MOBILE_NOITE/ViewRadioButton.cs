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
    [Activity(Label = "ViewRadioButton", MainLauncher = false)]
    public class ViewRadioButton : Activity
    {
        RadioButton rdPhp;
        RadioButton rdMysql;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //chama a a tela
            SetContentView(Resource.Layout.ViewRadioButton);
            // referencia
            rdPhp = FindViewById<RadioButton>(Resource.Id.rd03);
            rdMysql = FindViewById<RadioButton>(Resource.Id.rd04);

            //rdPhp.Click += RdPhp_Click;
            //rdMysql.Click += RdMysql_Click;
            rdPhp.Click += rdPhpMysql;
            rdMysql.Click += rdPhpMysql;

        }

        

        // criar
        private void rdPhpMysql(object sender, EventArgs e) {

            if (rdPhp.Checked == true) {
                Toast.MakeText(this, rdPhp.Text, ToastLength.Short).Show();
            }
            if (rdMysql.Checked == true) {

                Toast.MakeText(this, rdMysql.Text, ToastLength.Short).Show();
            }

        }



        private void RdMysql_Click(object sender, EventArgs e)
        {
            if (rdMysql.Checked == true)
            {
                Toast.MakeText(this, rdMysql.Text, ToastLength.Short).Show();
            }
        }

        private void RdPhp_Click(object sender, EventArgs e)
        {
            if (rdPhp.Checked == true) {
                Toast.MakeText(this,rdPhp.Text,ToastLength.Short).Show();
            }
        }
    }
}