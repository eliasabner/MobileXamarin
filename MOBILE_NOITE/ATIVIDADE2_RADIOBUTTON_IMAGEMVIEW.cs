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
using Android.Graphics.Drawables;

namespace MOBILE_NOITE
{
    [Activity(Label = "ATIVIDADE2_RADIOBUTTON_IMAGEMVIEW", MainLauncher = false)]
    public class ATIVIDADE2_RADIOBUTTON_IMAGEMVIEW : Activity
    {
        Drawable caminho;
        ImageView imgCentral;
        RadioButton ios, xam, and;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //tela 
            SetContentView(Resource.Layout.ATIVIDADE2_RADIOBUTTON_IMAGEVIEW);
            // referencia dos elementos
            and = FindViewById<RadioButton>(Resource.Id.android);
            xam = FindViewById<RadioButton>(Resource.Id.xamarin);
            ios = FindViewById<RadioButton>(Resource.Id.IOS);
            imgCentral = FindViewById<ImageView>(Resource.Id.img01);

            and.Click += And_Click;

            xam.Click += (senderArg, arg) => {
                if (xam.Checked)
                {
                    caminho = Resources.GetDrawable(Resource.Drawable.XAMARIN);
                    imgCentral.SetImageDrawable(caminho);
                }
            };

            ios.Click += (senderArg, arg)=>{
                caminho = Resources.GetDrawable(Resource.Drawable.ios);
                imgCentral.SetImageDrawable(caminho);
            };


        }

        private void And_Click(object sender, EventArgs e)
        {    // caminho da imagem
            caminho = Resources.GetDrawable(Resource.Drawable.android);
            imgCentral.SetImageDrawable(caminho);
        }
    }
}