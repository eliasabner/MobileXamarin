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
            // 1º 
            var btComp = FindViewById<Button>(Resource.Id.AutoComplet);

            //2º AULA AUTOCOMPLETE XML
            Button btCompXML = FindViewById<Button>(Resource.Id.AutoCompletXML);

            //3°
            var btSpinner = FindViewById<Button>(Resource.Id.spinner);

            //4 SPINER XML BOTÃO

            var btSpinnerXml = FindViewById<Button>(Resource.Id.spinnerxml);
            
            //5º BOTÃO XML CHEKBOX
            var btcheckbox = FindViewById<Button>(Resource.Id.checkbox);

            // EVENTO 
            // 5
            btcheckbox.Click += (X, E) => {
                StartActivity(typeof(ViewCheckBox));
            };


            //1º
            btComp.Click += (sender, arg) => {
                // fazer um link(chamar tela)
                StartActivity(typeof(ViewAutoCompletTextView));

            };

            //2º
            btCompXML.Click += (x, y) => {
                //chamando a tela autocompetxml(link)
                StartActivity(typeof(ViewAutoCompletTextViewXML));
            };

            btSpinner.Click += (senderArg, arg) => {
                // chama a tela 
                StartActivity(typeof(ViewSpenner));

            };

            // 4°

            btSpinnerXml.Click += BtSpinnerXml_Click;

        }

        private void BtSpinnerXml_Click(object sender, EventArgs e)
        {
            // chamar a tela
            StartActivity(typeof(ViewSpinnerXml));
        }
    }
}