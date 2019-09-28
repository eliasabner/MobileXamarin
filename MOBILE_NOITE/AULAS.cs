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
    [Activity(Label = "AULAS", MainLauncher = true)]
    public class AULAS : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AULAS);
            // 
            var btComp = FindViewById<Button>(Resource.Id.AutoComplet);
            var btComXML = FindViewById<Button>(Resource.Id.AutoCompletXML);

            btComp.Click += (sender, arg) => {
                // fazer um link(chamar tela)
                StartActivity(typeof(ViewAutoCompletTextView));
            };

            btComXML.Click += (x, y) =>
            {
                StartActivity(typeof(ViewAutoCompletTextViewXML));
            };

        }
    }
}