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
    [Activity(Label = "ViewCheckBox")]
    public class ViewCheckBox : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //
            SetContentView(Resource.Layout.ViewCheckBox);

            var btck_ang = FindViewById<CheckBox>(Resource.Id.chk_angula);
            var btck_c = FindViewById<CheckBox>(Resource.Id.chk_c);
            var btck_css = FindViewById<CheckBox>(Resource.Id.chk_css);
            var btck_html = FindViewById<CheckBox>(Resource.Id.chk_html);
            var btck_js = FindViewById<CheckBox>(Resource.Id.chk_js);
            var btck_mysql = FindViewById<CheckBox>(Resource.Id.chk_mysql);
            var btck_php = FindViewById<CheckBox>(Resource.Id.chk_php);
            var btck_react = FindViewById<CheckBox>(Resource.Id.chk_react);
            var btck_vue = FindViewById<CheckBox>(Resource.Id.chk_vue);

            AlertDialog.Builder alerta = new AlertDialog.Builder(this);

            btck_ang.Click += (x, s) =>
            {
                if (btck_ang.Checked)
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetMessage(btck_ang.Text);
                    alert.Show();
                }
            };

            // Toast.MakeText(this,lista.Text,ToastLength.Short).Show();
            btck_c.Click += (Event, sender) =>
            {
                if (btck_c.Checked)
                {
                    Toast.MakeText(this, btck_c.Text, ToastLength.Short).Show();
                }

            };

            btck_css.Click += (Event, sender) =>
            {
                if (btck_css.Checked)
                {
                    Toast.MakeText(this, btck_css.Text, ToastLength.Short).Show();
                }

            };

            btck_html.Click += (Event, sender) =>
            {
                if (btck_html.Checked)
                {
                    Toast.MakeText(this, btck_html.Text, ToastLength.Short).Show();
                }

            };

            btck_js.Click += (Event, sender) =>
            {
                if (btck_js.Checked)
                {
                    alerta.SetMessage(btck_js.Text).Show();
                }

            };

            btck_mysql.Click += (Event, sender) =>
            {
                if (btck_mysql.Checked)
                {
                    alerta.SetMessage(btck_mysql.Text).Show();
                }

            };

            btck_php.Click += (Event, sender) =>
            {
                if (btck_php.Checked)
                {
                    alerta.SetMessage(btck_php.Text).Show();
                }

            };

            btck_react.Click += (Event, sender) =>
            {
                if (btck_react.Checked)
                {
                    alerta.SetMessage(btck_react.Text).Show();
                }

            };

            btck_vue.Click += (Event, sender) =>
            {
                if (btck_vue.Checked)
                {
                    alerta.SetMessage(btck_vue.Text).Show();
                }

            };

        }
    }
}