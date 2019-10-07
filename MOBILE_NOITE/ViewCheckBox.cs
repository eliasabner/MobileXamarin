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






        }
    }
}