using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MOBILE_NOITE
{
    [Activity(Label = "ViewsImageView", MainLauncher = false)]
    public class ViewsImageView : Activity
    {
        ImageButton img1, img2, img3;
        ImageView imgCentral;
        Drawable caminho;
     


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //chamar a tela xml
            SetContentView(Resource.Layout.ViewImageView);
            // referenciar os elementos xml com c#
            img1 = FindViewById<ImageButton>(Resource.Id.imgAndr);
            img2 = FindViewById<ImageButton>(Resource.Id.imgIos);
            img3 = FindViewById<ImageButton>(Resource.Id.xamrin);
            imgCentral = FindViewById<ImageView>(Resource.Id.imgv);

            // eventos do botão
            img1.Click += Img1_Click;
            img2.Click += Img2_Click;
            img3.Click += Img3_Click;
        }

        private void Img2_Click(object sender, EventArgs e)
        {
            // colocar a referencia do caminho da imagem grande
            caminho = Resources.GetDrawable(Resource.Drawable.ios);
            // colocar na imagem maior
            imgCentral.SetImageDrawable(caminho);
        }

        private void Img3_Click(object sender, EventArgs e)
        {
            // colocar a referencia do caminho da imagem grande
            caminho = Resources.GetDrawable(Resource.Drawable.XAMARIN);
            // colocar na imagem maior
            imgCentral.SetImageDrawable(caminho);
        }

        private void Img1_Click(object sender, EventArgs e)
        {    // colocar a referencia do caminho da imagem grande
            caminho = Resources.GetDrawable(Resource.Drawable.android);
            // colocar na imagem maior
            imgCentral.SetImageDrawable(caminho);

        }
    }
}